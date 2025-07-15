using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClothStoreVBL.Repository;
using ClothStoreVBL.Handler;

namespace ClothStoreVBL.Views
{
    public partial class ClothType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshGridView();
        }

        private void refreshGridView()
        {
            clothTypeGridView.DataSource = ClothTypeRepository.GetClothTypes();
            clothTypeGridView.DataBind();
        }

        protected void clothTypeGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = clothTypeGridView.Rows[e.RowIndex].Cells[1].Text;
            ClothTypeHandler.DeleteHandler(id);
            refreshGridView();
        }
    }
}