using ApiProject.ModelControllers;
using ApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Data
{
    public class UserData
    {
        public List<User> Users { get; set; }

        public UserData()
        {
            Users = new List<User>
            {
                new User { Id = 1, Email = "will@gamil.com",Name = "Will",Role = "User",Password = "sss1"},
                new User { Id = 2,Email = "edis@gamilc.om",Name = "Edison",Role="Meneger",Password="sss1"}
            };
        }

        public User UserChecker(UserMC user)
        {
            var userDb = Users.Find(x => x.Email.Equals(user.Email) && x.Password.Equals(user.Password));
            return userDb;
        }
    }
}
