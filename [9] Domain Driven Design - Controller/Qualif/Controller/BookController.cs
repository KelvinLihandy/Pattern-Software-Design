using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Handler;
using Qualif.Model;

namespace Qualif.Controller
{
    public class BookController
    {
        BookHandler bookHandler = new BookHandler();


        public List<Book> getAllBook()
        {
            return bookHandler.GetBook();
        }

        public Book getBook(int id)
        {
            return bookHandler.GetBook(id);
        }

        public void deleteBook(int id)
        {
            bookHandler.deleteBook(id);
        }

        public string updateBook(int id, string title, string copiesavailable)
        {
            int copy;
            try
            {
                copy = int.Parse(copiesavailable);
            }catch (Exception e)
            {
                return "Input Number Only on Copies Available";
            }

            if(copy <= 0)
            {
                return "Copies Available must greater than 0";
            }
            else
            {
                bookHandler.updateBook(id, title, copy);
                return "";
            }
        }

        public string insertBook(string title, string copiesavailable)
        {
            int copy;
            try
            {
                copy = int.Parse(copiesavailable);
            }
            catch (Exception e)
            {
                return "Input Number Only on Copies Available";
            }

            if (copy <= 0)
            {
                return "Copies Available must greater than 0";
            }
            else
            {
                bookHandler.insertBook(title, copy);
                return "";
            }
        }

    }
}