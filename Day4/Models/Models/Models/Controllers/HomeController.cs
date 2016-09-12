using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        //[HttpPost]
        //[ActionName("Index")]
        //public ActionResult IndexFromQuery(Person person)
        //{
        //    if (TryUpdateModel(person, new QueryStringValueProvider(ControllerContext)))
        //    {
        //        return View("Index", person);
        //    }

        //    return View("Index");
        //}







        //public ActionResult CreatePerson()
        //{
        //    return View(new Person());
        //}


        //[HttpPost]
        //public ActionResult CreatePerson(Person model)
        //{
        //    return View("Index", model);
        //}

        //public ActionResult DisplaySummary(
        //    [Bind(Prefix = "HomeAddress")] Address summary)
        //{
        //    return View(summary);
        //}

        //public ActionResult Names(string[] names)
        //{
        //    names = names ?? new string[0];
        //    return View(names);
        //}

        //public ActionResult Addresses()
        //{
        //    IList<Address> addresses = new List<Address>();
        //    UpdateModel(addresses);
        //    return View(addresses);
        //}
    }
}