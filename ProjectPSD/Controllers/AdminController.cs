using ProjectPSD.Handlers;
using ProjectPSD.Models;
using ProjectPSD.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Xml.Linq;

namespace ProjectPSD.Controllers
{
    public class AdminController
    {
        MakeupHandler makeupHandler = new MakeupHandler();
        UserHandler userHandler = new UserHandler();    
        public List<Makeup> getMakeupList()
        {
            return makeupHandler.getMakeupList();
        }

        public List<User> getCustomerList()
        {
            return userHandler.getCustomerList();
        }

        public Makeup getMakeup(int id)
        {
            return makeupHandler.getMakeup(id);
        }

        public List<String> getTypes()
        {
            return makeupHandler.getTypes();
        }

        public List<String> getBrands()
        {
            return makeupHandler.getBrands();
        }

        public void removeMakeup(int id)
        {
            makeupHandler.removeMakeup(id);
        }

        internal List<MakeupType> getTypeList()
        {
            return makeupHandler.getTypeList();
        }

        internal List<MakeupBrand> getBrandList()
        {
            return makeupHandler.getBrandList();
        }

        internal void insertNewMakeup(string name, int v1, int v2, string selectedValue1, string selectedValue2)
        {
            throw new NotImplementedException();
        }

        public string makeupValidation(int id, string muName, int muPrice, int muWeight, string type, string brand, string state)
        {
            if (muName.Length < 1 || muName.Length > 99) return "name length must be 1 - 99";
            if (muPrice < 1) return "price must be greater than 0";
            if (muWeight > 1500) return "weight cannot be greater than 1500";
            if (state.Equals("edit"))
            {
                makeupHandler.updateMakeup(id, muName, muPrice, muWeight, type, brand);
            }
            else if (state.Equals("new"))
            {
                makeupHandler.newMakeup(muName, muPrice, muWeight, type, brand);
            }
            return "";
        }

        internal string getTypeByID(int id)
        {
            return makeupHandler.getTypeByID(id);
        }

        internal string getBrandByID(int id)
        {
            return makeupHandler.getBrandByID(id);
        }

        internal string makeupTypeValidation(int id, string typeName, string state)
        {
            if (typeName.Length < 1 || typeName.Length > 99)
            {
                return "type length must be between 1 - 99";
            }
            makeupHandler.makeupType(id, typeName, state);
            return "";
        }

        internal string getBRatingByID(int id)
        {
            return makeupHandler.getBratingByID(id);
        }

        internal string makeupBrandValidation(int id, string brandName, string state, int rating)
        {
            if (brandName.Length < 1 || brandName.Length > 99)
            {
                return "type length must be between 1 - 99";
            }
            makeupHandler.makeupBrand(id, brandName, state,rating);
            return "";
        }
    }
}