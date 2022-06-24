using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class FilmKutu : UserControl
    {
       
        FilmBilgileri fb = null;
        int filmID;
        string FilmAdi;
        string ResimYolu;

        public FilmKutu()
        {
            InitializeComponent();
        }
        public FilmKutu(string filmadi, string resimyolu, int filmid)
        {
            InitializeComponent();
            FilmAdi = filmadi;
            ResimYolu = resimyolu;

            pictureBox1.Image = ResimIslemleri.Get_Bitmap(ResimYolu);
            label1.Text = FilmAdi;
            
            filmID = filmid;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {                    
            if (fb == null)
            {
                FilmSec fs = new FilmSec();                            
                fb = new FilmBilgileri();
                fb.Film_id = filmID;
            }

            fb.Show();
        }
    }
}
