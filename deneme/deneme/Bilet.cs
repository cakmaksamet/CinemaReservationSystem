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
    class Bilet
    {
        int film_id;
        string film_ad;
        string SECILEN_KOLTUK;
        string fiyat;
        public int ID { get => film_id; set => film_id = value; }
        public string Film_ad { get => film_ad; set => film_ad = value; }
        public string sECILEN_KOLTUK { get => SECILEN_KOLTUK; set => SECILEN_KOLTUK = value; }
        public string Fiyat { get => fiyat; set => fiyat = value; }


        public int BiletEkle(
            string film_ad,
            string SECILEN_KOLTUK,
            string fiyat)
        {
            string query = string.Format("INSERT INTO Bilet(FILM_ADI,SECILEN_KOLTUK,FIYAT) " +
                "VALUES('{0}','{1}','{2}')",  film_ad, SECILEN_KOLTUK, fiyat);
            return Database.ExecuteNonQuery(query);
        }
        public int TiklananKoltuklar(
            string SECILEN_KOLTUK)
        {
            string query = string.Format("INSERT INTO TiklananKoltuklar(TiklananKoltuklar) " +
                "VALUES('{0}')",  SECILEN_KOLTUK);
            return Database.ExecuteNonQuery(query);
        }

    }
}
