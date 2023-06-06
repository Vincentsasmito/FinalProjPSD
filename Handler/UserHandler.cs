using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_Project.Repository;

namespace Final_Project.Handler
{
    public class UserHandler
    {
        public static string newUser(string roleid, string username, string email, string gender, string password)
        {
            return UserRepository.newUser(roleid, username, email, gender, password);
        }
    }
}