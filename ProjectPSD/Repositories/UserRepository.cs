using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Web;
using System.Web.Configuration;

namespace ProjectPSD.Repositories
{
    public class UserRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.getInstance();
        public User getUser(string name, string password)
        {
            return (from u in db.Users where u.UserName.Equals(name)
                    && u.UserPassword.Equals(password) select u).
                    FirstOrDefault();
        }
        public User getUserByID(int id)
        {
            return (from u in db.Users where u.UserID.Equals(id) select u).FirstOrDefault();
        }

        public string getNameByID(int id)
        {
            return (from u in db.Users where u.UserID.Equals(id) select u.UserName).FirstOrDefault();
        }
        public string getRoleByID(int id)
        {
            return (from u in db.Users where u.UserID.Equals(id) select u.UserRole).FirstOrDefault();
        }
        public User getUserByName(string name)
        {
            return (from u in db.Users where u.UserName.Equals(name) select u).FirstOrDefault();
        }
        public User getUserByName(string name,int id)
        {
            return (from u in db.Users where u.UserName.Equals(name) && !u.UserID.Equals(id) select u).FirstOrDefault();
        }
        public int getNextID()
        {
            return db.Users.Count() + 1;
        }

        public void addNewUser(User newUser)
        {
            db.Users.Add(newUser);
            db.SaveChanges();
        }

        public DateTime getDOBByID(int id)
        {
            return (from u in db.Users where u.UserID == id select u.UserDOB).FirstOrDefault();

        }

        public string getGenderyByID(int id)
        {
            return (from u in db.Users where u.UserID == id select u.UserGender).FirstOrDefault();
        }

        public string getEmailByID(int id)
        {
            return (from u in db.Users where u.UserID == id select u.UserEmail).FirstOrDefault();
        }
        public void editUser(int id, string name, string email, string gender, DateTime dob)
        {
            User user = (from u in db.Users where u.UserID == id select u).FirstOrDefault();
            user.UserName = name;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserDOB = dob;
            db.SaveChanges();
        }

        internal string getPassword(int id)
        {
            return (from u in db.Users where u.UserID == id select u.UserPassword).FirstOrDefault();
        }
        public void changePass(int id, string np)
        {
            User user = (from u in db.Users where u.UserID == id select u).FirstOrDefault();
            user.UserPassword = np;
            db.SaveChanges();
        }

        public List<User> getCustomerList()
        {
            return (from u in db.Users select u).ToList();
        }
    }
}