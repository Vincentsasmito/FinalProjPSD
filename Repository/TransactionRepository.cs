using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_Project.Factory;
using Final_Project.Model;


namespace Final_Project.Repository
{
    public class TransactionRepository
    {
        public static Database1Entities1 db = new Database1Entities1();
        public static int createHeader(int customerId)
        {
            Header h = TransactionFactory.createHeader(customerId);
            db.Headers.Add(h);
            db.SaveChanges();
            return h.id;
        }

        public static string createDetails(int headerId, int ramenId, int quantity)
        {
            Detail det = TransactionFactory.createDetail(headerId, ramenId, quantity);
            db.Details.Add(det);
            db.SaveChanges();
            return "New Details Added Succesfully";
        }
    }
}