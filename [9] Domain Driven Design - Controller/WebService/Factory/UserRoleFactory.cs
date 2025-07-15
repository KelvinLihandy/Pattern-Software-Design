using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Factory
{
    public class UserRoleFactory
    {
        public MsUserRole createUserRole(int id, string roleName)
        {
            return new MsUserRole
            {
                Id = id,
                UserRole = roleName
            };
        }
    }
}