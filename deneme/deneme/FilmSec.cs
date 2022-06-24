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
   
    public partial class FilmSec : Form
    {
        public string eposta;
        KullaniciGiris kg = null;
        Film f = new Film();
        Database d = new Database();
        public FilmSec()
        {
            InitializeComponent();
        }
        int Satir;
        int Sutun;
        int MusteriYas;

        public FilmSec(int yas)
        {
            InitializeComponent();
            MusteriYas = yas;
        }
        
        void Filmleri_Goruntule()
        {
            string query = "SELECT * FROM Film";
            DataTable dt = Database.ExecuteQuery(query);

            string filmAdi;
            string resimYolu;
            int filmID;
            
            

            int film_sayisi = dt.Rows.Count;

            for (int i = 0; i < film_sayisi; i++)
            {
                filmAdi = dt.Rows[i][1].ToString();
                resimYolu = dt.Rows[i][9].ToString();
                filmID = int.Parse(dt.Rows[i][0].ToString());
                FilmKutu film = new FilmKutu(filmAdi, resimYolu, filmID);
                film.Location = new System.Drawing.Point(Sutun, 5);
                this.tableLayoutPanel1.Controls.Add(film);
                film.Show();
                Sutun += 1;
                if (Sutun == 3)
                {
                    Satir += 1;
                    Sutun = 0;
                }

            }

        }
        private void btnFilmSecGeri_Click(object sender, EventArgs e)
        {
            if (kg == null)
            {
                kg = new KullaniciGiris();
            }
            kg.Show();
            this.Hide();
        }

        private void FilmSec_Load(object sender, EventArgs e)
        {
            
            Sutun = 0;
            Satir = 0;
            Filmleri_Goruntule();
        }

        
    }
}
