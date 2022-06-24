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
    public partial class FilmDetaylar : Form
    {
        int FilmId = -1;
        FilmleriGor fg = null;

        Film f = new Film();

        public FilmDetaylar(int id, FilmleriGor g)
        {
            InitializeComponent();
            FilmId = id;
            fg = g;
        }

        private void FilmDetaylar_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = f.Film_Id_Ile_Arama(FilmId);
                if (dt.Rows.Count > 0)
                {
                    txtFilmId.Text = dt.Rows[0]["film_id"].ToString();
                    txtFilmAd.Text = dt.Rows[0]["film_adi"].ToString();
                    txtFilmYonetmen.Text = dt.Rows[0]["yonetmen"].ToString();
                    txtFilmOyuncular.Text = dt.Rows[0]["oyuncular"].ToString();
                    txtFilmVizyonTarihi.Text = dt.Rows[0]["tarih"].ToString();
                    txtFilmSure.Text = dt.Rows[0]["sure"].ToString();
                    txtFilmYasSiniri.Text = dt.Rows[0]["yas_siniri"].ToString();
                    txtFilmTur.Text = dt.Rows[0]["tur"].ToString();
                    txtFilmOzet.Text = dt.Rows[0]["ozet"].ToString();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Film f = new Film();
                int yas_siniri = int.Parse(txtFilmYasSiniri.Text);
                int sure = int.Parse(txtFilmSure.Text);
                int result = f.FilmGuncelle(FilmId, txtFilmAd.Text, txtFilmYonetmen.Text, txtFilmOyuncular.Text, txtFilmVizyonTarihi.Text, sure, yas_siniri, txtFilmTur.Text, txtFilmOzet.Text);

                if (result > 0)
                {
                    lblMessage.Text = "Updated successfully.";
                    lblMessage.ForeColor = Color.Green;

                    if (fg != null)
                    {
                        fg.LoadGridviewdata();
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                lblMessage.ForeColor = Color.Red;
            }
        }
    }
}
