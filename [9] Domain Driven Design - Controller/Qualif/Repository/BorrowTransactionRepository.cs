using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Factory;
using Qualif.Model;

namespace Qualif.Repository
{
    public class BorrowTransactionRepository
    {


        private static BookEntities db = DatabaseSingleton.GetInstance();

        public static List<BorrowTransaction> getAllBorrowTransaction()
        {
            return (from x in db.BorrowTransactions select x).ToList();
        }

        //public static BorrowDetail getUserByUsername(string username)
        //{
        //    return (from x in db.Users where x.Username.Equals(username) select x).FirstOrDefault();
        //}
        public static BorrowTransaction GetBorrowTransaction(int id)
        {
            return (from x in db.BorrowTransactions where x.TransactionID.Equals(id) select x).FirstOrDefault();
        }

        public static int DeleteBorrowTransaction(int id)
        {
            BorrowTransaction bd = GetBorrowTransaction(id);
            db.BorrowTransactions.Remove(bd);
            return db.SaveChanges();
        }

        public static int UpdateBorrowTransaction(BorrowTransaction updatedBorrowTransaction)
        {
            BorrowTransaction bd = GetBorrowTransaction(updatedBorrowTransaction.TransactionID);
            if (bd == null)
            {
                return 0;
            }

            bd.UserID = updatedBorrowTransaction.UserID;
            bd.BorrowDate = updatedBorrowTransaction.BorrowDate;
            bd.Status = updatedBorrowTransaction.Status;

            return db.SaveChanges();
        }

        public static int createBorrowTransaction(int userId, DateTime borrowDate)
        {
            BorrowTransaction bd = TransactionHeaderFactory.createTransactionHeader(userId,borrowDate);
            db.BorrowTransactions.Add(bd);
            db.SaveChanges();

            return bd.TransactionID;
        }




    }
}