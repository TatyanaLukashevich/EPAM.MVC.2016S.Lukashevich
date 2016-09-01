using System.Web.Mvc;

namespace AdditionalContollers
{
    public class HomeController : Controller 
    {
        [HttpGet]
        public ActionResult Index()
        {
            string data = "hello from additional controller";
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
