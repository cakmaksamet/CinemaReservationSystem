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

    public partial class FilmEkle : Form
    {
        YoneticiGiris yg = null;
        Film f = new Film();
        string filmAd;
        string yonetmen;
        string oyuncular;
        string vizyonTarihi;
        int sure;
        int yasSiniri;
        string tur;
        string ozet;
        string resimyolu = ResimIslemleri.defResimYolu;

        public FilmEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lbMesaj.Text = "";
            filmAd = txtFilmAd.Text;
            yonetmen = txtFilmYonetmen.Text;
            oyuncular = txtFilmOyuncular.Text;
            vizyonTarihi = txtFilmVizyonTarihi.Text;
            sure = int.Parse(txtFilmSure.Text);
            yasSiniri = int.Parse(txtFilmYasSiniri.Text);
            tur = txtFilmTur.Text;
            ozet = txtFilmOzet.Text;


            if (filmAd == "")
            {
                lbMesaj.Text = "Lütfen film adını giriniz ";
                label13.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (filmAd != "")
            {
                label13.Text = "";
            }
            if (yonetmen == "")
            {
                lbMesaj.Text = "Lütfen yönetmen adını giriniz ";
                label11.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (yonetmen != "")
            {
                label11.Text = "";
            }
            if (oyuncular == "")
            {
                lbMesaj.Text = "Lütfen oyuncu adlarını giriniz ";
                label1.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (oyuncular != "")
            {
                label1.Text = "";
            }
            if (vizyonTarihi == "")
            {
                lbMesaj.Text = "Lütfen vizyon tarihini giriniz giriniz ";
                label7.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (vizyonTarihi != "")
            {
                label7.Text = "";
            }
            if (txtFilmSure.Text == "")
            {
                lbMesaj.Text = "Lütfen filmin süresini giriniz ";
                label12.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (txtFilmSure.Text != "")
            {
                label12.Text = "";
            }
            if (txtFilmYasSiniri.Text == "")
            {
                lbMesaj.Text = "Lütfen filmin yaş sınırını giriniz ";
                label15.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (txtFilmYasSiniri.Text != "")
            {
                label15.Text = "";
            }
            if (tur == "")
            {
                lbMesaj.Text = "Lütfen filmin türünü giriniz ";
                label16.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (tur != "")
            {
                label16.Text = "";
            }
            if (ozet == "")
            {
                lbMesaj.Text = "Lütfen filmin özetini giriniz ";
                label14.Text = "*";
                lbMesaj.ForeColor = Color.Red;
                return;
            }
            if (ozet != "")
            {
                label14.Text = "";
            }
            var result = f.FilmEkle(filmAd, yonetmen, oyuncular, vizyonTarihi, sure, yasSiniri, tur, ozet, resimyolu);
            if (result > 0)
            {
                lbMesaj.Text = "Başarılı bir şekilde kayıt oldu ";
                MessageBox.Show("Film kaydedildi");
                lbMesaj.ForeColor = Color.Green;
            }
            else
            {
                lbMesaj.Text = "Film kaydedilemedi ";
                lbMesaj.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resimyolu = openFileDialog1.FileName;
            try
            {
                pictureBox1.Image = ResimIslemleri.Get_Bitmap(resimyolu);
            }
            catch (Exception)
            {
                pictureBox1.Image = ResimIslemleri.Get_Bitmap(ResimIslemleri.defResimYolu);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (yg == null)
            {
                yg = new YoneticiGiris();
            }
            yg.Show();
            this.Hide();
        }
    }
}
