﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_Project.Handler;

namespace Final_Project.Controller
{
    public class RamenRes
    {
        public int id { get; set; }
        public string meatName { get; set; }
        public string name { get; set; }
        public string broth { get; set; }
        public string price { get; set; }
    }
    public class RamenController
    {
        public static string CreateRamen(int meatid, string name, string broth, string price)
        {
            if (meatid == 0 || name == "" || broth == "" || price == "")
            {
                return "Enter all fields";
            }
            else if(name.Contains("Ramen") == false)
            {
                return "Name does not contain \"Ramen\"";
            }
            else if(Convert.ToInt32(price) < 3000)
            {
                return "Price must be >= 3000";
            }
            return RamenHandler.CreateRamen(meatid, name, broth, price);
        }
    }
}