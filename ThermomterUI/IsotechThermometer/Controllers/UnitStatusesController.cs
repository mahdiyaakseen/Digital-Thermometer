﻿using System;
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
        [Route("UnitStatuses/GetStatus/{StatusName}")]
        public ActionResult GetStatus(string StatusName) 
        {
            //set status to true or false
            unitStatus = StatusTypeSwitch(StatusName);
            return View(unitStatus);
        }


        //// GET: UnitStatuses/GetStatus
        //[Route("UnitStatuses/SetStatus/{StatusName}")]
        //public ActionResult SetStatus(string StatusName)
        //{
        //    //set status to true or false
        //    var unitStatus = StatusTypeSwitch(StatusName, true); 
        //    return View(unitStatus);
        //}

        private UnitStatus StatusTypeSwitch(string unitStatusName)
        {
            var unitStatus = new UnitStatus();
            switch (unitStatusName)
            {
                case "SelfTest":
                    unitStatus.Name = "Self Test";
                    //call method to get selftest status
                    break;
                case "Beeper":
                    unitStatus.Name = "Beeper" ;
                    //call method to get selftest status
                    break;
                case "BackLight":
                    unitStatus.Name = "Back Light";
                    //call method to get selftest status
                    break;
                case "TimeAndDateLogging":
                    unitStatus.Name = "Time And Date Logging" ;
                    //call method to get selftest status
                    break;
                default:
                    //do nothing
                    break;
            }
            return unitStatus;
        }
    }
}