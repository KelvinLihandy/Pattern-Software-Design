using PatternSoftwareDesign_S5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatternSoftwareDesign_S5.Repository
{
    public class DatabaseSingleton
    {
        private static ClothStoreEntities db;
        public static ClothStoreEntities GetData()
        {
            if (db == null) db = new ClothStoreEntities();
            return db;
        }
    }
}