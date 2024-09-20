using ProjectPSD.Factories;
using ProjectPSD.Models;
using ProjectPSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.ModelBinding;

namespace ProjectPSD.Handlers
{
    public class MakeupHandler
    {
        MakeupRepository makeupRepository = new MakeupRepository();
        public List<Makeup> getMakeupList()
        {
            return makeupRepository.getMakeupList();
        }


        public Makeup getMakeup(int id)
        {
            return makeupRepository.getMakeup(id);
        }
        public List<String> getBrands()
        {
            return makeupRepository.getBrands();
        }

        public  List<String> getTypes()
        {
            return makeupRepository.getTypes();
        }

        public void updateMakeup(int id,string name, int price, int weight, string type, string brand)
        {
            int typeID = makeupRepository.findTypeID(type);
            int brandID = makeupRepository.findBrandID(brand);
            makeupRepository.updateMakeup(id,name, price, weight, typeID, brandID);
        }

        public void removeMakeup(int id)
        {
            makeupRepository.removeMakeup(id);
        }

        internal List<MakeupType> getTypeList()
        {
            return makeupRepository.getTypeList();
        }

        internal List<MakeupBrand> getBrandList()
        {
            return makeupRepository.getBrandList();
        }

        internal void newMakeup(string muName, int muPrice, int muWeight, string type, string brand)
        {
            int muType = makeupRepository.findTypeID(type);
            int muBrand = makeupRepository.findBrandID(brand);
            makeupRepository.newMakeup(muName,muPrice,muWeight,muType,muBrand);
        }

        internal string getTypeByID(int id)
        {
            return makeupRepository.getTypeByID(id);
        }

        internal void makeupBrand(int id, string brandName, string state,int rating)
        {
            if (state.Equals("edit")) makeupRepository.updateMakeupBrand(id, brandName,rating);
            else makeupRepository.newMakeupBrand(brandName,rating);
        }
        internal void makeupType(int id,string typeName, string state)
        {
            if (state.Equals("edit")) makeupRepository.updateMakeupType(id, typeName);
            else makeupRepository.newMakeupType(typeName);
        }

        internal string getBratingByID(int id)
        {
            return makeupRepository.getBRatingByID(id);
        }

        internal string getBrandByID(int id)
        {
            return makeupRepository.getBrandByID(id);
        }
    }
}