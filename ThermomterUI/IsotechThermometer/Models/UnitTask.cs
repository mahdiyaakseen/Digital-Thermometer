using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IsotechThermometer.Models
{
    public class UnitTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UnitStatus StatusType { get; set; } = new UnitStatus();  //Self Test , Beeper etc.,
        public TaskState TaskState { get; set; }
        public Boolean DataRecievedState { get; set; }
        public string Data { get; set; }

        //contructor 
        public UnitTask()
        {
            Id = 0;
            Name = string.Empty;
            StatusType = new UnitStatus() {Id=0, Name= string.Empty, State=false, StateToggled=false};
            TaskState = TaskState.NotStarted;
            DataRecievedState = false;
            Data = string.Empty;
        }
    }    
    //tristate enum to represent task state
    public enum TaskState :byte
    {     
        NotStarted = 0,
        Inaction = 1,
        Completed = 2
    }
}