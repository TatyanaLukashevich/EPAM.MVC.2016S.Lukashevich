using System.Web.Mvc;

namespace day2.Homework.Controllers
{
    public class BaseController : Controller
    {
        protected override void HandleUnknownAction(string actionName)
        {
            try
            {
                this.View(actionName).ExecuteResult(this.ControllerContext);
            }
            catch
            {
                this.View("Error404").ExecuteResult(this.ControllerContext);
            }
        }
    }
}