using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace day2.Homework.Controllers
{
    public abstract class BaseController : Controller
    {
        //#region Http404 handling

        //protected override void HandleUnknownAction(string actionName)
        //{
        //    // Если контроллер - ErrorController, то не нужно снова вызывать исключение
        //    if (this.GetType() != typeof(ErrorController))
        //        this.InvokeHttp404(HttpContext);
        //}

        //public ActionResult InvokeHttp404(HttpContextBase httpContext)
        //{
        //    IController errorController = ObjectFactory.GetInstance<ErrorController>();
        //    var errorRoute = new RouteData();
        //    errorRoute.Values.Add("controller", "Error");
        //    errorRoute.Values.Add("action", "Http404");
        //    errorRoute.Values.Add("url", httpContext.Request.Url.OriginalString);
        //    errorController.Execute(new RequestContext(
        //         httpContext, errorRoute));

        //    return new EmptyResult();
        //}

        //#endregion
    }
}