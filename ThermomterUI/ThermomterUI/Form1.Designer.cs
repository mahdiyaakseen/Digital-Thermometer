namespace ThermomterUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetSerialPorts = new System.Windows.Forms.Button();
            this.rtbIncoming = new System.Windows.Forms.RichTextBox();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.v = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbHandShaking = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateBaudRate = new System.Windows.Forms.Button();
            this.btnSelfTest = new System.Windows.Forms.Button();
            this.rtbSelfTestStatus = new System.Windows.Forms.RichTextBox();
            this.ckbBackLight = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbBeeper = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbTimeAndDateDisplayAndLog = new System.Windows.Forms.CheckBox();
            this.rtbTimeAndDateDisplay = new System.Windows.Forms.RichTextBox();
            this.rtbUpdateFrequency = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Location = new System.Drawing.Point(26, 22);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(75, 23);
            this.btnGetSerialPorts.TabIndex = 0;
            this.btnGetSerialPorts.Text = "Ports";
            this.btnGetSerialPorts.UseVisualStyleBackColor = true;
            this.btnGetSerialPorts.Click += new System.EventHandler(this.btnGetSerialPorts_Click);
            // 
            // rtbIncoming
            // 
            this.rtbIncoming.Location = new System.Drawing.Point(61, 241);
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.Size = new System.Drawing.Size(211, 69);
            this.rtbIncoming.TabIndex = 1;
            this.rtbIncoming.Text = "";
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(151, 24);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 21);
            this.cbPorts.TabIndex = 2;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(151, 51);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cbBaudRate.TabIndex = 3;
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(151, 78);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 21);
            this.cbDataBits.TabIndex = 4;
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(33, 54);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(58, 13);
            this.v.TabIndex = 5;
            this.v.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Bits";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(151, 138);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 21);
            this.cbParity.TabIndex = 7;
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Location = new System.Drawing.Point(151, 111);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(121, 21);
            this.cbStopBits.TabIndex = 8;
            // 
            // cbHandShaking
            // 
            this.cbHandShaking.FormattingEnabled = true;
            this.cbHandShaking.Location = new System.Drawing.Point(151, 189);
            this.cbHandShaking.Name = "cbHandShaking";
            this.cbHandShaking.Size = new System.Drawing.Size(121, 21);
            this.cbHandShaking.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stop Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hand Shaking";
            // 
            // btnUpdateBaudRate
            // 
            this.btnUpdateBaudRate.Location = new System.Drawing.Point(97, 54);
            this.btnUpdateBaudRate.Name = "btnUpdateBaudRate";
            this.btnUpdateBaudRate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBaudRate.TabIndex = 14;
            this.btnUpdateBaudRate.Text = "Update BR";
            this.btnUpdateBaudRate.UseVisualStyleBackColor = true;
            this.btnUpdateBaudRate.Click += new System.EventHandler(this.btnUpdateBaudRate_Click);
            // 
            // btnSelfTest
            // 
            this.btnSelfTest.Location = new System.Drawing.Point(350, 78);
            this.btnSelfTest.Name = "btnSelfTest";
            this.btnSelfTest.Size = new System.Drawing.Size(101, 23);
            this.btnSelfTest.TabIndex = 15;
            this.btnSelfTest.Text = "Unit Self Test";
            this.btnSelfTest.UseVisualStyleBackColor = true;
            this.btnSelfTest.Click += new System.EventHandler(this.btnSelfTest_Click);
            // 
            // rtbSelfTestStatus
            // 
            this.rtbSelfTestStatus.Location = new System.Drawing.Point(496, 67);
            this.rtbSelfTestStatus.Name = "rtbSelfTestStatus";
            this.rtbSelfTestStatus.Size = new System.Drawing.Size(166, 48);
            this.rtbSelfTestStatus.TabIndex = 16;
            this.rtbSelfTestStatus.Text = "";
            // 
            // ckbBackLight
            // 
            this.ckbBackLight.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbBackLight.AutoSize = true;
            this.ckbBackLight.Location = new System.Drawing.Point(496, 134);
            this.ckbBackLight.Name = "ckbBackLight";
            this.ckbBackLight.Size = new System.Drawing.Size(37, 23);
            this.ckbBackLight.TabIndex = 17;
            this.ckbBackLight.Text = "OFF";
            this.ckbBackLight.UseVisualStyleBackColor = true;
            this.ckbBackLight.CheckedChanged += new System.EventHandler(this.ckbBackLight_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Unit Back Light";
            // 
            // ckbBeeper
            // 
            this.ckbBeeper.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbBeeper.AutoSize = true;
            this.ckbBeeper.Location = new System.Drawing.Point(496, 186);
            this.ckbBeeper.Name = "ckbBeeper";
            this.ckbBeeper.Size = new System.Drawing.Size(37, 23);
            this.ckbBeeper.TabIndex = 19;
            this.ckbBeeper.Text = "OFF";
            this.ckbBeeper.UseVisualStyleBackColor = true;
            this.ckbBeeper.CheckedChanged += new System.EventHandler(this.ckbBeeper_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Unit Beeper State";
            // 
            // ckbTimeAndDateDisplayAndLog
            // 
            this.ckbTimeAndDateDisplayAndLog.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbTimeAndDateDisplayAndLog.AutoSize = true;
            this.ckbTimeAndDateDisplayAndLog.Location = new System.Drawing.Point(356, 239);
            this.ckbTimeAndDateDisplayAndLog.Name = "ckbTimeAndDateDisplayAndLog";
            this.ckbTimeAndDateDisplayAndLog.Size = new System.Drawing.Size(124, 23);
            this.ckbTimeAndDateDisplayAndLog.TabIndex = 21;
            this.ckbTimeAndDateDisplayAndLog.Text = "Display Time and Date";
            this.ckbTimeAndDateDisplayAndLog.UseVisualStyleBackColor = true;
            this.ckbTimeAndDateDisplayAndLog.CheckedChanged += new System.EventHandler(this.ckbTimeAndDateDisplayAndLog_CheckedChanged);
            // 
            // rtbTimeAndDateDisplay
            // 
            this.rtbTimeAndDateDisplay.Location = new System.Drawing.Point(539, 316);
            this.rtbTimeAndDateDisplay.Name = "rtbTimeAndDateDisplay";
            this.rtbTimeAndDateDisplay.Size = new System.Drawing.Size(220, 48);
            this.rtbTimeAndDateDisplay.TabIndex = 22;
            this.rtbTimeAndDateDisplay.Text = "";
            // 
            // rtbUpdateFrequency
            // 
            this.rtbUpdateFrequency.Location = new System.Drawing.Point(539, 274);
            this.rtbUpdateFrequency.Name = "rtbUpdateFrequency";
            this.rtbUpdateFrequency.Size = new System.Drawing.Size(79, 36);
            this.rtbUpdateFrequency.TabIndex = 23;
            this.rtbUpdateFrequency.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Frequency of Time and Date Update";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Time and Date";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(770, 328);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 23);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Log to CSV";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 377);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbUpdateFrequency);
            this.Controls.Add(this.rtbTimeAndDateDisplay);
            this.Controls.Add(this.ckbTimeAndDateDisplayAndLog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckbBeeper);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckbBackLight);
            this.Controls.Add(this.rtbSelfTestStatus);
            this.Controls.Add(this.btnSelfTest);
            this.Controls.Add(this.btnUpdateBaudRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbHandShaking);
            this.Controls.Add(this.cbStopBits);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.rtbIncoming);
            this.Controls.Add(this.btnGetSerialPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSerialPorts;
        private System.Windows.Forms.RichTextBox rtbIncoming;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbHandShaking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateBaudRate;
        private System.Windows.Forms.Button btnSelfTest;
        private System.Windows.Forms.RichTextBox rtbSelfTestStatus;
        private System.Windows.Forms.CheckBox ckbBackLight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbBeeper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbTimeAndDateDisplayAndLog;
        private System.Windows.Forms.RichTextBox rtbTimeAndDateDisplay;
        private System.Windows.Forms.RichTextBox rtbUpdateFrequency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

