using ProjectPSD.Factories;
using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;

namespace ProjectPSD.Repositories
{
    public class MakeupRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.getInstance();
        MakeupFactory factory = new MakeupFactory();
        public List<Makeup> getMakeupList()
        {
            return (from mu in db.Makeups orderby mu.MakeupBrand.MakeupBrandRating descending select mu).ToList();
        }


        public Makeup getMakeup(int id)
        {
            return (from mu in db.Makeups where mu.MakeupID == id select mu).FirstOrDefault();
        }
        public List<String> getTypes()
        {
            return (from mt in db.MakeupTypes select mt.MakeupTypeName).ToList();
        }
        public List<String> getBrands()
        {
            return (from mb in db.MakeupBrands select mb.MakeupBrandName).ToList();
        }

        public int findTypeID(string type)
        {
            MakeupType ret = db.MakeupTypes.FirstOrDefault(mt => mt.MakeupTypeName.Equals(type));
            return ret.MakeupTypeID;
        }
        public int findBrandID(string brand)
        {
            MakeupBrand ret = db.MakeupBrands.FirstOrDefault(mb => mb.MakeupBrandName.Equals(brand));
            return ret.MakeupBrandID;
        }
        public void updateMakeup(int id,string name, int price, int weight, int typeID, int brandID)
        {
            Makeup makeup = db.Makeups.Find(id);
            makeup.MakeupName = name;
            makeup.MakeupPrice = price;
            makeup.MakeupWeight = weight;
            makeup.MakeupTypeID = typeID;
            makeup.MakeupBrandID = brandID;
            db.SaveChanges();
        }

        public void removeMakeup(int id)
        {
            Makeup del = db.Makeups.Find(id);
            db.Makeups.Remove(del);
            db.SaveChanges();
        }
        internal List<MakeupBrand> getBrandList()
        {
            return (from mb in db.MakeupBrands orderby mb.MakeupBrandRating descending select mb).ToList();
        }

        internal List<MakeupType> getTypeList()
        {
            return (from mt in db.MakeupTypes select mt).ToList();
        }

        internal void newMakeup(string muName, int muPrice, int muWeight, int muType, int muBrand)
        {
            int id = (from mu in db.Makeups select mu.MakeupID).Max() + 1;
            Makeup newMakeup = factory.newMakeup(id,muName,muPrice,muWeight,muType,muBrand);
            db.Makeups.Add(newMakeup); 
            db.SaveChanges();
        }

        internal string getTypeByID(int id)
        {
            MakeupType muT = db.MakeupTypes.Find(id);
            return muT.MakeupTypeName;
        }

        internal void updateMakeupType(int id, string typeName)
        {
            MakeupType muT = db.MakeupTypes.Find(id);
            muT.MakeupTypeName = typeName;
            db.SaveChanges();
        }

        internal void newMakeupType(string typeName)
        {
            int id = (from mu in db.MakeupTypes select mu.MakeupTypeID).Max() + 1;
            MakeupType muT = factory.newMakeupType(id, typeName);
            db.MakeupTypes.Add(muT); db.SaveChanges();
        }

        internal string getBRatingByID(int id)
        {
            MakeupBrand muB = db.MakeupBrands.Find(id);
            return muB.MakeupBrandRating.ToString();
        }

        internal string getBrandByID(int id)
        {
            MakeupBrand muB = db.MakeupBrands.Find(id);
            return muB.MakeupBrandName.ToString();
        }

        internal void updateMakeupBrand(int id, string brandName,int rating)
        {
            MakeupBrand muB = db.MakeupBrands.Find(id);
            muB.MakeupBrandName = brandName;
            muB.MakeupBrandRating = rating;
            db.SaveChanges();
        }

        internal void newMakeupBrand(string brandName,int rating)
        {
            int id = (from mu in db.MakeupBrands select mu.MakeupBrandID).Max() + 1;
            MakeupBrand muB = factory.newMakeupBrand(id, brandName,rating);
            db.MakeupBrands.Add(muB); db.SaveChanges();
        }
    }
}