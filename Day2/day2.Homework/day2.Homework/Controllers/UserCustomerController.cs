using day2.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace day2.Homework.Controllers
{
    public class UserCustomerController : Controller
    {
        [HttpPost]
        [ActionName("Add-User")]
        public async Task<ActionResult> AddUser()
        {
            await Task.Factory.StartNew(() => UserRepository.AddAsync());
            
            return RedirectToAction("User-List");
        }

        [HttpGet]
        [ActionName("User-List")]
        public ActionResult GetUserList()
        {
            var users = UserRepository.GetAll();
            return Json(users);
        }
    }
}