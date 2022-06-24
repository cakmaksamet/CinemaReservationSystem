namespace deneme
{
    partial class FilmSil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnFilmSil = new System.Windows.Forms.Button();
            this.FilmdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FilmdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(773, 400);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 28);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnFilmSil
            // 
            this.btnFilmSil.Location = new System.Drawing.Point(665, 400);
            this.btnFilmSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilmSil.Name = "btnFilmSil";
            this.btnFilmSil.Size = new System.Drawing.Size(100, 28);
            this.btnFilmSil.TabIndex = 4;
            this.btnFilmSil.Text = "Sil";
            this.btnFilmSil.UseVisualStyleBackColor = true;
            this.btnFilmSil.Click += new System.EventHandler(this.btnFilmSil_Click);
            // 
            // FilmdataGridView1
            // 
            this.FilmdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmdataGridView1.Location = new System.Drawing.Point(86, 77);
            this.FilmdataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.FilmdataGridView1.Name = "FilmdataGridView1";
            this.FilmdataGridView1.RowHeadersWidth = 51;
            this.FilmdataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FilmdataGridView1.Size = new System.Drawing.Size(787, 315);
            this.FilmdataGridView1.TabIndex = 3;
            // 
            // FilmSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 503);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnFilmSil);
            this.Controls.Add(this.FilmdataGridView1);
            this.Name = "FilmSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmSil";
            this.Load += new System.EventHandler(this.FilmSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilmdataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnFilmSil;
        private System.Windows.Forms.DataGridView FilmdataGridView1;
    }
}