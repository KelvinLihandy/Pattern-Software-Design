using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Factory;
using Qualif.Model;
using Qualif.Repository;

namespace Qualif.Handler
{
    public class UserHandler
    {
        public void Register(string username, string password, string email)
        {
            UserRepository.createUser(username, password, email);
        }

        public User Login(string username)
        {
            //List<User> users = UserRepository.getAllUser();

            User user = UserRepository.getUserByUsername(username);
            return user;

        }

        public User GetUserById(int id)
        {
            return UserRepository.getUser(id);
        }


        public static List<User> getAllUser()
        {
            return UserRepository.getAllUser();
        }

    }
}