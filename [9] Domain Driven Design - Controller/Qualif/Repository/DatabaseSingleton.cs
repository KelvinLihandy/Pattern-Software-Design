using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Model;

namespace Qualif.Repository
{
    public class DatabaseSingleton
    {
        private static BookEntities instance;

        public static BookEntities GetInstance()
        {
            if(instance == null)
            {
                instance = new BookEntities();
            }
            return instance;
        }

    }
}