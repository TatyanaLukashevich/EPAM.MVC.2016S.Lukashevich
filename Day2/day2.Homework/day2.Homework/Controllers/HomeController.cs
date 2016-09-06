using day2.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace day2.Homework.Controllers
{
    //[SessionState(SessionStateBehavior.Disabled)]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "HomeController",
                ActionName = "Index"
            });
        }
    }
}