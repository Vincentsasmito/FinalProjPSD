using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_Project.Repository;

namespace Final_Project.Handler
{
    public class RamenHandler
    {
        public static string CreateRamen(int meatid, string name, string broth, string price)
        {
            return RamenRepository.CreateRamen(meatid, name, broth, price);
        }
    }
}