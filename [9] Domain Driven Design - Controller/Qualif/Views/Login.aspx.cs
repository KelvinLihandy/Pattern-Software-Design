using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Qualif.Controller;
using Qualif.Model;

namespace Qualif.Views
{
    public partial class Login : System.Web.UI.Page
    {
        UserController userControl = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text;
            string password = PasswordTB.Text;
            bool rememberMe = RememberMe.Checked;
            
            string error = userControl.Login(username, password);

            if (string.IsNullOrEmpty(error))
            {
                User user = userControl.GetUser(username);
                Session["user"] = user;
                if (rememberMe)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = (user.UserID).ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Text_Error.Text = error;
            }

        }
    }
}