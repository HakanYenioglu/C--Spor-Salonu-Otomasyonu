using AkcakocaGym.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkcakocaGym
{
    public partial class frmUyeEkle : Form
    {
        public frmUyeEkle()
        {
            InitializeComponent();
        }
       
        private void lblCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            Musteri musteri = new Musteri();
            musteri.ad = txtAd.Text;
            musteri.soyad = txtSoyad.Text;
            musteri.telefon = mskTxtTel.Text;
            musteri.dogumTarihi = dgmTarihi.Value;
            musteri.cinsiyet = cmbCinsiyet.Text;
            musteri.adres = txtAdres.Text;  
            musteri.kayitTarihi = DateTime.Now;
            musteri.aciklama = txtAciklama.Text;
            musteri.paket = cmboxPaket.Text;
            GymContext db = new GymContext();
            db.Musteri.Add(musteri);
            int sonuc = db.SaveChanges();

            if (sonuc == 1)
            {
                this.DialogResult = DialogResult.OK;
                db.SaveChanges();
            }
                
            else
                this.DialogResult = DialogResult.Abort;

            this.Close();
        }
    }
}
