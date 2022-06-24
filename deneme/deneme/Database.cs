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
    class Database
    {

        private static string dbPath = @"Data Source=DESKTOP-JQJOCKF;Initial Catalog=Sinema;Integrated Security=True";

        public SqlConnection baglanti()
        {
            //Bu fonksiyon sql bağlantı işlemini yapıyor.
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JQJOCKF;Initial Catalog=Sinema;Integrated Security=True");
            con.Open();
            return con;
        }

        public static DataTable ExecuteQuery(string query)
        {
            //Bu fonksiyon ile arama ve gösterme işlemlerini yapıyoruz.(search and select)
            SqlConnection con = new SqlConnection(dbPath);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);           
            return dt;
        }

        public static int ExecuteNonQuery(string query)
        {
            //Bu fonksiyon ile veri ekleme, silme ve güncelleme işlemlerini yapıyoruz.(insert and delete and update)
            SqlConnection con = new SqlConnection(dbPath);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;

            return cmd.ExecuteNonQuery();
        }

    }
}
