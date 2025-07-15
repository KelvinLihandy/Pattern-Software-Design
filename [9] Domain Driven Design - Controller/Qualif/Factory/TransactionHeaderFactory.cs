using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Model;
using Qualif.Repository;

namespace Qualif.Factory
{
    public class TransactionHeaderFactory
    {

        BookEntities db = DatabaseSingleton.GetInstance();

        public static BorrowTransaction createTransactionHeader(int userId, DateTime date)
        {
            BorrowTransaction transaction = new BorrowTransaction();
            transaction.UserID = userId;
            transaction.BorrowDate = date;
            return transaction;
        }

    }
}