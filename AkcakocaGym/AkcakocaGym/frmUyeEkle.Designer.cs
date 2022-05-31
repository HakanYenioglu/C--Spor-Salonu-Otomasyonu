
namespace AkcakocaGym
{
    partial class frmUyeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUyeEkle));
            this.lblCikis = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmboxPaket = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.mskTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblDgmTarih = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.dgmTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.BackColor = System.Drawing.Color.Transparent;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.ForeColor = System.Drawing.Color.Red;
            this.lblCikis.Location = new System.Drawing.Point(885, -5);
            this.lblCikis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(41, 39);
            this.lblCikis.TabIndex = 31;
            this.lblCikis.Text = "X";
            this.lblCikis.Click += new System.EventHandler(this.lblCikis_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.Location = new System.Drawing.Point(712, 359);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(197, 86);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(504, 359);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(184, 86);
            this.btnKaydet.TabIndex = 27;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(509, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmboxPaket);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.lblCinsiyet);
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.Controls.Add(this.mskTxtTel);
            this.groupBox1.Controls.Add(this.lblAciklama);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.lblDgmTarih);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.dgmTarihi);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(488, 476);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // cmboxPaket
            // 
            this.cmboxPaket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboxPaket.FormattingEnabled = true;
            this.cmboxPaket.Items.AddRange(new object[] {
            "Aylık Paket",
            "Ekonomik Paket",
            "Süper Paket",
            "Yıllık Paket",
            "Yüzme Paketi",
            "Yoga Paketi",
            "Süper + Yüzme Paketi",
            "Boks Paketi"});
            this.cmboxPaket.Location = new System.Drawing.Point(189, 244);
            this.cmboxPaket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmboxPaket.Name = "cmboxPaket";
            this.cmboxPaket.Size = new System.Drawing.Size(289, 33);
            this.cmboxPaket.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Paket : ";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(189, 375);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(289, 93);
            this.txtAciklama.TabIndex = 7;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(189, 290);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(289, 77);
            this.txtAdres.TabIndex = 6;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(61, 202);
            this.lblCinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(103, 25);
            this.lblCinsiyet.TabIndex = 36;
            this.lblCinsiyet.Text = "Cinsiyet :";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(189, 198);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(289, 33);
            this.cmbCinsiyet.TabIndex = 5;
            // 
            // mskTxtTel
            // 
            this.mskTxtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTxtTel.Location = new System.Drawing.Point(189, 113);
            this.mskTxtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskTxtTel.Mask = "(999) 000-0000";
            this.mskTxtTel.Name = "mskTxtTel";
            this.mskTxtTel.Size = new System.Drawing.Size(289, 30);
            this.mskTxtTel.TabIndex = 3;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.BackColor = System.Drawing.Color.Transparent;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(53, 375);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(119, 25);
            this.lblAciklama.TabIndex = 33;
            this.lblAciklama.Text = "Açıklama : ";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.BackColor = System.Drawing.Color.Transparent;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(75, 290);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(82, 25);
            this.lblAdres.TabIndex = 32;
            this.lblAdres.Text = "Adres :";
            // 
            // lblDgmTarih
            // 
            this.lblDgmTarih.AutoSize = true;
            this.lblDgmTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblDgmTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDgmTarih.Location = new System.Drawing.Point(8, 154);
            this.lblDgmTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDgmTarih.Name = "lblDgmTarih";
            this.lblDgmTarih.Size = new System.Drawing.Size(160, 25);
            this.lblDgmTarih.TabIndex = 31;
            this.lblDgmTarih.Text = "Doğum Tarihi : ";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.Location = new System.Drawing.Point(69, 113);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(104, 25);
            this.lblTel.TabIndex = 30;
            this.lblTel.Text = "Telefon : ";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(83, 71);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(93, 25);
            this.lblSoyad.TabIndex = 29;
            this.lblSoyad.Text = "Soyad : ";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(189, 68);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(289, 30);
            this.txtSoyad.TabIndex = 2;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(120, 27);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(58, 25);
            this.lblAd.TabIndex = 26;
            this.lblAd.Text = "Ad : ";
            // 
            // dgmTarihi
            // 
            this.dgmTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgmTarihi.Location = new System.Drawing.Point(189, 154);
            this.dgmTarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgmTarihi.Name = "dgmTarihi";
            this.dgmTarihi.Size = new System.Drawing.Size(289, 30);
            this.dgmTarihi.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(189, 23);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(289, 30);
            this.txtAd.TabIndex = 1;
            // 
            // frmUyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUyeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUyeEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox mskTxtTel;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblDgmTarih;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.DateTimePicker dgmTarihi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ComboBox cmboxPaket;
        private System.Windows.Forms.Label label1;
    }
}