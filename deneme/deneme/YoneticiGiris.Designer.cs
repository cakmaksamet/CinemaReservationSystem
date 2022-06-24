namespace deneme
{
    partial class YoneticiGiris
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
            this.btnFilmSil = new System.Windows.Forms.Button();
            this.btnFilmleriGor = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnKullanicilariGor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFilmSil
            // 
            this.btnFilmSil.Location = new System.Drawing.Point(298, 264);
            this.btnFilmSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilmSil.Name = "btnFilmSil";
            this.btnFilmSil.Size = new System.Drawing.Size(115, 53);
            this.btnFilmSil.TabIndex = 11;
            this.btnFilmSil.Text = "Film Sil";
            this.btnFilmSil.UseVisualStyleBackColor = true;
            this.btnFilmSil.Click += new System.EventHandler(this.btnFilmSil_Click);
            // 
            // btnFilmleriGor
            // 
            this.btnFilmleriGor.Location = new System.Drawing.Point(298, 203);
            this.btnFilmleriGor.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilmleriGor.Name = "btnFilmleriGor";
            this.btnFilmleriGor.Size = new System.Drawing.Size(115, 53);
            this.btnFilmleriGor.TabIndex = 10;
            this.btnFilmleriGor.Text = "Filmleri Gör";
            this.btnFilmleriGor.UseVisualStyleBackColor = true;
            this.btnFilmleriGor.Click += new System.EventHandler(this.btnFilmleriGor_Click);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Location = new System.Drawing.Point(298, 142);
            this.btnFilmEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(115, 53);
            this.btnFilmEkle.TabIndex = 9;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // btnKullanicilariGor
            // 
            this.btnKullanicilariGor.Location = new System.Drawing.Point(298, 81);
            this.btnKullanicilariGor.Margin = new System.Windows.Forms.Padding(4);
            this.btnKullanicilariGor.Name = "btnKullanicilariGor";
            this.btnKullanicilariGor.Size = new System.Drawing.Size(115, 53);
            this.btnKullanicilariGor.TabIndex = 8;
            this.btnKullanicilariGor.Text = "Üyerleri Gör";
            this.btnKullanicilariGor.UseVisualStyleBackColor = true;
            this.btnKullanicilariGor.Click += new System.EventHandler(this.btnKullanicilariGor_Click);
            // 
            // YoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 429);
            this.Controls.Add(this.btnFilmSil);
            this.Controls.Add(this.btnFilmleriGor);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.btnKullanicilariGor);
            this.Name = "YoneticiGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoneticiGiris";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFilmSil;
        private System.Windows.Forms.Button btnFilmleriGor;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnKullanicilariGor;
    }
}