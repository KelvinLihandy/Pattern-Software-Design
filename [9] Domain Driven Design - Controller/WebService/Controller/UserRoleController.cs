using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Handler;

namespace WebService.Controller
{
    public class UserRoleController
    {
        UserRoleHandler handler = new UserRoleHandler();

        public void insertUserRole (int id, string roleName)
        {
            handler.insertUserRole (id, roleName);
        }
        public string getUserRole (int id)
        {
            return JsonConvert.SerializeObject(handler.getUserRole(id), new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }
    }
}