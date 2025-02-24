using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PatternSoftwareDesign_S2.Views
{
    public partial class Edit : System.Web.UI.Page
    {
        DatabaseEntities1 db = new DatabaseEntities1 ();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                String id = Request["cloth_id"];
                cloth updateCloth = db.clothes.Find(id);
                List<String> cloth = (from type in db.clothes_type select type.name).ToList();
                typeList.DataSource = cloth;
                typeList.DataBind();

                idTB.Text = updateCloth.cloth_id;
                brandTB.Text = updateCloth.brand;
                priceTB.Text = updateCloth.price.ToString();
                typeList.SelectedValue = updateCloth.clothes_type.name;
            }
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {
            String newID = idTB.Text.ToString();
            String newBrand = brandTB.Text.ToString();
            int newPrice = Convert.ToInt32(priceTB.Text.ToString());
            String newTypeName = typeList.Text.ToString();
            String newTypeID = (from type in db.clothes_type where type.name == newTypeName select type.id).ToList().FirstOrDefault();

            String id = Request["cloth_id"];
            cloth updateCloth = db.clothes.Find(id);
            updateCloth.cloth_id = newID;
            updateCloth.brand = newBrand;
            updateCloth.price = newPrice;
            updateCloth.clothes_type_id = newTypeID;
            db.SaveChanges();
            Response.Redirect("~/Views/View.aspx");
        }
    }
}