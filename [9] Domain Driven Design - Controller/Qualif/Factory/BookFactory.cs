using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Model;
using Qualif.Repository;

namespace Qualif.Factory
{
    public class BookFactory
    {

        BookEntities db = DatabaseSingleton.GetInstance();

        public static Book createBook(string title, int copiesavaible)
        {
            Book book = new Book();
            book.Title = title;
            book.CopiesAvailable = copiesavaible;
            return book;
        }

    }
}