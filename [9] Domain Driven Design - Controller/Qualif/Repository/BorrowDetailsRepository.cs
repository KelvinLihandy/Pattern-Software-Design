using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Factory;
using Qualif.Model;

namespace Qualif.Repository
{
    public class BorrowDetailsRepository
    {

        private static BookEntities db = DatabaseSingleton.GetInstance();

        public static List<BorrowDetail> getAllBorrowDetail()
        {
            return (from x in db.BorrowDetails select x).ToList();
        }

        //public static BorrowDetail getUserByUsername(string username)
        //{
        //    return (from x in db.Users where x.Username.Equals(username) select x).FirstOrDefault();
        //}
        public static BorrowDetail getBorrowedDetail(int id)
        {
            return (from x in db.BorrowDetails where x.DetailID == id select x).FirstOrDefault();
        }

        public static int DeleteBorrowDetail(int id)
        {
            BorrowDetail bd = getBorrowedDetail(id);
            db.BorrowDetails.Remove(bd);
            return db.SaveChanges();
        }

        public static int UpdateBorrowDetail(BorrowDetail updatedBorrowDetail)
        {
            BorrowDetail bd = getBorrowedDetail(updatedBorrowDetail.DetailID);
            if (bd == null)
            {
                return 0;
            }

            bd.DueDate = updatedBorrowDetail.DueDate;
            bd.BookID = updatedBorrowDetail.BookID;

            return db.SaveChanges();
        }

        public static int createBorrowDetail(int transactionId, DateTime duedate, int bookId)
        {
            BorrowDetail bd = BookDetailFactory.createBookDetail(transactionId, bookId, duedate);
            db.BorrowDetails.Add(bd);
            db.SaveChanges();

            return bd.DetailID;
        }

    }
}