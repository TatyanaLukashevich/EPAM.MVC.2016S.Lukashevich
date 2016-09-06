using day2.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace day2.Homework.Controllers
{
    public class UserController : Controller
    {
        [ActionName("Add-User")]
        [HttpGet]
        public ActionResult Add()
        {
            return View("Add");
        }

        [ActionName("Add-User")]
        [HttpPost]
        public async Task<ActionResult> Add(UserViewModel user)
        {
            var users = await UserRepository.Add(user);
            return View("User-List", users);
        }

        [ActionName("User-List")]
        [HttpGet]
        public ActionResult UserList()
        {
            return View("UserList", UserRepository.GetAll());
        }

        [ActionName("User-List")]
        [HttpPost]
        public ActionResult UserListJson()
        {
            var users = UserRepository.GetAll();
            return Json(users);
        }
    }
}