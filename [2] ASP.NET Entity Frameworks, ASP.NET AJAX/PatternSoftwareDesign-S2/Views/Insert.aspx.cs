using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PatternSoftwareDesign_S2.Views
{
    public partial class Insert : System.Web.UI.Page
    {
        DatabaseEntities1 db = new DatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                List<String> cloth = (from type in db.clothes_type select type.name).ToList();
                typeList.DataSource = cloth;
                typeList.DataBind();
            }
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            String newID = idTB.Text.ToString();
            String newBrand = brandTB.Text.ToString();
            int newPrice = Convert.ToInt32(priceTB.Text.ToString());
            String newTypeName = typeList.Text.ToString();
            String newTypeID = (from type in db.clothes_type where type.name == newTypeName select type.id).ToList().FirstOrDefault();

            cloth newCloth = new cloth();
            newCloth.cloth_id = newID;
            newCloth.brand = newBrand;
            newCloth.price = newPrice;
            newCloth.clothes_type_id = newTypeID;
            db.clothes.Add(newCloth);
            db.SaveChanges();
            Response.Redirect("~/Views/View.aspx");
        }
    }
}