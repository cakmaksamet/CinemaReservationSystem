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
    public partial class KullanicilariGor : Form
    {
        YoneticiGiris yg = null;
        Kullanici k = new Kullanici();
        public KullanicilariGor()
        {
            InitializeComponent();
        }
        private void KullanicilariGor_Load(object sender, EventArgs e)
        {
            LoadGridviewdata();
        }
        public void LoadGridviewdata()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = k.KullanicilariGoster();
                DataGridViewButtonColumn bc = new DataGridViewButtonColumn();
                bc.HeaderText = "Eylem";
                bc.Text = "Ayrıntı";
                bc.Name = "Ayrıntı";
                bc.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(bc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = k.Kullanici_Adi_Ile_Arama(txArananKullanici.Text);
            if (txArananKullanici.Text == "")
            {
                dataGridView1.DataSource = k.KullanicilariGoster();
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                int kulID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                KullaniciDetaylar detay = new KullaniciDetaylar(kulID, this);
                detay.StartPosition = FormStartPosition.Manual;

                Rectangle pos = Screen.PrimaryScreen.Bounds;
                detay.Location = new Point(pos.Width - detay.Width);
                detay.ShowDialog();
            }
        }

    }
}
