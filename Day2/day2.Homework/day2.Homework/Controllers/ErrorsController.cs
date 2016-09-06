using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day2.Homework.Controllers
{
    public class ErrorsController : Controller
    {
        protected override void HandleUnknownAction(string actionName)
        {
            ViewData["actionName"] = actionName;
            View("NotFound").ExecuteResult(this.ControllerContext);
        }
        // GET: Errors
        public ActionResult Index()
        {
            return View();
        }
    }
}