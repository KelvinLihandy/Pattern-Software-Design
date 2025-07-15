using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Factory;
using Qualif.Model;

namespace Qualif.Repository
{
    public class BookRepository
    {

        private static BookEntities db = DatabaseSingleton.GetInstance();

        public static List<Book> getAllBook()
        {
            return (from x in db.Books select x).ToList();
        }

        public static Book getBookByUsername(string title)
        {
            return (from x in db.Books where x.Title.Equals(title) select x).FirstOrDefault();
        }
        public static Book getBook(int id)
        {
            return (from x in db.Books where x.BookID.Equals(id) select x).FirstOrDefault();
        }

        public static int DeleteBook(int id)
        {
            Book book = getBook(id);
            db.Books.Remove(book);
            return db.SaveChanges();
        }

        public static int UpdateBook(int id, string title, int copiesAvailable)
        {
            Book book = getBook(id);
            if (book == null)
            {
                return 0;
            }

            book.Title = title;
            book.CopiesAvailable = copiesAvailable;

            return db.SaveChanges();
        }

        public static int createBook(string title, int copiesAvaible)
        {
            Book book = BookFactory.createBook(title, copiesAvaible);
            db.Books.Add(book);
            return db.SaveChanges();
        }


    }
}