using day2.Homework2.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace day2.Homework2.Controllers
{
    public class UserController : BaseController
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
            return View("UserList", users);
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