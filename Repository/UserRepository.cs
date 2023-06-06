using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_Project.Factory;
using Final_Project.Model;

namespace Final_Project.Repository
{
    public class UserRepository
    {
        public static Database1Entities db = new Database1Entities();
        
        public static string newUser(string roleid, string username, string email, string gender, string password)
        {
            User newU = UserFactory.CreateUser(roleid, username, email, gender, password);
            db.Users.Add(newU);
            db.SaveChanges();

            return "Create User Success!";
        }

    }
}