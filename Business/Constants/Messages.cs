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
        public static string AuthorizationDenied = "Yetkiniz yok ";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

    }
}
