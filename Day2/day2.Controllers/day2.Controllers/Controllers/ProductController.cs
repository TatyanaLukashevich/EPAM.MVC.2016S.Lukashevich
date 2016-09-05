using day2.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day2.Controllers.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "ProductController",
                ActionName = "Index"
            });
        }

        public ActionResult List()
        {
            return View("Result", new Result
            {
                ControllerName = "ProductController",
                ActionName = "List"
            });
        }

    }
}