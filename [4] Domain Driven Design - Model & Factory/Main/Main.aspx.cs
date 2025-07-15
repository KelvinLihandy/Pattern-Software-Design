using PatternSoftwareDesign_S4.Factory;
using PatternSoftwareDesign_S4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PatternSoftwareDesign_S4.Main
{
    public partial class Main : System.Web.UI.Page
    {
        Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var clothesList = new List<cloth>()
            {
                FactoryClass.createCloth("CU001", "SKIBIDI", "M", 2, 15000, "CT001"),
                FactoryClass.createCloth("CU002", "RIZZ", "L", 23000, "CT002")
            };
            foreach (cloth cloth in clothesList)
            {
                clothLabel.Text += $"Cloth ID: {cloth.id}, " +
                    $"Cloth Brand: {cloth.brand}, " +
                    $"Cloth Size: {cloth.size}, " +
                    $"Cloth Stock: {cloth.stock}, " +
                    $"Cloth Type ID: {cloth.cloth_type_id} ";
            }
        }
    }
}