using sesi4.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;

namespace sesi4.Controller
{
    public class AuthController
    {
        public static String checkUsername(string username)
        {
            String response = "";
            if (username.Equals("")) response = "Username cannot be empty";
            else if (username.Length < 5) response = "Username length must be more than 5 characters";
            return response;
        }
        public static String checkPassword(string password)
        {
            String response = "";
            if (password.Equals("")) response = "Password cannot be empty";
            else if (password.Length < 5) response = "Password length must be more than 5 characters";
            return response;
        }
        public static String doLogin(string username, string password) 
        {
            String response = checkUsername(username);
            if (response.Equals("")) response = checkPassword(password);
            response = UserHandler.getUser(username, password);
            return response;
        }
    }
}