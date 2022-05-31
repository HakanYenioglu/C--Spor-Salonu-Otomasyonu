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
    public partial class frmUyeDuzenle : Form
    {
        public frmUyeDuzenle()
        {
            InitializeComponent();
        }
        public Musteri musteri;

        private void lblCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string ad,soyad,tel,paket,adres,aciklama;

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtAd.Text = " ";
            txtSoyad.Text = " ";
            mskTxtTel.Text = " ";
            txtAdres.Text = " ";
            txtAciklama.Text = " ";
            cmboxPaket.Text = " ";
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            GymContext db = new GymContext();
            Musteri m = db.Musteri.Where(x => x.musteriID == musteri.musteriID).SingleOrDefault();
            m.ad = txtAd.Text;
            m.soyad = txtSoyad.Text;
            m.telefon = mskTxtTel.Text;
            m.adres = txtAdres.Text;
            m.aciklama = txtAciklama.Text;
            db.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmUyeDuzenle_Load(object sender, EventArgs e)
        {
            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            mskTxtTel.Text = tel;
            cmboxPaket.Text = paket;
            txtAdres.Text = adres;
            txtAciklama.Text = aciklama;

        }

    }   
}
