using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day3.Classwork.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("CustomData");
        }

        public ActionResult AnotherAction()
        {
            string[] fruits = { "apple", "banana", "cherry" };
            return View(fruits);
        }
    }
}