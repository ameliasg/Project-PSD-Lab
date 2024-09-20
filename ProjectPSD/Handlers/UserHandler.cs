using ProjectPSD.Factories;
using ProjectPSD.Models;
using ProjectPSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ProjectPSD.Handlers
{
    public class UserHandler
    {
        UserRepository userRepo = new UserRepository();
        UserFactory userFactory = new UserFactory();
        public String userLogin(string username, string password)
        {
            User user = userRepo.getUser(username, password);
            return user != null ? user.UserID.ToString() : "username or password is incorrect";
        }
        public String getNameByID(int id)
        {
            return userRepo.getNameByID(id);
        }
        public String getRoleByID(int id)
        {
            return userRepo.getRoleByID(id);
        }
        public bool uniqueName(string name)
        {
            return userRepo.getUserByName(name) == null ? true : false;
        }
        public bool uniqueName(string name,int id)
        {
            return userRepo.getUserByName(name,id) == null ? true : false;
        }
        public void createNewUser(string name, string email, string gender, string password, string cfPassword, DateTime dob)
        {
            User newUser = userFactory.newUser(name,email,gender,password,dob);
            userRepo.addNewUser(newUser);
        }

        public User getUserByID(int id)
        {
            return userRepo.getUserByID(id);
        }

        public DateTime getDOBByID(int id)
        {
            return userRepo.getDOBByID(id);
        }

        public string getEmailByID(int id)
        {
            return userRepo.getEmailByID(id);
        }

        public string getGenderByID(int id)
        {
            return userRepo.getGenderyByID(id);
        }

        public void editUser(int id, string name, string email, string gender, DateTime dob)
        {
            userRepo.editUser(id,name,email,gender,dob);
        }

        public string getPassword(int id)
        {
            return userRepo.getPassword(id);
        }

        public void changePass(int id, string np)
        {
            userRepo.changePass(id,np);
        }

        public List<User> getCustomerList()
        {
            return userRepo.getCustomerList();
        }
    }
};