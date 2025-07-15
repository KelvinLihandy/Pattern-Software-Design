using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Qualif.Controller;

namespace Qualif.Views
{
    public partial class Register : System.Web.UI.Page
    {
        UserController userController = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text;
            string email = EmailTB.Text;
            string password = PasswordTB.Text;
            string confirmpassword = ConfirmPasswordTB.Text;

            string error = userController.Register(username, password, confirmpassword, email);
            
            if(string.IsNullOrEmpty(error))
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Text_Error.Text = error;
            }
        }
    }
}