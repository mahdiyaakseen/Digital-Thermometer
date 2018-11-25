using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IsotechThermometer.Models;

namespace IsotechThermometer.Controllers
{
    public class UnitStatusesController : Controller
    {

        public UnitStatus unitStatus ;

        // GET: UnitStatuses/GetStatus
        [Route("UnitStatuses/GetStatus/{StatusType}")]
        public ActionResult GetStatus(string StatusType) 
        {
            //set status to true or false
            var unitStatus = StatusTypeSwitch(StatusType);
            return View(unitStatus);
        }


        // GET: UnitStatuses/GetStatus
        [Route("UnitStatuses/SetStatus/{StatusType}")]
        public ActionResult SetStatus(string StatusType)
        {
            //set status to true or false
            var unitStatus = StatusTypeSwitch(StatusType); 
            return View(unitStatus);
        }

        private UnitStatus StatusTypeSwitch(string unitStatusType)
        {
            var unitStatus = new UnitStatus();
            switch (unitStatusType)
            {
                case "SelfTest":
                    unitStatus.Name = "Self Test";
                    //get /set selftest status
                    break;
                case "Beeper":
                    unitStatus.Name = "Beeper" ;
                    //get/set Beeper status
                    break;
                case "BackLight":
                    unitStatus.Name = "Back Light";
                    //get/set blacklight status
                    break;
                case "TimeAndDateLogging":
                    unitStatus.Name = "Time And Date Logging" ;
                    //get/set TimeandDate status
                    break;
                default:
                    //do nothing
                    break;
            }
            return unitStatus;
        }
    }
}