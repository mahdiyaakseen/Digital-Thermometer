using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace ThermomterUI
{
    public partial class Form1 : Form
    {
        SerialPort comPort = new SerialPort();

        //internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);
        //internal delegate void SerialPinChangedEventHandlerDelegate(object sender, SerialPinChangedEventArgs e);
        //private SerialPinChangedEventHandler SerialPinChangedEventHandler1;
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;

        int BaudRate = 9600; // default Baud rate for TTI7-R

        public Form1()
        {
            InitializeComponent();
            //SerialPinChangedEventHandler1 = new SerialPinChangedEventHandler(PinChanged);
            //comPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);

            //check back light status DISPIay:BACKIight?
            //  if on 
            //      set ckbBackLight checkbox status to on
            //  else 
            //      set ckbBackLight checkbox status to off

            //check beeper status SYSTem:BEEPer:STATe?
            //  if on 
            //      set ckbBeeper checkbox status to on
            //  else 
            //      set ckbBeeper checkbox status to off


        }

        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;
            ArrayComPortsNames = SerialPort.GetPortNames();
            do {
                index += 1;
                cbPorts.Items.Add(ArrayComPortsNames[index]);
            }
            while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            //want to get first out
            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            cbPorts.Text = ArrayComPortsNames[0];

            //Baud Rate
            cbBaudRate.Items.Add(300);
            cbBaudRate.Items.Add(600);
            cbBaudRate.Items.Add(1200);
            cbBaudRate.Items.Add(2400);
            cbBaudRate.Items.Add(9600);
            cbBaudRate.Items.Add(14400);
            cbBaudRate.Items.Add(19200);
            cbBaudRate.Items.Add(38400);
            cbBaudRate.Items.Add(57600);
            cbBaudRate.Items.Add(115200);
            cbBaudRate.Items.ToString();
            //get first item print in text
            cbBaudRate.Text = cbBaudRate.Items[0].ToString();
            //Data Bits
            cbDataBits.Items.Add(7);
            cbDataBits.Items.Add(8);
            //get the first item print it in the text 
            cbDataBits.Text = cbDataBits.Items[0].ToString();

            //Stop Bits
            cbStopBits.Items.Add("One");
            cbStopBits.Items.Add("OnePointFive");
            cbStopBits.Items.Add("Two");
            //get the first item print in the text
            cbStopBits.Text = cbStopBits.Items[0].ToString();
            //Parity 
            cbParity.Items.Add("None");
            cbParity.Items.Add("Even");
            cbParity.Items.Add("Mark");
            cbParity.Items.Add("Odd");
            cbParity.Items.Add("Space");
            //get the first item print in the text
            cbParity.Text = cbParity.Items[0].ToString();
            //Handshake
            cbHandShaking.Items.Add("None");
            cbHandShaking.Items.Add("XOnXOff");
            cbHandShaking.Items.Add("RequestToSend");
            cbHandShaking.Items.Add("RequestToSendXOnXOff");
            //get the first item print it in the text 
            cbHandShaking.Text = cbHandShaking.Items[0].ToString();
        }

        private void btnUpdateBaudRate_Click(object sender, EventArgs e)
        {
            if (cbBaudRate.SelectedIndex > -1)
            {
                // check if unit is already in communication

                //if unit in communication prompt user if he still wants to continue , log

                //else end all commincation and reset , log 

                // update BD according to BD specified in unit
                BaudRate = Int32.Parse( cbBaudRate.Items[cbBaudRate.SelectedIndex].ToString()); 
                // log bd update
            }
            else
            {
                // promt user BD not selected
                MessageBox.Show("Please Select Baud Rate", "Baud Rate",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                // log error
            
            }
            
        }

        private void btnSelfTest_Click(object sender, EventArgs e)
        {
            // check any message in queue
            // initiate self test sequence 

            // start polling for status - *TST?
            comPort.Write("*TST");

        }

        private void ckbBackLight_CheckedChanged(object sender, EventArgs e)
        {
            // check if any other command is in progress
            //   if yes 
            //        notify user unit is busy , retry again
            //   else
                    if (ckbBackLight.Checked)
                    {
                        // send command to unit to ON - DISPlay:BACKlight 1
                        comPort.Write("DISPlay:BACKlight 1");
                        ckbBackLight.Text = "ON";                 
                    }
                    else
                    {
                        // send command to unit to OFF - DISPlay:BACKlight 0
                        comPort.Write("DISPlay:BACKlight 0");
                        ckbBackLight.Text = "OFF";                
                    }
            
        }

        private void ckbBeeper_CheckedChanged(object sender, EventArgs e)
        {
            // check if any other command is in progress
            //   if yes 
            //        notify user unit is busy , retry again
            //   else
            if (ckbBeeper.Checked)
            {
                // send command to unit to ON - SYSTem:BEEPer:STATe 1
                comPort.Write("SYSTem:BEEPer:STATe 1");
                ckbBeeper.Text = "ON";
            }
            else
            {
                // send command to unit to OFF - SYSTem:BEEPer:STATe 0
                comPort.Write("SYSTem:BEEPer:STATe 0");
                ckbBeeper.Text = "OFF";
            }
        }

        private void ckbTimeAndDateDisplayAndLog_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTimeAndDateDisplayAndLog.Checked)
            {

                Regex rgx = new Regex(@"^$"); // should match 1s, 2s, 3d, 4h time interval format
                if (!string.IsNullOrEmpty(rtbUpdateFrequency.Text) && rgx.IsMatch(rtbUpdateFrequency.Text)) 
                {
                    //set polling time time interval 

                    // query system date format SYSTem: DATE: FORMat ?
                    comPort.Write("SYSTem: DATE: FORMat ?");
                    // query system date - SYSTem :DATE?
                    comPort.Write("SYSTem: DATE?");


                    // query system time - SYSTem :TIME?
                    comPort.Write("SYSTem :TIME?");
                    // display to ui
                    //rtbTimeAndDateDisplay.Text = timeAndDate.ToString();

                    // log to CSV 
                }
            }
            else
            {
                // stop polling 
                // log to csv - end of polling
            }
        }

        private void tmrPollForReceivedData_Tick(object sender, EventArgs e)
        {
            InputData = comPort.ReadExisting();
            if (InputData != string.Empty )
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
                rtbTimeAndDateDisplay.Text = InputData;
            } 
            else
            {

            }
            
        }

        private void SetText(string text)
        {
            this.rtbIncoming.Text += text;
        }
    }
}
