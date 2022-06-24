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
    public partial class FilmBilgileri : Form
    {
        public string epost;
        Database db = new Database();
        Film f = new Film();
        FilmSec fs = null;
        BiletAl ba = null;
        //MemleketBilgisi mb = null;
        private int film_id;
        private string film_adi;
        private string yonetmen;
        private string oyuncular;
        private string tarih;
        private int sure;
        private int yas_siniri;
        private string tur;
        private string ozet;
        private string yol;
        public static string filmAdi;

        public int Film_id { get => film_id; set => film_id = value; }

        public FilmBilgileri()
        {
            InitializeComponent();
        }

        private void FilmBilgileri_Load(object sender, EventArgs e)
        {
            DataTable dt = f.Film_Id_Ile_Arama(film_id);

            

            film_adi = dt.Rows[0][1].ToString();
            yonetmen = dt.Rows[0][2].ToString();
            oyuncular = dt.Rows[0][3].ToString();
            tarih = dt.Rows[0][4].ToString();
            sure = int.Parse(dt.Rows[0][5].ToString());
            yas_siniri = int.Parse(dt.Rows[0][6].ToString());
            tur = dt.Rows[0][7].ToString();
            ozet = dt.Rows[0][8].ToString();
            yol = dt.Rows[0][9].ToString();


            tbGirissFilmAdi.Text = film_adi;
            tbGirissYonetmen.Text = yonetmen;
            tbGirissOyuncular.Text = oyuncular;
            tbGirissVizyonTarihi.Text = tarih;
            tbGirissSure.Text = sure.ToString();
            tbGirissTur.Text = tur;
            tbGirissOzet.Text = ozet;
            Bitmap image = new Bitmap(yol);
            pictureBox1.Image = image;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (fs == null)
            {
                fs = new FilmSec();
            }
            fs.Show();
            this.Hide();
        }

        private void BiletAl_Click(object sender, EventArgs e)
        {
            filmAdi = tbGirissFilmAdi.Text;

            string isim = tbGirissFilmAdi.Text.Trim();
            string query = string.Format("Select * From AvmBilgisi Where FILM_ADI = '{0}' ", isim);

            if (ba == null)
            {
                film_adi = tbGirissFilmAdi.Text;
                ba = new BiletAl();
                ba.Film_id = film_id;

            }
            ba.Show();
            this.Hide();
        }
    }
}
