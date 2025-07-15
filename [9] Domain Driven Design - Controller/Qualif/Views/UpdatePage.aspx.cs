using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Qualif.Controller;
using Qualif.Model;

namespace Qualif.Views
{
    public partial class UpdatePage : System.Web.UI.Page
    {

        BookController bookController = new BookController();
        int idBook;
        protected void Page_Load(object sender, EventArgs e)
        {
            idBook = 0;
            string bookId = Request.QueryString["BookId"];


            if (!string.IsNullOrEmpty(bookId) && int.TryParse(bookId, out idBook))
            {
                Header.InnerText = "BookID : " + bookId;
            }
            else
            {
                Response.Redirect("HomePage.aspx");
                return;
            }

            Book book = bookController.getBook(idBook);
            if (book == null)
            {
                Response.Redirect("HomePage.aspx");
                return;
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string title = BookTitleTB.Text;
            string copiesavailable = CopiesAvailableTB.Text;

            string error = bookController.updateBook(idBook, title, copiesavailable);

            if (string.IsNullOrEmpty(error))
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Text_Error.Text = error;
            }

        }
    }
}