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
    public partial class Yonetici : Form
    {
        YoneticiGiris yg = null;

        string email = "samet@gmail.com";
        public Yonetici()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(tbGirisEmail.Text == email)
            {
                if (yg == null)
                {
                    yg = new YoneticiGiris();
                }
                yg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre yanlış");
            }
            
        }
    }
}
