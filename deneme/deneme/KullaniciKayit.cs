using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace deneme
{
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lbMesaj.Text = "";
            tbKayitAd.Clear();
            tbKayitSoyad.Clear();
            tbKayitEmail.Clear();
            tbKayitSifre.Clear();
            tbKayitSifreOnayla.Clear();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            lbMesaj.Text = "";
            //int yas = int.Parse(tbKayitYas.Text.Trim());
            string ad = tbKayitAd.Text.Trim();
            string soyad = tbKayitSoyad.Text.Trim();
            string email = tbKayitEmail.Text.Trim();
            string parola = tbKayitSifre.Text.Trim();
            string şifre_onayla = tbKayitSifreOnayla.Text.Trim();

            if (ad == "")
            {
                lbMesaj.Text = "Lütfen adınızı giriniz ";
                label7.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }

            if (ad != "")
            {
                label7.Text = "";

            }
            if (soyad == "")
            {
                lbMesaj.Text = "Lütfen soyadınızı giriniz ";
                label11.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (soyad != "")
            {
                label11.Text = "";
            }

            if (email == "")
            {
                lbMesaj.Text = "Lütfen emailinizi giriniz ";
                label9.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (email != "")
            {
                label9.Text = "";
            }
            if (email.IndexOf("@") < 0)
            {
                lbMesaj.Text = "2Lütfen emailinizi doğru giriniz ";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (!email.Contains("@"))
            {
                lbMesaj.Text = "3Lütfen emailinizi doğru giriniz ";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (!email.Contains("."))
            {
                lbMesaj.Text = "4Lütfen emailinizi doğru giriniz ";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (parola == "")
            {
                lbMesaj.Text = "Lütfen şifrenizi giriniz ";
                label8.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (parola != "")
            {
                label8.Text = "";
            }
            if (şifre_onayla == "")
            {
                lbMesaj.Text = "Lütfen şifrenizi tekrar giriniz ";
                label12.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (şifre_onayla != "")
            {
                label12.Text = "";
            }
            if (parola != şifre_onayla)
            {
                lbMesaj.Text = "Girdiğiniz şifreler eşleşmedi ";
                lbMesaj.ForeColor = Color.Red;
                return;
            }

            Kullanici k = new Kullanici();
            var result = k.KullaniciEkle(ad, soyad, email, parola);
            if (result > 0)
            {
                lbMesaj.Text = "Başarılı bir şekilde kayıt oldunuz ";
                MessageBox.Show("üye kayıt oldu");
                lbMesaj.ForeColor = Color.Green;
            }
            else
            {
                lbMesaj.Text = "Üye kayıt olunamadı";
                lbMesaj.ForeColor = Color.Red;
            }
        }
    }
}
