using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace day3.Homework.Models
{
    public enum TypePerson
    {
        Light,
        Dark
    }
    public class Person
    {
        public string Name { get; set; }
        public TypePerson Type { get; set; }
    }
}