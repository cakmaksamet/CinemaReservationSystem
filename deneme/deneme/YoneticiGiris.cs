using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace deneme
{
    public partial class YoneticiGiris : Form
    {
        FilmEkle fe = null;
        FilmleriGor fg = null;
        FilmSil fs = null;
        KullanicilariGor kg = null;
        public YoneticiGiris()
        {
            InitializeComponent();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            if (fe == null)
            {
                fe = new FilmEkle();
            }
            fe.Show();
            this.Hide();
        }

        private void btnFilmleriGor_Click(object sender, EventArgs e)
        {
            if (fg == null)
            {
                fg = new FilmleriGor();
            }
            fg.Show();
            this.Hide();
        }

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            if (fs == null)
            {
                fs = new FilmSil();
            }
            fs.Show();
            this.Hide();
        }

        private void btnKullanicilariGor_Click(object sender, EventArgs e)
        {
            if ( kg== null)
            {
                kg = new KullanicilariGor();
            }
            kg.Show();
            this.Hide();
        }
    }
}
