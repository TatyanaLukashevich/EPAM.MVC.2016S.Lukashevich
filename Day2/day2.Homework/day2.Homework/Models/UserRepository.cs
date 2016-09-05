using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace day2.Homework.Models
{
    public static class UserRepository
    {
        public static List<UserViewModel> UserCollection =  new List<UserViewModel>();
        public static void Add()
        {
            Thread.Sleep(2000);
            UserCollection.Add(new UserViewModel {
                Name = "Nick",
                LastName = "Adams"
            });
        }

        public static async Task AddAsync()
        {
            await Task.Delay(2000);
            Add();
        }

        public static List<UserViewModel> GetAll()
        {
            Thread.Sleep(2000);
            return UserCollection;
        }

        public static void Delete(UserViewModel user)
        {
            Thread.Sleep(2000);
            UserCollection.Remove(user);
        }
    }
}