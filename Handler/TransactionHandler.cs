using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_Project.Repository;

namespace Final_Project.Handler
{
    public class TransactionHandler
    {
        public static string createTransaction(int customerId, Dictionary<int, int> ramenData)
        {
            int headerId = TransactionRepository.createHeader(customerId);

            if(headerId.ToString() != "")
            {
                foreach (var x in ramenData)
                {
                    TransactionRepository.createDetails(headerId, x.Key, x.Value);
                }
                return "Transaction Completed";
            }
            else
            {
                return "Transaction Failed!";
            }
        }
    }
}