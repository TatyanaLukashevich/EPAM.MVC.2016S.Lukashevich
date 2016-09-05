﻿using day2.Homework.Infrasructure;
using day2.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day2.Homework.Controllers
{
    public class AdminController : Controller
    {
        [Local]
        public ActionResult DeleteUser(int id = 0)
        {
            UserRepository.Delete(UserRepository.UserCollection.FirstOrDefault(u => u.Id == id));
            return RedirectToAction("User-List");
        }
    }
}