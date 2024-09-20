using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Repositories
{
    public class DatabaseSingleton
    {
        private static MakeMeUpzzDatabaseEntities db = null;
        
        public static MakeMeUpzzDatabaseEntities getInstance()
        {
            if(db == null)
            {
                db = new MakeMeUpzzDatabaseEntities();
            }
            return db;
        }
    }
}