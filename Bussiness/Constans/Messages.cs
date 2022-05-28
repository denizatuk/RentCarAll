using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araba ismi en az 2 karakter Olmalıdır";
        public static string CarUpdated = "Araç Güncellendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarListed = "Arabalar Listelendi";
        public static string MaintenceTime = "Sistem Bakımda";

        public static string BrandAdded = "Marka Eklendi";
        public static string BrandNameInvalid = "Marka ismi en az 2 karakter Olmalıdır";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandListed = "Marka Listelendi";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorNameInvalid = "Renk ismi en az 2 karakter Olmalıdır";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorListed = "Renkler Listelendi";
        public static string CarImageListed = "Araç Resimleri Listelendi";
        public static string CarImageAdded = "Araç Resimleri Eklendi";
        public static string CarImageUpdated = "Araç Resimleri Güncellendi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
