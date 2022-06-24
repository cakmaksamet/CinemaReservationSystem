namespace deneme
{
    partial class KullaniciGiris
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
            this.btnKayıt = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.tbGirisSifre = new System.Windows.Forms.TextBox();
            this.tbGirisEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGirisMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(400, 230);
            this.btnKayıt.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(100, 36);
            this.btnKayıt.TabIndex = 11;
            this.btnKayıt.Text = "Kayıt";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(280, 230);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 36);
            this.btnGiris.TabIndex = 10;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // tbGirisSifre
            // 
            this.tbGirisSifre.Location = new System.Drawing.Point(228, 187);
            this.tbGirisSifre.Margin = new System.Windows.Forms.Padding(4);
            this.tbGirisSifre.Name = "tbGirisSifre";
            this.tbGirisSifre.Size = new System.Drawing.Size(271, 22);
            this.tbGirisSifre.TabIndex = 9;
            // 
            // tbGirisEmail
            // 
            this.tbGirisEmail.Location = new System.Drawing.Point(228, 157);
            this.tbGirisEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbGirisEmail.Name = "tbGirisEmail";
            this.tbGirisEmail.Size = new System.Drawing.Size(271, 22);
            this.tbGirisEmail.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // lbGirisMesaj
            // 
            this.lbGirisMesaj.AutoSize = true;
            this.lbGirisMesaj.Location = new System.Drawing.Point(225, 104);
            this.lbGirisMesaj.Name = "lbGirisMesaj";
            this.lbGirisMesaj.Size = new System.Drawing.Size(0, 17);
            this.lbGirisMesaj.TabIndex = 12;
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 410);
            this.Controls.Add(this.lbGirisMesaj);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.tbGirisSifre);
            this.Controls.Add(this.tbGirisEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox tbGirisSifre;
        private System.Windows.Forms.TextBox tbGirisEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGirisMesaj;
    }
}