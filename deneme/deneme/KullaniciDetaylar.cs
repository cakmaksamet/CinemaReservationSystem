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
    public partial class KullaniciDetaylar : Form
    {
        int ID = -1;
        KullanicilariGor kg = null;

        Kullanici k = new Kullanici();

        public KullaniciDetaylar(int id, KullanicilariGor g)
        {
            InitializeComponent();
            ID = id;
            kg = g;
        }


        private void KullaniciDetaylar_Load_1(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = k.Kullanici_Id_Ile_Arama(ID);
                if (dt.Rows.Count > 0)
                {
                    txtKullaniciId.Text = dt.Rows[0]["ID"].ToString();
                    txtKullaniciAd.Text = dt.Rows[0]["ad"].ToString();
                    txtKullaniciSoyad.Text = dt.Rows[0]["soyad"].ToString();
                    txtKullaniciEmail.Text = dt.Rows[0]["email"].ToString();
                    txtKullaniciSifre.Text = dt.Rows[0]["parola"].ToString();                   
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Kullanici k = new Kullanici();
                int id = int.Parse(txtKullaniciId.Text);              
                int result = k.KullaniciGuncelle(id, txtKullaniciAd.Text, txtKullaniciSoyad.Text, txtKullaniciEmail.Text, txtKullaniciSifre.Text);

                if (result > 0)
                {
                    lblMessage.Text = "Updated successfully.";
                    lblMessage.ForeColor = Color.Green;

                    if (kg != null)
                    {
                        kg.LoadGridviewdata();
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

