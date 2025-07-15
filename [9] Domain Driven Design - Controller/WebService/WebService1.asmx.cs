using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService.Controller;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        UserRoleController controller = new UserRoleController();

        [WebMethod]
        public string getUserRole(int id)
        {
            return controller.getUserRole(id);
        }
        [WebMethod]
        public void insertRole(int id, string role)
        {
            controller.insertUserRole(id, role);
        }
    }
}
