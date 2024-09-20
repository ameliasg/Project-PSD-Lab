using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factories
{
    public class MakeupFactory
    {
        internal Makeup newMakeup(int id, string muName, int muPrice, int muWeight, int muType, int muBrand)
        {
            Makeup makeup = new Makeup();
            makeup.MakeupID = id;
            makeup.MakeupName = muName;
            makeup.MakeupPrice = muPrice;
            makeup.MakeupWeight = muWeight;
            makeup.MakeupTypeID = muType;
            makeup.MakeupBrandID = muBrand;
            return makeup;
        }

        internal MakeupBrand newMakeupBrand(int id, string brandName, int rating)
        {
            MakeupBrand makeupBrand = new MakeupBrand();
            makeupBrand.MakeupBrandID= id;
            makeupBrand.MakeupBrandName= brandName;
            makeupBrand.MakeupBrandRating = rating;
            return makeupBrand;
        }

        internal MakeupType newMakeupType(int id, string typeName)
        {
            MakeupType makeupType = new MakeupType();
            makeupType.MakeupTypeID = id;
            makeupType.MakeupTypeName = typeName;
            return makeupType;
        }


    }
}