﻿using Models.Infrastructure;
using Models.Models;
using System.Web.Mvc;
using System.Web.Routing;

namespace Models
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ModelBinders.Binders.Add(typeof(Person), new PersonModelBinder());
        }
    }
}
