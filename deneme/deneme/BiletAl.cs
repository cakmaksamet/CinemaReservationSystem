using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace deneme
{
    public partial class BiletAl : Form
    {
        private int film_id;
        private string film_adi;
        public int Film_id { get => film_id; set => film_id = value; }



        public BiletAl()
        {
            InitializeComponent();
            
            A1.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            A2.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            A3.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            A4.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            B1.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            B2.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            B3.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            B4.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            C1.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            C2.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            C3.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            C4.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            
        }
        public Button tıklananbuton;

        public int ID;
        
        int boskoltuklar = 12;
        int dolukoltuklar = 0;
        
        void tıklama_MouseClick(object sender, EventArgs e)
        {
            // bu kısımda veritabanı bağlantısı oluşturduk. Koltuklara her tıklandığında koltukların namesi (örn A1,C5 gibi) veritabanına atacak.
            // Bilet iptal işleminde işimize yarıyacaktır. Çünkü tıklanan koltuk namelerini veritabanında tutup iptal işleminde karşılaştırıp ona göre bos-dolu
            // ayarını yaparız.
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JQJOCKF;Initial Catalog=Sinema;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (con.State == ConnectionState.Closed) // bağlantı kontrol
            {
                con.Open();
            }
            tıklananbuton = (Button)sender;

            cmd.CommandText = @"INSERT INTO TiklananKoltuklar(TiklananKoltuklar) values (@TiklananKoltuklar)";
            cmd.Parameters.AddWithValue("@TiklananKoltuklar", tıklananbuton.Name); // tıklanankoltuk namelerini veritabanına attık.
            cmd.ExecuteNonQuery();

            tıklananbuton.BackColor = Color.Green;
            tıklananbuton.Enabled = false;
            boskoltuklar--;
            dolukoltuklar++;
            lblBosKoltukSayisi.Text = boskoltuklar.ToString();
            lblDoluKoltukSayisi.Text = dolukoltuklar.ToString();
            if (tbKoltuk.Text == "") // eğer text boş ise ekle
            {
                groupBox2.Enabled = true;
                tbKoltuk.Text = tıklananbuton.Name.ToString();
            }
            else // boş değil ise araya ; koyarak ekle
            {
                groupBox2.Enabled = true;
                tbKoltuk.Text += ";" + tıklananbuton.Name.ToString();
            }
      
            con.Close();
        }
        
        void temizle()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-JQJOCKF;Initial Catalog=Sinema;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"delete TiklananKoltuklar"; //burda tıklanan koltuk namelerini TiklananKoltuk aktardık, bu tabloyuda
            //kökten temizler. Maksat veritabanın içindeki tablo kalabalık olmasın..
            // 
            tbFilmAdi.Clear();
           
            tbKoltuk.Clear();

            cmd.ExecuteNonQuery();
            con.Close();
        }
            
        private void btnBiletKes_Click(object sender, EventArgs e)
        {
            TekrarKayit();
            if (durum == true)
            {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-JQJOCKF;Initial Catalog=Sinema;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (con.State == ConnectionState.Closed) // bağlantı kontrol
            {
                con.Open();
            }
                Bilet k = new Bilet();
                var result = k.BiletEkle(tbFilmAdi.Text, tbKoltuk.Text, tbFiyat.Text);
                //var result = k.TiklananKoltuklar(tbKoltuk.Text);
                MessageBox.Show("Bilet Alınmıştır..", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                temizle();
                Refresh();
                btnBiletKes.Enabled = false;
                groupBox2.Enabled = false;
                groupBox1.Enabled = false;
                con.Close();
            }
            else
            {
                MessageBox.Show("Bilet Alınamadı", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tıklananbuton.BackColor = Color.Red;
                tbKoltuk.Clear();
            }   
                     
        }
        
        bool durum;
        void TekrarKayit()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-JQJOCKF;Initial Catalog=Sinema;Integrated Security=True";
            con.Open();

            SqlCommand komut = new SqlCommand("select * from Bilet where SECILEN_KOLTUK=@tikKoltuk and FILM_ADI=@film_adi ", con);
            komut.Parameters.AddWithValue("@tikKoltuk", tbKoltuk.Text);
            komut.Parameters.AddWithValue("@film_adi", tbFilmAdi.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            con.Close();
        }
        
        private void BiletAl_Load(object sender, EventArgs e)
        {
            // bu kısımda yeni veritabanı bağlantısı açtık. Burada dolu koltukları form açılışında dolu olarak göstereceğiz.
            SqlConnection yeni = new SqlConnection(@"Data Source=DESKTOP-JQJOCKF;Initial Catalog=Sinema;Integrated Security=True"); // veritabanı yolunu yaz buraya...
            yeni.Open();
            SqlCommand komut = new SqlCommand();

            komut.Connection = yeni;
            komut.CommandText = string.Format("SELECT * FROM Film Where film_id = '{0}'", film_id);
            SqlDataReader reader = komut.ExecuteReader();

            reader.Read();

            film_adi = reader.GetString(1);
            tbFilmAdi.Text = film_adi;


            yeni.Close();           
            Refresh();
        }
    }
}
