using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Repository
{
    public class UserRoleRepository
    {
        Database1Entities database1 = new Database1Entities();
        public void insertUserRole(MsUserRole userRole)
        {
            database1.MsUserRoles.Add(userRole);
        }
        public MsUserRole GetUserRole(int id)
        {
            return database1.MsUserRoles.Find(id);
        }
    }
}