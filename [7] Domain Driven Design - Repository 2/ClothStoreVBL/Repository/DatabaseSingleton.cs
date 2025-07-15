using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClothStoreVBL.Model;

namespace ClothStoreVBL.Repository
{
    public class DatabaseSingleton
    {

        private static VBLEntities instance;

        public static VBLEntities getInstance()
        {
            if (instance == null)
            {
                instance = new VBLEntities();
            }
            return instance;
        }

    }
}