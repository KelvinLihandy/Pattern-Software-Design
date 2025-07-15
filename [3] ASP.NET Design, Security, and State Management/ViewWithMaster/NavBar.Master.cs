using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PatternSoftwareDesign_S3.Views
{
    public partial class NavBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Loginpage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewWithMaster/Login.aspx");
        }

        protected void RegisterPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewWithMaster/Register.aspx");
        }

        protected void HomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewWithMaster/Home.aspx");
        }
    }
}