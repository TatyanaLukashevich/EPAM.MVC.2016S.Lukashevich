using day3.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace day3.Homework.Infrastructure
{
    public static class PersonRepository
    {
        public static List<Person> persons;

        static PersonRepository()
        {
            persons = new List<Person>();
            persons.Add(new Person { Name = "Dart Weider", Type = TypePerson.Dark });
            persons.Add(new Person { Name = "Luck", Type = TypePerson.Light });
            persons.Add(new Person { Name = "Lea", Type = TypePerson.Light });

        }

        public static void Add(Person person)
        {
            persons.Add(person);
        }

        public static List<Person> GetAll()
        {
            return persons;
        }
    }
}