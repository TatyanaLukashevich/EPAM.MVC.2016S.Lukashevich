using day2.Homework2.Controllers;
using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace day2.Homework2.Infrastructure
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type targetType = null;
            switch (controllerName)
            {
                case "Customer":
                    targetType = typeof(UserController);
                    break;
                case "User":
                    targetType = typeof(UserController);
                    break;
                case "Home":
                    targetType = typeof(HomeController);
                    break;
                case "Base":
                    targetType = typeof(BaseController);
                    break;
                case "Admin":
                    if (!requestContext.HttpContext.Request.IsLocal)
                    {
                        throw new AccessViolationException();
                    }

                    targetType = typeof(AdminController);
                    break;
                default:
                    requestContext.RouteData.Values["controller"] = "Home";
                    targetType = typeof(HomeController);
                    break;
            }

            return targetType == null ? null : (IController)DependencyResolver.Current.GetService(targetType);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            if(controllerName.Equals("Home"))
            {
                return SessionStateBehavior.Disabled;
            }
            else
            {
                return SessionStateBehavior.Default;
            }
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            disposable?.Dispose();
        }
    }
}