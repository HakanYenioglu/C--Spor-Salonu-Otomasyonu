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
    public partial class frmUyeBilgileri : Form
    {
        public frmUyeBilgileri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GymContext db = new GymContext();
            int uyeid = (int)gridUyeBilgisi.SelectedRows[0].Cells[0].Value;
            Musteri musteri = db.Musteri.Where(x => x.musteriID == uyeid).SingleOrDefault();
            frmUyeEkle uye = new frmUyeEkle();

            DialogResult sonuc = uye.ShowDialog();
            if (sonuc == DialogResult.OK)
                Doldur();

        }
        private void Doldur()
        {
            GymContext db = new GymContext();
            var liste = db.Musteri.Select(x => new
            {
                x.musteriID,
                x.ad,
                x.soyad,
                x.adres,
                x.telefon,
                x.cinsiyet,
                x.dogumTarihi,
                x.kayitTarihi,
                x.paket,
                x.aciklama
                
            }).ToList();
            gridUyeBilgisi.DataSource = liste;
        }
        private void frmUyeBilgileri_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GymContext db = new GymContext();
            int uyeid = (int)gridUyeBilgisi.SelectedRows[0].Cells[0].Value;
            Musteri musteri = db.Musteri.Where(x => x.musteriID == uyeid).SingleOrDefault();
            if (musteri != null)
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Üye Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    db.Olcum.RemoveRange(musteri.Olcum);
                    db.Musteri.Remove(musteri);
                    db.SaveChanges();
                    Doldur();
                }
                else
                    MessageBox.Show("Silme işlemi iptal edildi");

            }
            else
                MessageBox.Show("Bulunamadı");
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUyeDuzenle frm = new frmUyeDuzenle();
            GymContext db = new GymContext();
            int uyeid = (int)gridUyeBilgisi.SelectedRows[0].Cells[0].Value;
            frm.ad = gridUyeBilgisi.CurrentRow.Cells[1].Value.ToString();
            frm.soyad = gridUyeBilgisi.CurrentRow.Cells[2].Value.ToString();
            frm.adres = gridUyeBilgisi.CurrentRow.Cells[3].Value.ToString();
            frm.tel = gridUyeBilgisi.CurrentRow.Cells[4].Value.ToString();
            frm.aciklama = gridUyeBilgisi.CurrentRow.Cells[9].Value.ToString();
            frm.paket = gridUyeBilgisi.CurrentRow.Cells[8].Value.ToString();
            Musteri musteri = db.Musteri.Where(x => x.musteriID == uyeid).SingleOrDefault();
            

            DialogResult sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
                Doldur();
        }

        private void ölçüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GymContext db = new GymContext();
            int uyeid = (int)gridUyeBilgisi.SelectedRows[0].Cells[0].Value;
            Olcum olcum = db.Olcum.Where(x => x.musteriID == uyeid).SingleOrDefault();
            frmOlcu frm = new frmOlcu();

            frm.uyeID = uyeid;

            DialogResult sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
                Doldur();

        }

        private void gridUyeBilgisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
