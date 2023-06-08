using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_Project.Model;
using Final_Project.Factory;

namespace Final_Project.Repository
{
    public class RamenRepository
    {
        public static Database1Entities1 db = new Database1Entities1();

        public class RamenRes
        {
            public int id { get; set; }
            public string meatName { get; set; }
            public string name { get; set; }
            public string broth { get; set; }
            public string price { get; set; }
        }

        public static List<RamenRes> GetRamen()
        {
            List<RamenRes> res = (from x in db.Ramen join y in db.Meats on x.Meatid equals y.id select new RamenRes
            {
                id = x.id,
                meatName = x.Meat.meatName,
                name = x.Name,
                broth = x.Broth,
                price = x.Price,
            }).ToList();

            return res;
        }

        public static string CreateRamen(int meatid, string name, string broth, string price)
        {
            Ramen ramen = RamenFactory.createRamen(meatid, name, broth, price);

            db.Ramen.Add(ramen);
            db.SaveChanges();

            return "Successfuly created ramen!";
        }
        
    }
}