using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Model;
using Qualif.Repository;

namespace Qualif.Factory
{
    public class UserFactory
    {
        BookEntities db = DatabaseSingleton.GetInstance();

        public static User createUser(string username, string password, string email)
        {
            User user = new User();
            user.Username = username;
            user.Password = password;
            user.Email = email;
            return user;
        }

    }
}