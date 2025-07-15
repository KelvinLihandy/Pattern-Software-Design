using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Factory;
using Qualif.Model;

namespace Qualif.Repository
{
    public class UserRepository
    {

        private static BookEntities db = DatabaseSingleton.GetInstance();

        public static List<User> getAllUser()
        {
            return (from user in db.Users select user).ToList();
        }

        public static User getUserByUsername(string username)
        {
            return (from x in db.Users where x.Username.Equals(username) select x).FirstOrDefault();
        }
        public static User getUser(int id)
        {
            return (from x in db.Users where x.UserID.Equals(id) select x).FirstOrDefault();
        }

        public static int DeleteUser(int id)
        {
            User user = getUser(id);
            db.Users.Remove(user);
            return db.SaveChanges();
        }

        //public static int UpdateUser(User updatedUser)
        //{
        //    User existingUser = getUser(updatedUser.UserID);
        //    if (existingUser == null)
        //    {
        //        return 0;
        //    }

        //    existingUser.Username = updatedUser.Username;
        //    existingUser.Password = updatedUser.Password;
        //    existingUser.Email = updatedUser.Email;

        //    return db.SaveChanges();
        //}

        public static int createUser(string username, string password, string email)
        {
            User user = UserFactory.createUser(username, password, email);
            db.Users.Add(user);
            return db.SaveChanges();
        }

    }
}