using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace day2.Homework.Models
{
    public class UserViewModel
    {
        private static int id = 1;
        public string Name { get; set; }
        public string LastName { get; set; }

        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }
        public UserViewModel()
        {
            Id++;
        }
    }
}