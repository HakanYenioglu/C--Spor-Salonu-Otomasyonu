
namespace AkcakocaGym
{
    partial class frmKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGirisi));
            this.btnReset = new System.Windows.Forms.Button();
            this.SifreIcon = new System.Windows.Forms.PictureBox();
            this.KullaniciIcon = new System.Windows.Forms.PictureBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SifreIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.Location = new System.Drawing.Point(223, 354);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 53);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SifreIcon
            // 
            this.SifreIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SifreIcon.BackgroundImage")));
            this.SifreIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SifreIcon.Location = new System.Drawing.Point(285, 303);
            this.SifreIcon.Name = "SifreIcon";
            this.SifreIcon.Size = new System.Drawing.Size(42, 31);
            this.SifreIcon.TabIndex = 13;
            this.SifreIcon.TabStop = false;
            // 
            // KullaniciIcon
            // 
            this.KullaniciIcon.BackColor = System.Drawing.SystemColors.Control;
            this.KullaniciIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KullaniciIcon.BackgroundImage")));
            this.KullaniciIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KullaniciIcon.Location = new System.Drawing.Point(285, 253);
            this.KullaniciIcon.Name = "KullaniciIcon";
            this.KullaniciIcon.Size = new System.Drawing.Size(42, 31);
            this.KullaniciIcon.TabIndex = 12;
            this.KullaniciIcon.TabStop = false;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(97, 303);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(182, 31);
            this.txtSifre.TabIndex = 11;
            this.txtSifre.Text = "SpOr6154";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.Location = new System.Drawing.Point(97, 253);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(182, 31);
            this.txtKullanici.TabIndex = 10;
            this.txtKullanici.Text = "spazzokcu6154";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(97, 56);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(230, 181);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 9;
            this.Logo.TabStop = false;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(97, 354);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(104, 53);
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click_1);
            // 
            // frmKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 486);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.SifreIcon);
            this.Controls.Add(this.KullaniciIcon);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.btnGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKullaniciGirisi";
            ((System.ComponentModel.ISupportInitialize)(this.SifreIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox SifreIcon;
        private System.Windows.Forms.PictureBox KullaniciIcon;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnGiris;
    }
}