using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PatternSoftwareDesign_S4.Model;

namespace PatternSoftwareDesign_S4.Factory
{
    public class FactoryClass
    {
        public static cloth createCloth(String id, String brand, String size, int stock, int price, String clothTypeId)
        {
            cloth cloth = new cloth();
            cloth.id = id;
            cloth.brand = brand;
            cloth.size = size;
            cloth.stock = stock;
            cloth.price = price;
            cloth.cloth_type_id = clothTypeId;
            return cloth;
        }
        public static cloth createCloth(String id, String brand, String size, int price, String clothTypeId)
        {
            cloth cloth = new cloth();
            cloth.id = id;
            cloth.brand = brand;
            cloth.size = size;
            cloth.stock = 0;
            cloth.price = price;
            cloth.cloth_type_id = clothTypeId;
            return cloth;
        }
    }
}