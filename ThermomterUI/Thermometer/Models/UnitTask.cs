using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IsotechThermometer.Models
{
    public class UnitTask
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Boolean TaskState { get; set; }  // set to true if in action, else false
    }
}