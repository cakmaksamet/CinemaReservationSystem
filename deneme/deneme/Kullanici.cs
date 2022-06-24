using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace deneme
{
    class Kullanici
    {
        int kullaniciId;
        string ad;
        string soyad;
        int yas;
        string email;
        string sifre;

        public int ID { get => kullaniciId; set => kullaniciId = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Yas { get => yas; set => yas = value; }
        public string Email { get => email; set => email = value; }
        public string Sifre { get => sifre; set => sifre = value; }

        public bool KullaniciGiris(string email, string sifre)
        {
            string query = string.Format("SELECT * FROM kullanici WHERE email ='{0}' AND parola='{1}'", email, sifre);
            var dt = Database.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
        
        public int KullaniciEkle(
            string k_ad,
            string k_soyad,
            string k_email,
            string k_sifre)
        {
            string query = string.Format("INSERT INTO kullanici(ad,soyad,email,parola) " +
                "VALUES('{0}','{1}','{2}','{3}')", k_ad, k_soyad, k_email, k_sifre);
            return Database.ExecuteNonQuery(query);
        }

        public DataTable KullanicilariGoster()
        {
            string query = "SELECT * FROM kullanici";
            return Database.ExecuteQuery(query);
        }
        public int KullaniciGuncelle(
            int k_Id,
            string k_ad,
            string k_soyad,
            string k_email,
            string k_sifre)
        {
            string query = string.Format("UPDATE kullanici SET ad = '{1}'," +
                "soyad = '{2}'," +                
                "email = '{3}'," +
                "parola = '{4}'" +
                "WHERE ID = {0} ", k_ad, k_soyad, k_email, k_sifre, k_Id);
            return Database.ExecuteNonQuery(query);
        }




        public DataTable Kullanici_Adi_Ile_Arama(string isim)
        {
            string query = string.Format("SELECT * FROM kullanici WHERE ad = '{0}'", isim);
            return Database.ExecuteQuery(query);
        }
        public DataTable Kullanici_Id_Ile_Arama(int id)
        {
            string query = "SELECT * FROM kullanici where ID = " + id;
            return Database.ExecuteQuery(query);
        }
        
    }
}
