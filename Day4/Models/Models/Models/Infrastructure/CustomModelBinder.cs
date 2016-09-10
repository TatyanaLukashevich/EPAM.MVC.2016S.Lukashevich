using Models.Models;
using System;
using System.Globalization;
using System.Web.Mvc;

namespace Models.Infrastructure
{
    public class CustomModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Person personModel = (Person)bindingContext.Model ?? new Person();
            personModel.PersonId = int.Parse(GetValue(bindingContext, "PersonId"));
            personModel.FirstName = GetValue(bindingContext, "FirstName");
            personModel.LastName = GetValue(bindingContext, "LastName");
            personModel.BirthDate = DateTime.ParseExact(GetValue(bindingContext, "BirthDate"), "dd, M. yyyy", CultureInfo.InvariantCulture);
            personModel.HomeAddress = GetAdrress(bindingContext);
            return personModel;
        }

        private Address GetAdrress(ModelBindingContext bindingContext)
        {
            Address address = new Address();
            address.City = GetValue(bindingContext, "City");
            address.Country = GetValue(bindingContext, "Country");
            return address;
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
    }
}