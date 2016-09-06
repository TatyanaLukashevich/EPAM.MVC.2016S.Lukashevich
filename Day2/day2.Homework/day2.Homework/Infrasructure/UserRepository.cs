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
        private static List<UserViewModel> UserCollection;

        static UserRepository()
        {
            UserCollection = new List<UserViewModel>();
            UserCollection.Add(new UserViewModel { Name = "Nick", LastName = "Adams" });
        }
        public async static Task<List<UserViewModel>> Add(UserViewModel user)
        {
            return await Task<List<UserViewModel>>.Factory.StartNew(() =>
            {
               UserCollection.Add(user);
                return UserCollection;
            });
        }

        public static List<UserViewModel> GetAll()
        {
            Thread.Sleep(2000);
            return UserCollection;
        }

        public static void Delete()
        {
            UserCollection = new List<UserViewModel>();
        }
    }
}