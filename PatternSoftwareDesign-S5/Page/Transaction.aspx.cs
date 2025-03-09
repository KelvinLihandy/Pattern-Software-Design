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
    public partial class Transaction : System.Web.UI.Page
    {
        public List<transaction> transaction = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionRepository repo = new TransactionRepository();
            transaction = repo.GetTransactions();
        }
    }
}