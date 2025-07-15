using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Factory;
using Qualif.Handler;
using Qualif.Model;

namespace Qualif.Controller
{
    public class UserController
    {
        UserHandler userHandler = new UserHandler();
        public string Register(string username, string password, string confirmpassword, string email)
        {

            if (username == null || password == null)
            {
                return "Username or Password Must be Filled";
            }
            else if (!email.Contains('@'))
            {
                return "Email Invalid, Must Contains '@'";
            }
            else if (username.Length < 5)
            {
                return "Username length Must Be Greater than 5";
            }
            else if (password.Length < 5)
            {
                return "Password length Must Be Greater than 5";
            }
            else if (confirmpassword.Length < 5)
            {
                return "Confirm Password length Must Be Greater than 5";
            }
            else if (!password.Equals(confirmpassword))
            {
                return "Password and Confirm Password must have the same value";
            }
            else
            {
                userHandler.Register(username, password, email);
                return "";
            }
        }


        public string Login(string username, string password)
        {
            User user = userHandler.Login(username);
            if(user == null)
            {
                return "User Tidak Ditemukan";
            }else if (!user.Password.Equals(password))
            {
                return "Password Salah";
            }
            else
            {
                return "";
            }

        }

        public User GetUser(string username)
        {
            return userHandler.Login(username);
        }

        public User GetUserById(int id)
        {
            return userHandler.GetUserById(id);
        }

        public bool AdminOrNot(string username)
        {
            if(username == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<User> getAllUser()
        {
            return UserHandler.getAllUser();
        }

    }
}