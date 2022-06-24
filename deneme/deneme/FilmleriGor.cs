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
    public partial class FilmleriGor : Form
    {
        YoneticiGiris yg = null;
        Film f = new Film();

        public FilmleriGor()
        {
            InitializeComponent();
        }
        private void FilmleriGor_Load(object sender, EventArgs e)
        {
            LoadGridviewdata();
        }
        public void LoadGridviewdata()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = f.FilmleriGoster();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (yg == null)
            {
                yg = new YoneticiGiris();
            }
            yg.Show();
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f.Film_Adi_Ile_Arama(txArananFilm.Text);
            if (txArananFilm.Text == "")
            {
                dataGridView1.DataSource = f.FilmleriGoster();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10 && e.RowIndex >= 0)
            {
                int FilID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                FilmDetaylar detay = new FilmDetaylar(FilID, this);
                detay.StartPosition = FormStartPosition.Manual;

                Rectangle pos = Screen.PrimaryScreen.Bounds;
                detay.Location = new Point(pos.Width - detay.Width);
                detay.ShowDialog();
            }
        }


    }
}
