using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PatternSoftwareDesign_S3.Views
{
    public partial class Login : System.Web.UI.Page
    {
        private Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Value;
            string password = passwordBox.Value;
            bool remember = rememberMe.Checked;
            var user = (from x in db.penggunas where x.username.Equals(username) && x.password.Equals(password) select x).FirstOrDefault();

            if (remember)
            {
                HttpCookie cookie = new HttpCookie("user_cookie");
                cookie.Value = user.Id;
                cookie.Expires = DateTime.Now.AddHours(1);
                Response.Cookies.Add(cookie);
            }

            if (Application["count_user"] == null)
            {
                Application["count_user"] = 1;
            }
            else
            {
                Application["count_user"] = ((int)Application["count_user"]) + 1;
            }

            if (user != null)
            {
                Session["user"] = user;
                Response.Redirect("~/Views/Home.aspx");
            }
        }
    }
}