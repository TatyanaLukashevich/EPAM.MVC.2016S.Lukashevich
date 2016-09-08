using day2.Homework2.Models;
using System.Web.Mvc;

namespace day2.Homework2.Controllers
{
    public class AdminController : BaseController
    {
        public ActionResult Delete()
        {
            UserRepository.Delete();
            return View();
        }
    }
}