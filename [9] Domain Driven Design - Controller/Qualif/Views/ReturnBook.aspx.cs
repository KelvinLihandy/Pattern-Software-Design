using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Qualif.Controller;
using Qualif.Model;

namespace Qualif.Views
{
    public partial class ReturnBook : System.Web.UI.Page
    {

        UserController userController = new UserController();
        BorrowController borrowController = new BorrowController();
        User user;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null && Request.Cookies["user_cookies"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
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

                Header.InnerText = "Welcome : " + user.Username;
                BindGridView(user.UserID);
            }

        }

        protected void BindGridView(int id)
        {
            bookBorrow.DataSource = borrowController.GetJoin(id);
            bookBorrow.DataBind();
        }

        protected void bookGridView_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if(user.UserID != 0)
            {
                GridViewRow row = bookBorrow.SelectedRow;
                string detailId = bookBorrow.SelectedDataKey.Value.ToString();
                string bookId = row.Cells[1].Text;
                borrowController.returnBook(int.Parse(detailId), int.Parse(bookId));
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}