using day2.Homework2.Models;
using System.Web.Mvc;

namespace day2.Homework2.Controllers
{
    public class HomeController : BaseController
    {
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