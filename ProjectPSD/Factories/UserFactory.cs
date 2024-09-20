using ProjectPSD.Models;
using ProjectPSD.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ProjectPSD.Factories
{
    public class UserFactory
    {
        UserRepository repo = new UserRepository();
        public User newUser(string name, string email, string gender, string password, DateTime date)
        {
            int id = repo.getNextID();
            User user = new User();
            user.UserID = id;
            user.UserName = name;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserRole = "User";
            user.UserPassword = password;
            user.UserDOB = date;
            return user;
        }
    }
}