using Sesi10.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sesi10.Handler
{
    public class TransactionRepository
    {
        public static List<transaction> GetData()
        {
            Database1Entities1 db1 = new Database1Entities1();
            return db1.transactions.ToList();
        }
    }
}