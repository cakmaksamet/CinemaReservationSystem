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
    
    public partial class Form1 : Form
    {
        KullaniciGiris kg = null;
        Yonetici yn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKullaniciGirisi_Click(object sender, EventArgs e)
        {
            if (kg == null)
            {
                kg = new KullaniciGiris();
            }
            kg.Show();
            this.Hide();
        }

        private void btnYoneticiGirisi_Click(object sender, EventArgs e)
        {
            if (yn == null)
            {
                yn = new Yonetici();
            }
            yn.Show();
            this.Hide();
        }
    }
}
