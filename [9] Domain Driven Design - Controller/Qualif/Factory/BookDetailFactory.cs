using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Model;
using Qualif.Repository;

namespace Qualif.Factory
{
    public class BookDetailFactory
    {

        BookEntities db = DatabaseSingleton.GetInstance();

        public static BorrowDetail createBookDetail(int transactionId, int bookId, DateTime duedate)
        {
            BorrowDetail borrowDetail = new BorrowDetail();
            borrowDetail.TransactionID = transactionId;
            borrowDetail.BookID = bookId;
            borrowDetail.DueDate = duedate;
            return borrowDetail;
        }

    }
}