using System.Web.Mvc;

namespace AdditionalContollers
{
    public class HomeController : Controller 
    {
        public ActionResult Index()
        {
            string data = "hello from additional controller";
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
