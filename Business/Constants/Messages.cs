using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Car
        public static string CarAdded = "Araba eklendi";
        public static string CarNotAdded= "Araç eklenemedi,lütfen verdiğiniz fiyat 0'dan büyük olsun";
        public static string CarNotUpdated = "Araç güncellenemedi,lütfen verdiğiniz fiyat 0'dan büyük olsun";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarsListed = "Araçlar listelendi";

        //Brand
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandNotUpdated = "Marka güncellenemedi.Lütfen marka ismini 2 karakterden fazla yazınız";
        public static string BrandNameInvalid = "Marka ismi 2 karakterden büyük olmalıdır.";
        public static string BrandsListed = "Markalar listelendi";

        //Color
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorsListed = "Renkler listelendi";

        //System
        public static string MainintenanceTime = "Sistem bakımda";

        //Rental
        public static string RentalAdded = "Kiralama başarılı";
        public static string RentalDeleted = "Kiralama bilgileri silindi";
        public static string RentalUpdated = "Kiralama bilgileri güncellendi";
        public static string RentalReturnDateInvalid = "Kiralama Başarısız.Araç henüz teslim edilmedi.";
        public static string RentalReturnDateUpdated = "Geri dönüş tarihi güncellendi";

        //Customer
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdate = "Müşteri bilgileri güncellendi";
        public static string CustomersListed = "müşteriler listelendi";

        //User
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdate = "Kullanıcı bilgileri güncellendi";
        public static string UsersListed = "Kullanıcılar listelendi";

        //Image
        public static string FailImageLimitExceeded = "Resim ekleme sınırı aşıldı";
    }
}
