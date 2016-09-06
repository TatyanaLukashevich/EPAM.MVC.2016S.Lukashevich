using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace day2.Homework
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                   name: "CustomerAdd",
                   url: "Customer/{action}/{id}",
                   defaults: new { controller = "User", action = "Add-User", id = UrlParameter.Optional }
               );

            routes.MapRoute(
                name: "UserAdd",
                url: "User/{action}/{id}",
                defaults: new { controller = "User", action = "Add-User", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                  name: "CustomerGetAll",
                  url: "Customer/{action}/{id}",
                  defaults: new { controller = "User", action = "User-List", id = UrlParameter.Optional }
              );

            routes.MapRoute(
                name: "UserGetAll",
                url: "User/{action}/{id}",
                defaults: new { controller = "User", action = "User-List", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
