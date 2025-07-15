using ClothStoreVBL.Model;
using ClothStoreVBL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothStoreVBL.Handler
{
    public class ClothTypeHandler
    {
        public static void DeleteHandler (string id)
        {
            cloth_types ct = ClothTypeRepository.GetClothType(id);
            if (ct == null) return;
            if (ct.clothes.Count > 0)
            {
                ClothRepository.RemoveCloth(ct.clothes.ToList());
            }
            ClothTypeRepository.DeleteClothType(id);
        }
    }
}