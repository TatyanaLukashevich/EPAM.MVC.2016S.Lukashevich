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
            //Вызов метода MapMvcAttributeRoutes() заставляет систему маршрутизации проинспектировать классы контроллеров в приложении в поисках атрибутов, конфигурирующих маршруты. 
            //routes.MapMvcAttributeRoutes();

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

          //  routes.MapRoute(
          //     name: "UserControllerRoute",
          //     url: "{User}/{action}/{id}",
          //     defaults: new { controller = "UserCustomerController", action = "Index", id = UrlParameter.Optional }
          // );

          //  routes.MapRoute(
          //    name: "CustomerControllerRoute",
          //    url: "{Customer}/{action}/{id}",
          //    defaults: new { controller = "UserCustomerController", action = "Index", id = UrlParameter.Optional }
          //);

            //routes.MapRoute(
            //   name: "Error",
            //   url: "{*url}",
            //   defaults: new { controller = "Errors", action = "NotFound" }  // 404s
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
