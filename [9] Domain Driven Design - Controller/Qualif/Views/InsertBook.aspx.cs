using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Qualif.Controller;

namespace Qualif.Views
{
    public partial class InsertBook : System.Web.UI.Page
    {
        BookController bookController = new BookController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookies"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string title = BookTitle.Text;
            string copyavailable = CopiesAvaiable.Text;


            string error = bookController.insertBook(title, copyavailable);

            if(string.IsNullOrEmpty(error))
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