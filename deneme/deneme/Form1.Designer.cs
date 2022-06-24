namespace deneme
{
    partial class Form1
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
            this.btnKullaniciGirisi = new System.Windows.Forms.Button();
            this.btnYoneticiGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullaniciGirisi
            // 
            this.btnKullaniciGirisi.Location = new System.Drawing.Point(261, 109);
            this.btnKullaniciGirisi.Name = "btnKullaniciGirisi";
            this.btnKullaniciGirisi.Size = new System.Drawing.Size(226, 91);
            this.btnKullaniciGirisi.TabIndex = 0;
            this.btnKullaniciGirisi.Text = "Kullanıcı Girişi";
            this.btnKullaniciGirisi.UseVisualStyleBackColor = true;
            this.btnKullaniciGirisi.Click += new System.EventHandler(this.btnKullaniciGirisi_Click);
            // 
            // btnYoneticiGirisi
            // 
            this.btnYoneticiGirisi.Location = new System.Drawing.Point(261, 222);
            this.btnYoneticiGirisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnYoneticiGirisi.Name = "btnYoneticiGirisi";
            this.btnYoneticiGirisi.Size = new System.Drawing.Size(226, 91);
            this.btnYoneticiGirisi.TabIndex = 5;
            this.btnYoneticiGirisi.Text = "Yönetici Girişi";
            this.btnYoneticiGirisi.UseVisualStyleBackColor = true;
            this.btnYoneticiGirisi.Click += new System.EventHandler(this.btnYoneticiGirisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(780, 446);
            this.Controls.Add(this.btnYoneticiGirisi);
            this.Controls.Add(this.btnKullaniciGirisi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciGirisi;
        private System.Windows.Forms.Button btnYoneticiGirisi;
    }
}