using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClothStoreVBL.Repository;

namespace ClothStoreVBL.Views
{
    public partial class Cloth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshGridView();
        }

        private void refreshGridView()
        {
            ClothGridView.DataSource = ClothRepository.GetCloths();
            ClothGridView.DataBind();
        }
    }
}