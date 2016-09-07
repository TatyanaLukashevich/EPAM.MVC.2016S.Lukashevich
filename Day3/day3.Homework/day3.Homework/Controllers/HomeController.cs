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
            person = PersonRepository.persons.LastOrDefault();
            if(person.Type == TypePerson.Dark)
            {
                return View("PersonInfo", person);
            }
            else
            {
                person.Type = TypePerson.Dark;
            }
            return View("PersonInfo", person);
        }

        [HttpGet]
        public ActionResult ChangeSide()
        {
            return View("PersonInfo");
        }

        [HttpGet]
        public ActionResult GetDark()
        {
            var model = PersonRepository.persons;
            return View(model.Where(p => p.Type == TypePerson.Dark));
        }

        [HttpGet]
        public ActionResult GetLight()
        {
            var model = PersonRepository.persons;
            return View(model.Where(p => p.Type == TypePerson.Light));
        }
    }
}