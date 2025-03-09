using PatternSoftwareDesign_S5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatternSoftwareDesign_S5.Repository
{
    public class TransactionRepository
    {
        ClothStoreEntities db = DatabaseSingleton.GetData();
        public List<transaction> GetTransactions()
        {
            return (from transaction in db.transactions select transaction).ToList();
        }
        public transaction FindID(string id)
        {
            return (from x in db.transactions select x).FirstOrDefault();
        }
    }
}