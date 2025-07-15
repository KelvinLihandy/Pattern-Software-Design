using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Qualif.Controller;
using Qualif.Handler;
using Qualif.Model;
using Qualif.Repository;

namespace Qualif.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        //Qualif.WebService.WebService1 service1 = new Qualif.WebService.WebService1();
        BookController bookControl = new BookController();
        UserController userControl = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {

            bookGridView.Visible = false;
            GridView1.Visible = false;
            InsertBook.Visible = false;

            if (Session["user"] == null && Request.Cookies["user_cookies"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                User user;
                if (Session["user"] == null)
                {
                    var id = Request.Cookies["user_cookies"].Value;
                    Session["user"] = userControl.GetUserById(int.Parse(id));
                    user = (User)Session["user"];
                }
                else
                {
                    user = (User)Session["user"];
                }
                //string JSON = service1.getUserRole(user.UserID);
                //MsUserRole userRole = JsonConvert.DeserializeObject<MsUserRole>(JSON);
                bool trueorFalse = userControl.AdminOrNot(user.Username);
                if(trueorFalse)
                {
                    GridView1.Visible = true;
                    InsertBook.Visible = true;
                }
                else
                {
                    bookGridView.Visible = true;
                }
            }
            
            RefreshGridView();
        }

        protected void RefreshGridView()
        {
            bookGridView.DataSource = bookControl.getAllBook();
            bookGridView.DataBind();
            GridView1.DataSource = bookControl.getAllBook();
            GridView1.DataBind();
        }

        protected void bookGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = bookGridView.DataKeys[e.RowIndex].Value.ToString();
            int bookId = int.Parse(id);
            bookControl.deleteBook(bookId);
        }

        //protected void bookGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    string id = bookGridView.DataKeys[e.RowIndex].Value.ToString();
        //    Response.Redirect("UpdatePage.aspx?BookId=" + id);
        //}

        protected void bookGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

            string id = bookGridView.SelectedDataKey.Value.ToString();
            int bookId = int.Parse(id);
            Book book = bookControl.getBook(bookId);
            //Response.Write("Selected BookID: " + id);
            if(book.CopiesAvailable <= 0)
            {
                ErrorMsg.Text = "Book is out of quantity";
            }
            else
            {
                Response.Redirect("BorrowPage.aspx?BookID=" + id);
            }
        }

        protected void ReturnBookButton_Click(object sender, EventArgs e)
        {
            //var id = Request.Cookies["user_cookies"].Value;
            Response.Redirect("ReturnBook.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string id = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
            Response.Redirect("UpdatePage.aspx?BookId=" + id);
        }

        protected void InsertBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertBook.aspx");
        }
    }
}