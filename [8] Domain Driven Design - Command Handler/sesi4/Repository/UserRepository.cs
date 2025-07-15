using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sesi4.Model;

namespace sesi4.Repository
{
    public class UserRepository
    {
        private static Database1Entities db = new Database1Entities();
        
        public static user getUser(String username, String password)
        {
            return (from x in db.users where x.username.Equals(username) && x.password.Equals(password)
                    select x).FirstOrDefault();
        }
    }
}