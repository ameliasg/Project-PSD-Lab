using Microsoft.SqlServer.Server;
using ProjectPSD.Handlers;
using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controllers
{
    public class UserController
    {
        UserHandler userHandler = new UserHandler();
        MakeupHandler makeupHandler = new MakeupHandler();

        public string registerValidation(string name,string email,string gender,string password,string cfPassword,DateTime dob)
        {
            // dob dan gender tidak dibuat validasi karena sudah ada default value
            if(name.Length < 5 || name.Length > 15)return "Name Length must be 5 - 15";
            if (!userHandler.uniqueName(name)) return "Username Taken";
            if(email.Length < 4) return "email must not be empty";
            if (!email.Substring(email.Length - 4).Equals(".com")) return "email ends with .com";
            if (password.Length == 0) return "Password must not be empty";
            if (!password.All(char.IsLetterOrDigit)) return "Password must be alphanumeric";
            if (!password.Equals(cfPassword)) return "password and confirm password is different";
            userHandler.createNewUser(name, email, gender, password, cfPassword, dob);
            return "";
        }
        public string editValidation(int id, string name,string email,string gender, DateTime dob)
        {
            if (name.Length < 5 || name.Length > 15) return "Name Length must be 5 - 15";
            if (!userHandler.uniqueName(name,id)) return "Username Taken";
            if (email.Length < 4) return "email must not be empty";
            if (!email.Substring(email.Length - 4).Equals(".com")) return "email ends with .com";
            userHandler.editUser(id, name, email, gender, dob);
            return "";
        }


        public string getName(int id)
        {
            return userHandler.getNameByID(id);
        }

        public DateTime getDOB(int id)
        {
            return userHandler.getDOBByID(id);
        }

        public string getGender(int id)
        {
            return userHandler.getGenderByID(id);
        }

        public string getEmail(int id)
        {
            return userHandler.getEmailByID(id);
        }

        public string changePassword(int id, string np, string op)
        {
            string oldPass = userHandler.getPassword(id);
            if (oldPass.Equals(op))
            {
                userHandler.changePass(id, np);
                return "password changed";
            }
            return "invalid current password";
        }
    }
}