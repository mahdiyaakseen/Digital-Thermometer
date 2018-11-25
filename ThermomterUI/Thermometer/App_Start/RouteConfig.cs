using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IsotechThermometer
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

          //  routes.MapRoute(
          //     name: "GetUnitStatusByType",
          //     url: "UnitStatuses/GetStatus/{StatusType}",
          //     defaults: new { controller = "UnitStatuses", action = "GetStatus" }
          // );
          //  routes.MapRoute(
          //    name: "SetUnitStatusByType",
          //    url: "UnitStatuses/SetStatus/{StatusType}",
          //    defaults: new { controller = "UnitStatuses", action = "SetStatus" }
          //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
