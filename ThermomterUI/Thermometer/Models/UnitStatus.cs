using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IsotechThermometer.Models
{
    public class UnitStatus
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Boolean State { get; set; }
        public Boolean StateToggled { get; set; }
    }
}