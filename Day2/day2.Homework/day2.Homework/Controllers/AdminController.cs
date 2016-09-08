using day2.Homework.Infrasructure;
using day2.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day2.Homework.Controllers
{
    public class AdminController : BaseController
    {
        [Local]
        public ActionResult Delete()
        {
            UserRepository.Delete();
            return View();
        }
    }
}