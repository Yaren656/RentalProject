using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarCountOfCategoryError = "En fazla 10 araba ekleyebilirsiniz";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";
        public static string DailyPriceInvalid = "Lütfen günlük kiralama ücretini geçerli giriniz";
       
        public static string UserNameInvalid = "Kullanıcı adı geçersiz, lütfen daha uzun kullanıcı adı giriniz!";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UsersListed = "Kullanıcılar listelendi";

        public static string RentalAdded = "Kiralama işlemi eklendi, başarılı işlem!";
        public static string RentalNotAccepted = "Kiralama işlemi BAŞARISIZ, arabayı teslim etmelisiniz!";

        public static string BrandsListed = "Markalar listelendi";
        public static string ColorsListed = "Renkler listelendi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CarImagesListed = "Araba resimleri listelendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarImageLimitExceeded = "Araba resmi yükleme sınırı aşıldı";
        public static string CarImageIsNotExists="Araba resmi bulunmuyor";

        public static string UserRegistered="Kayıt oldu";
        public static string UserAlreadyExists = "Bu kullanıcı zaten var";
        public static string UserNotFound="Kullanıcı bulunamadı";

        public static string PasswordError="Şifre hatası";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string AccessTokenCreated="Giriş Başarılı!";
        public static string AuthorizationDenied = "Yetkilendirme reddedildi";
        public static string RentalsListed = "Kiralık arabalar listelendi";
        public static string ColorAdded = "Renk eklendi";
        public static string BrandAdded = "Marka eklendi";
    }
}
