using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sesi4.Repository;
using sesi4.Model;
using System.Web.Management;

namespace sesi4.Handler
{
    public class UserHandler
    {
        public static String getUser(String username, String password)
        {
            user user = UserRepository.getUser(username, password);
            return user != null ? "Success" : "Not Success"; 
        }
    }
}