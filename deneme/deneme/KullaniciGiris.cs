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
    public partial class KullaniciGiris : Form
    {
        KullaniciKayit kk = null;
        BiletAl ba = new BiletAl();
        public KullaniciGiris()
        {
            InitializeComponent();
        }
        public string mektup;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string email = tbGirisEmail.Text.Trim();
            string sifre = tbGirisSifre.Text.Trim();
            
            Kullanici k = new Kullanici();
            
            

            if (k.KullaniciGiris(email, sifre))
            {                
                FilmSec Is = new FilmSec();    
                Is.eposta = tbGirisEmail.Text;
                
                Is.ShowDialog();
                this.Hide();
            }
            else
            {
                lbGirisMesaj.Text = "Şifre yada Mail adresi yanlış";
                lbGirisMesaj.ForeColor = Color.Red;
            }
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (kk == null)
            {
                kk = new KullaniciKayit();
            }
            kk.Show();
            this.Hide();
        }
    }
}
