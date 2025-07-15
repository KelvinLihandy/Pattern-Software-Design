using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Model;
using Qualif.Repository;

namespace Qualif.Handler
{
    public class BorrowHandler
    {
        BookEntities db = DatabaseSingleton.GetInstance();
        public void userBorrow(DateTime datenow, int userId, DateTime duedate, int bookId)
        {
            int bt = BorrowTransactionRepository.createBorrowTransaction(userId, duedate);

            if(bt == 0 || bt == null)
            {
                return;
            }
            Console.WriteLine("Book ID: " + bookId);
            if (bookId != 0 || bookId == null)
            {
                int bd = BorrowDetailsRepository.createBorrowDetail(bt, duedate, bookId);
            }
            else
            {
                return;
            }
            Book book = BookRepository.getBook(bookId);
            book.CopiesAvailable -= 1;
            int copynow = (int)book.CopiesAvailable;
            BookRepository.UpdateBook(book.BookID, book.Title, copynow);
        }

        public List<JoinBookAndDetail> getBorrowBookAndDetailList(int userId)
        {
            //var query = (from x in db.BorrowDetails join y in db.Books on x.BookID equals y.BookID select new JoinBookAndDetail
            //{
            //    title = y.Title,
            //    duedate = x.DueDate,
            //}).ToList();

            var query = (from bd in db.BorrowDetails
                         join bt in db.BorrowTransactions on bd.TransactionID equals bt.TransactionID
                         join b in db.Books on bd.BookID equals b.BookID
                         where bt.UserID == userId
                         select new JoinBookAndDetail
                         {
                             detailId = bd.DetailID,
                             bookId = bd.BookID,
                             title = b.Title,
                             duedate = bd.DueDate
                         }).ToList();

            return query;

        }

        public void deleteBorrowDetail(int detailId, int bookId)
        {
            if(detailId == 0 || bookId == 0)
            {
                return ;
            }

            Book book = BookRepository.getBook(bookId);

            if(book == null)
            {
                return;
            }

            book.CopiesAvailable += 1;
            int wor = BorrowDetailsRepository.DeleteBorrowDetail(detailId);
        }

    }
}