using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PatternSoftwareDesign_S3.Views
{
    public partial class Home : System.Web.UI.Page
    {
        private Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            else
            {
                pengguna user;
                if (Session["user"] == null)
                {
                    var id = Request.Cookies["user_cookie"].Value;
                    user = (from x in db.penggunas where x.Id.Equals(id) select x).FirstOrDefault();
                    Session["user"] = user;
                }
                else
                {
                    user = (pengguna)Session["user"];
                }

                name.Text = user.name;

                if (Application["count_user"] != null)
                {
                    userLoggedinCount.Text = Application["count_user"] + " User(s) Online.";
                }

                if (user.name.Equals("admin"))
                {
                    string[] users = (from x in db.penggunas select x.name).ToArray();
                    foreach (string s in users)
                    {
                        listUser.Items.Add(s);
                    }
                }
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;
            foreach (string s in cookies)
            {
                Request.Cookies[s].Expires = DateTime.Now.AddDays(-1);
            }

            Application["count_user"] = ((int)Application["count_user"]) - 1;
            Session.Remove("user");
            Response.Redirect("~/Views/Login.aspx");
        }
    }
}