using day2.Controllers.Infrastructure;
using day2.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day2.Controllers.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "CustomerController",
                ActionName = "Index"
            });
        }

        [Local]
        [ActionName("Index")]
        public ActionResult List()
        {
            return View("Result", new Result
            {
                ControllerName = "CustomerController",
                ActionName = "List"
            });
        }
    }
}