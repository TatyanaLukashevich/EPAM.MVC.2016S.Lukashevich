using day2.Homework2.Infrastructure;
using System.Web.Mvc;
using System.Web.Routing;

namespace day2.Homework2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());
        }
    }
}
