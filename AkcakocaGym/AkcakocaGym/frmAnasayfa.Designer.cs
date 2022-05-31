
namespace AkcakocaGym
{
    partial class frmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCikis = new System.Windows.Forms.Label();
            this.btnUrunSatis = new System.Windows.Forms.Button();
            this.btnEgitmenBilg = new System.Windows.Forms.Button();
            this.btnUyeBilg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCikis);
            this.panel1.Controls.Add(this.btnUrunSatis);
            this.panel1.Controls.Add(this.btnEgitmenBilg);
            this.panel1.Controls.Add(this.btnUyeBilg);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 60);
            this.panel1.TabIndex = 1;
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.BackColor = System.Drawing.Color.Transparent;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.ForeColor = System.Drawing.Color.Red;
            this.lblCikis.Location = new System.Drawing.Point(637, 0);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(33, 31);
            this.lblCikis.TabIndex = 27;
            this.lblCikis.Text = "X";
            this.lblCikis.Click += new System.EventHandler(this.lblCikis_Click_1);
            // 
            // btnUrunSatis
            // 
            this.btnUrunSatis.BackColor = System.Drawing.SystemColors.Control;
            this.btnUrunSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSatis.Location = new System.Drawing.Point(495, 0);
            this.btnUrunSatis.Name = "btnUrunSatis";
            this.btnUrunSatis.Size = new System.Drawing.Size(116, 60);
            this.btnUrunSatis.TabIndex = 5;
            this.btnUrunSatis.Text = "Ürün Satış";
            this.btnUrunSatis.UseVisualStyleBackColor = false;
            this.btnUrunSatis.Click += new System.EventHandler(this.btnUrunSatis_Click_1);
            // 
            // btnEgitmenBilg
            // 
            this.btnEgitmenBilg.BackColor = System.Drawing.SystemColors.Control;
            this.btnEgitmenBilg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEgitmenBilg.Location = new System.Drawing.Point(284, 0);
            this.btnEgitmenBilg.Name = "btnEgitmenBilg";
            this.btnEgitmenBilg.Size = new System.Drawing.Size(175, 60);
            this.btnEgitmenBilg.TabIndex = 4;
            this.btnEgitmenBilg.Text = "Eğitmen Bilgileri";
            this.btnEgitmenBilg.UseVisualStyleBackColor = false;
            this.btnEgitmenBilg.Click += new System.EventHandler(this.btnEgitmenBilg_Click_1);
            // 
            // btnUyeBilg
            // 
            this.btnUyeBilg.BackColor = System.Drawing.SystemColors.Control;
            this.btnUyeBilg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeBilg.Location = new System.Drawing.Point(106, 0);
            this.btnUyeBilg.Name = "btnUyeBilg";
            this.btnUyeBilg.Size = new System.Drawing.Size(142, 60);
            this.btnUyeBilg.TabIndex = 2;
            this.btnUyeBilg.Text = "Üye Bilgileri";
            this.btnUyeBilg.UseVisualStyleBackColor = false;
            this.btnUyeBilg.Click += new System.EventHandler(this.btnUyeBilg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 432);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnasayfa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Button btnUrunSatis;
        private System.Windows.Forms.Button btnEgitmenBilg;
        private System.Windows.Forms.Button btnUyeBilg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}