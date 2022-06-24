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
    public partial class FilmSil : Form
    {
        YoneticiGiris yg = null;
        Film f = new Film();
        public FilmSil()
        {
            InitializeComponent();
        }

        private void FilmSil_Load(object sender, EventArgs e)
        {
            FilmdataGridView1.DataSource = f.FilmleriGoster();
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

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kayıtları silmek istediğinize emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                for (int i = 0; i < FilmdataGridView1.SelectedRows.Count; i++)
                {
                    f.FilmSil(FilmdataGridView1.SelectedRows[i].Cells["film_id"].Value.ToString());
                }
                MessageBox.Show("kayıtlar silindi");
                FilmdataGridView1.DataSource = f.FilmleriGoster();
            }
            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("kayıtlar silinmedi");
                FilmdataGridView1.DataSource = f.FilmleriGoster();
            }
        }
    }
}
