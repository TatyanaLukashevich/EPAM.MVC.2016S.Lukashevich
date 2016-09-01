﻿using day1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace day1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("ChromeRoute", "{controller}/{action}/{id}/{*catchall}",
             new { controller = "Home", action = "Index", id = UrlParameter.Optional },
             constraints: new { id = @"\d{2}", myConstraint = new UserAgentConstraint("/Home/Index/12") },
             namespaces: new[] { "day1.Controllers" });

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
               new
               {
                   controller = "Home",
                   action = "Index",
                   id = UrlParameter.Optional,
                   httpMethod = new HttpMethodConstraint("GET")
               },

            new[] { "AdditionalContollers" });


            routes.MapRoute("", "Public/{controller}/{action}",
                new
                {
                    controller = "Home",
                    action = "Index"
                });

            routes.MapRoute("AnotherRoute", "{controller}/{action}/{id}",
              new
              {
                  controller = "Home",
                  action = "Index",
                  id = "DefaultId"
              },
              new[] { "AdditionalContollers" });

            routes.MapRoute("Route", "{controller}/{action}/{id}",
                 new
                 {
                     controller = "Home",
                     action = "Index",
                     id = UrlParameter.Optional
                 },
                 new
                 {
                     controller = "^H.*",
                     action = "^Index$|^About$"
                 },
                 namespaces: new[] { "day1.Controllers" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "day1.Controllers" }
            );
        }
    }
}
