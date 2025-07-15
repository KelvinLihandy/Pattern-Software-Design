using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PatternSoftwareDesign_S2.Views
{
    public partial class View : System.Web.UI.Page
    {
        DatabaseEntities1 db = new DatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<cloth> clothes = (from cloth in db.clothes select cloth).ToList();
            clothGridView.DataSource = clothes;
            clothGridView.DataBind();
        }

        protected void insertPageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Insert.aspx");
        }

        protected void deleteData(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = clothGridView.Rows[e.RowIndex];
            String id = row.Cells[0].Text.ToString();

            cloth cloths = db.clothes.Find(id);
            db.clothes.Remove(cloths);
            db.SaveChanges();
            clothGridView.DataSource = db.clothes.ToList();
            clothGridView.DataBind();
        }

        protected void editingData(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = clothGridView.Rows[e.NewEditIndex];
            String id = row.Cells[0].Text.ToString();
            Response.Redirect("~/Views/Edit.aspx?cloth_id=" + id);
        }
    }
}