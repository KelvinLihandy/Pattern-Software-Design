using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Factory;
using WebService.Repository;

namespace WebService.Handler
{
    public class UserRoleHandler
    {
        public UserRoleRepository repo = new UserRoleRepository();
        public UserRoleFactory factory = new UserRoleFactory();
        public void insertUserRole (int id, string roleName)
        {
            repo.insertUserRole(factory.createUserRole(id, roleName));
        }
        public MsUserRole getUserRole (int id)
        {
            return repo.GetUserRole(id);
        }
    }
}