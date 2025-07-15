using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PatternSoftwareDesign_S1.views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String username = TBUsername.Text;
            DateTime date = CalendarDOB.SelectedDate;
            if(username.Length < 3)
            {
                ErrorMessage.Text = "Nama kurang panjang";
            }
            else if(date == DateTime.MinValue)
            {
                ErrorMessage.Text = "Masukkan DOB";
            }
        }
    }
}