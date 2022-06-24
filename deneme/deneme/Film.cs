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
    class Film
    {
        int filmId;
        string filmadi;
        string yonetmen;
        string oyuncular;
        string vizyontarihi;
        int sure;
        int yassiniri;
        string tur;
        string ozet;
        string yol;

        public int FilmId { get => filmId; set => filmId = value; }
        public string Filmadi { get => filmadi; set => filmadi = value; }
        public string Yonetmen { get => yonetmen; set => yonetmen = value; }
        public string Oyuncular { get => oyuncular; set => oyuncular = value; }
        public string Vizyontarihi { get => vizyontarihi; set => vizyontarihi = value; }
        public int Sure { get => sure; set => sure = value; }
        public int Yassiniri { get => yassiniri; set => yassiniri = value; }
        public string Tur { get => tur; set => tur = value; }
        public string Ozet { get => ozet; set => ozet = value; }
        public string Yol { get => yol; set => yol = value; }

        
        
        public int FilmEkle(
        string fAd,
        string fYonetmen,
        string fOyuncular,
        string fVizyonTarihi,
        int fSure,
        int fYasSiniri,
        string fTur,
        string fOzet,
        string fyol)
        {
            string query = string.Format("INSERT INTO Film(film_adi,yonetmen,oyuncular,tarih,sure,yas_siniri,tur,ozet,yol) " +
                "VALUES('{0}','{1}','{2}','{3}',{4},{5},'{6}','{7}','{8}')", fAd, fYonetmen, fOyuncular, fVizyonTarihi, fSure, fYasSiniri, fTur, fOzet, fyol);
            return Database.ExecuteNonQuery(query);
        }

        public DataTable Film_Adi_Ile_Arama(string isim)
        {
            string query = string.Format("SELECT * FROM Film WHERE film_adi = '{0}'", isim);
            return Database.ExecuteQuery(query);
        }
        public DataTable Film_Id_Ile_Arama(int id)
        {
            string query = "SELECT * FROM Film where film_id = " + id;
            return Database.ExecuteQuery(query);
        }
        public DataTable FilmleriGoster()
        {
            string query = "SELECT * FROM Film";
            return Database.ExecuteQuery(query);
        }
        public int FilmSil(string id)
        {
            string query = string.Format("DELETE FROM Film WHERE film_id = '{0}'", id);
            return Database.ExecuteNonQuery(query);
        }

        public int FilmGuncelle(
        int f_Id,
        string fAd,
        string fYonetmen,
        string fOyuncular,
        string fVizyonTarihi,
        int fSure,
        int fYasSiniri,
        string fTur,
        string fOzet)
        {
            string query = string.Format("UPDATE Film SET film_adi = '{0}'," +
                "yonetmen = '{1}'," +
                "oyuncular = '{2}'," +
                "tarih = '{3}'," +
                "sure = {4}," +
                "yas_siniri = {5}," +
                "tur = '{6}'," +
                "ozet = '{7}'" +
                "WHERE film_id = {8}", fAd, fYonetmen, fOyuncular, fVizyonTarihi, fSure, fYasSiniri, fTur, fOzet, f_Id);
            return Database.ExecuteNonQuery(query);
        }


    }
}
