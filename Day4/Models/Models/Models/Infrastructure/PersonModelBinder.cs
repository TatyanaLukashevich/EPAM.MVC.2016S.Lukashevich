using Models.Models;
using System;
using System.Globalization;
using System.Web.Mvc;

namespace Models.Infrastructure
{
    public class PersonModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Person personModel = (Person)bindingContext.Model ?? new Person();
            personModel.FirstName = GetValue(bindingContext, "FirstName");
            personModel.LastName = GetValue(bindingContext, "LastName");
            personModel.BirthDate = GetDoB(controllerContext, bindingContext);
            personModel.HomeAddress = GetAdrress(controllerContext, bindingContext);
            personModel.Role = GetRole(controllerContext, bindingContext);
            return personModel;
        }

        private string GetValue(ModelBindingContext context, string name)
        {
            name = (context.ModelName == "" ? ""
                : context.ModelName + ".") + name;

            ValueProviderResult result = context.ValueProvider.GetValue(name);

            if (result == null || result.AttemptedValue == "")
            {
                return "<Not Specified>";
            }

            return result.AttemptedValue;
        }

        private Address GetAdrress(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Address address = new Address();

            address.City = GetValue(bindingContext, "HomeAddress.City") == "PO BOX" ? "<not-defined>"
                : GetValue(bindingContext, "HomeAddress.City");
            address.Country = GetValue(bindingContext, "HomeAddress.Country") == "PO BOX" ? "<not-defined>" 
                : GetValue(bindingContext, "HomeAddress.Country");
            address.Line1 = GetValue(bindingContext, "HomeAddress.Line1");
            address.Line2 = string.IsNullOrEmpty(GetValue(bindingContext, "HomeAddress.Line2")) ? "<not-defined>"
                : GetValue(bindingContext, "HomeAddress.Line2");
            address.PostalCode = GetValue(bindingContext, "HomeAddress.PostalCode").Length < 6 ? "<not-defined>" 
                : GetValue(bindingContext, "HomeAddress.PostalCode");

            if (address.PostalCode == "<not-defined>" || address.City == "<not-defined>" || address.Line1 == "<not-defined>")
            {
                address.Summary = "No Personal Address";
            }
            else
            {
                address.Summary = $"{address.PostalCode} {address.City},{address.Line1}";
            }

            return address;
        }

        private Role GetRole(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var roleType = GetValue(bindingContext, "Role");

            if (roleType == "admin")
            {
                return Role.Admin;
            }             
            else if (roleType == "user" || (roleType == "admin" && !controllerContext.HttpContext.Request.IsLocal))
            {
                return Role.User;
            }
            else
            {
                return Role.Guest;
            }
        }

        private DateTime GetDoB(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            DateTime birthdate;
            DateTime.TryParseExact(GetValue(bindingContext, "BirthDate"), "yyyy,dd-MM",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdate);
            return birthdate;
        }
    }
}