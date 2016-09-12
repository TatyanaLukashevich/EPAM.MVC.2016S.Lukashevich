using System.Web.Mvc;
using Models.Data;
using Models.Models;

namespace Models.Controllers
{
    public class HomeController : Controller
    {
	    private readonly IPersonRepo _repo;

	    public HomeController(IPersonRepo personRepo)
	    {
		    _repo = personRepo;
	    }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Person person)
        {
            if (TryUpdateModel(person))
            {
                return View(person);
            }

            return View();
        }

        //public ActionResult IndexFromQuery(Person person)
        //{
        //    if (TryUpdateModel(person, new QueryStringValueProvider(ControllerContext)))
        //    {
        //        return View("Index", person);
        //    }

        //    return View("Index");
        //}
    }
}