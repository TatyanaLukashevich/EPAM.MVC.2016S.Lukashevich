using day2.Controllers.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day2.Controllers.Controllers
{
    public class RemoteDataController : Controller
    {
        // GET: RemoteData
        public ActionResult Data()
        {
            RemoteService service = new RemoteService();
            string data = service.GetRemoteData();
            return View((object)data);
        }
    }
}