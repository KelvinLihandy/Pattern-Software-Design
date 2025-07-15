using Sesi10.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sesi10.Handler
{
    public class TransactionHandler
    {
        public static List<transaction> GetData()
        {
            return TransactionRepository.GetData();
        }

    }
}