using day1.Infrastructure;
using System.Web.Mvc;
using System.Web.Routing;

namespace day1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("SpecificRoute", "{controller}/{action}/{id}/{*catchall}",
             new
             { controller = "Home",
                 action = "Index",
                 id = UrlParameter.Optional,
                 httpMethod = new HttpMethodConstraint("GET")
             },
             constraints: new
             {
                 id = @"\d{2}",
                 myConstraint = new UserAgentConstraint("/home/index/12") },
                 namespaces: new[] { "day1.Controllers" });

            routes.MapRoute("", "Public/{controller}/{action}/{id}",
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = "DefaultId"
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
                defaults: new { controller = "Home", action = "Index"},
                namespaces: new[] { "day1.Controllers" }
            );
        }
    }
}
