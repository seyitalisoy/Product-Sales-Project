using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = " Urun eklendi.";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductListed = "Urunler listelendi";
        public static string ProductUpdated = "Product Updated";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir. ";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded="Kategori limiti aşıldı.";
        
    }
}
