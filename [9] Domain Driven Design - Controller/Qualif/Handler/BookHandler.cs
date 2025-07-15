using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Factory;
using Qualif.Model;
using Qualif.Repository;

namespace Qualif.Handler
{
    public class BookHandler
    {

        public List<Book> GetBook()
        {
            return BookRepository.getAllBook();
        }

        public Book GetBook(int id)
        {
            return BookRepository.getBook(id);
        }

        public void deleteBook(int id)
        {
            BookRepository.DeleteBook(id);
        }

        public void updateBook(int id, string bookName, int copiesAvaible)
        {
            
            BookRepository.UpdateBook(id, bookName, copiesAvaible);
        }

        public void insertBook(string bookName, int copiesAvaible)
        {
            BookRepository.createBook(bookName, copiesAvaible);
        }

    }
}