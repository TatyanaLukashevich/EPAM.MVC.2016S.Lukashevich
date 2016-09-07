using day3.Homework.Infrastructure;
using day3.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day3.Homework.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View("Person");
        }


        [HttpPost]
        public ActionResult Index(Person person)
        {
            PersonRepository.Add(person);
            var model = PersonRepository.persons;
            return View("PersonInfo", person);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var model = PersonRepository.persons;
            return View(model);
        }

        [HttpPost]
        public ActionResult ChangeSide(Person person)
        {
            if(person.Type == TypePerson.Dark)
            {
                return PartialView("Dark");
            }
            return View("PersonInfo", person);
        }
    }
}