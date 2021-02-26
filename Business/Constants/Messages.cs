using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductListed = "Ürünler listelendi";

        public static string ProductNameAlreadyExists = "Böyle bir ürün ismi zaten var ";
        public static string ProductCountOfCategoryError = "Bir Kategoride enfazla 10 ürün olabilir";
        public static string CategoryLimitExceded = "Category limiti aşıldığı için yeni ürün eklenemiyor ";
    }
}
