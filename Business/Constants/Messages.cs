using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BookTypeAdded = "Kitap türü  eklendi";
        public static string BookTypeDeleted = "Kitap türü silindi";
        public static string BookAdded = "Kitap eklendi";
        public static string BookList = "Kitaplar Listelendi";
        public static string StudentAdded = "Öğrenci eklendi";
        public static string StudentDeleted = "Öğrenci silindi";
        public static string CheckIfBookType = "1 türden en fazla 10 kitap olabilir";
        public static string ExistName= "Tür ismi aynı olamaz";
        public static string BookDto = "Join işlemi başarılı";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UsersAdded = "Kullanıcı kayıt işlemi başarılı bir şekilde gerçekleştirildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenAdded = "Tokken başarılı bir şekilde oluşturuldu";
    }
}
