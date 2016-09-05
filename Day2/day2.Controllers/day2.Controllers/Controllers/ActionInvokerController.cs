using System.Web.Mvc;
using day2.Controllers.Infrastructure;

namespace day2.Controllers.Controllers
{
    public class ActionInvokerController : Controller
    {
       public ActionInvokerController()
        {
            this.ActionInvoker = new CustomActionInvoker();
        }
    }
}