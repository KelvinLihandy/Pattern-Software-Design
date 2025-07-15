using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClothStoreVBL.Model;

namespace ClothStoreVBL.Repository
{
    public class ClothTypeRepository
    {

        private static VBLEntities db = DatabaseSingleton.getInstance();

        public static List<cloth_types> GetClothTypes()
        {
            return (from x in db.cloth_types select x).ToList();
        }

        public static cloth_types GetClothType(string id)
        {
            return (from x in db.cloth_types where x.Id.Equals(id) select x).FirstOrDefault();
        }

        public static int DeleteClothType(string id)
        {
            cloth_types ct = GetClothType(id);
            db.cloth_types.Remove(ct);
            return db.SaveChanges();
        }

    }
}