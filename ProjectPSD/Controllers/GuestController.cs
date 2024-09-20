using ProjectPSD.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controllers
{
    public class GuestController
    {
        UserHandler userHandler = new UserHandler();
        public string doLogin(string username, string password)
        {
            if (username == "" || password == "")
            {
                return "Username or Password cannot be empty!";
            }
            return userHandler.userLogin(username, password);
        }

    }
}