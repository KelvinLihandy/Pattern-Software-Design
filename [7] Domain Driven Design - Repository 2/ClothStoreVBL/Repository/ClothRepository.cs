using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClothStoreVBL.Model;

namespace ClothStoreVBL.Repository
{
    public class ClothRepository
    {

        private static VBLEntities db = DatabaseSingleton.getInstance();

        public static List<cloth> GetCloths()
        {
            return (from x in db.clothes select x).ToList();
        }

        public static List<cloth> GetClothesByType(string type_id)
        {
            return (from x in db.clothes where x.cloth_typeid.Equals(type_id) select x).ToList();
        }

        public static int RemoveCloth(List<cloth> clothes)
        {
            db.clothes.RemoveRange(clothes);
            return db.SaveChanges();
        }

    }
}