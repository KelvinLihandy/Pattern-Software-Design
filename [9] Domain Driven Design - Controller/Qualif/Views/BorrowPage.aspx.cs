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
    public partial class BorrowPage : System.Web.UI.Page
    {
        BookController bookController = new BookController();
        BorrowController borrowController = new BorrowController();
        UserController userController = new UserController();
        int idBook;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                idBook = 0;
                string bookId = Request.QueryString["BookID"];
                

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

                if (Session["SelectedDate"] != null)
                {
                    BorrowCalender.SelectedDate = (DateTime)Session["SelectedDate"];
                }
            }
        }
        protected void BorrowButton_Click(object sender, EventArgs e)
        {
            DateTime date = BorrowCalender.SelectedDate;

            User user;
            if (Session["user"] == null)
            {
                var id = Request.Cookies["user_cookies"].Value;
                Session["user"] = userController.GetUserById(int.Parse(id));
                user = (User)Session["user"];
            }
            else
            {
                user = (User)Session["user"];
            }

            string bookId = Request.QueryString["BookID"];


            if (!string.IsNullOrEmpty(bookId) && int.TryParse(bookId, out idBook))
            {
                Header.InnerText = "BookID : " + bookId;
            }
            Response.Write(idBook);
            string error = borrowController.borrowValidation(date, user.UserID, idBook);

            if(string.IsNullOrEmpty(error))
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                ErrorMsg.Text = error;
            }

        }
    }
}