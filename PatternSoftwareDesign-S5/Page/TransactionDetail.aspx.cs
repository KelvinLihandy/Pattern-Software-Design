using PatternSoftwareDesign_S5.Model;
using PatternSoftwareDesign_S5.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PatternSoftwareDesign_S5.Page
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        public transaction tran = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionRepository repo = new TransactionRepository();
            string id = Request.QueryString["id"];
            tran = repo.FindID(id);
            if (tran == null)
            {
                Response.Redirect("~/Page/Transaction.aspx");
            }

        }
    }
}