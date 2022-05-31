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
    public partial class frmEgitmenBilgileri : Form
    {
        public frmEgitmenBilgileri()
        {
            InitializeComponent();
        }

        public Kullanici kullanici;
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Doldur()
        {

            GymContext db = new GymContext();
            var liste = db.Kullanici.Where(x => x.yetkiID==2).Select(x => new
            {
                x.kullaniciID,
                x.ad,
                x.soyad,
                x.kullaniciAdi,
                x.sifre,
                x.telefon,
                x.adres, 
                x.alan,
                x.TCno,
                x.cinsiyet,
                x.aktifMi
            }).ToList();
            gridEgitmenBilgisi.DataSource = liste;
        }

        private void frmEgitmenBilgileri_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GymContext db = new GymContext();
            int uyeid = (int)gridEgitmenBilgisi.SelectedRows[0].Cells[0].Value;
            Kullanici kullanici = db.Kullanici.Where(x => x.kullaniciID == uyeid).SingleOrDefault();
            frmEgitmenEkle uye = new frmEgitmenEkle();

            DialogResult sonuc = uye.ShowDialog();
            if (sonuc == DialogResult.OK)
                Doldur();
            else
                MessageBox.Show("Hata var ");
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GymContext db = new GymContext();
            int uyeid = (int)gridEgitmenBilgisi.SelectedRows[0].Cells[0].Value;
            Kullanici kullanici = db.Kullanici.Where(x => x.kullaniciID == uyeid).SingleOrDefault();
            frmEgitmenDuzenle uye = new frmEgitmenDuzenle();

            DialogResult sonuc = uye.ShowDialog();
            if (sonuc == DialogResult.OK)
                Doldur();
            else
                MessageBox.Show("Hata var ");
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GymContext db = new GymContext();
            int uyeid = (int)gridEgitmenBilgisi.SelectedRows[0].Cells[0].Value;
            Kullanici kullanici = db.Kullanici.Where(x => x.kullaniciID == uyeid).SingleOrDefault();
            if (kullanici != null) // bulunduysa sil
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Üye Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    db.Kullanici.Remove(kullanici);
                    db.SaveChanges();
                    Doldur();
                }
                else
                    MessageBox.Show("Silme işlemi iptal edildi");

            }
            else
                MessageBox.Show("Bulunamadı");
        }
    }
}
