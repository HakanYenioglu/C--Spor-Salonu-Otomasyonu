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
    public partial class frmOlcu : Form
    {
        public int uyeID;
        public frmOlcu()
        {
            InitializeComponent();
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Olcum olcum;

        private void Doldur()
        {
            GymContext db = new GymContext();
            var liste = db.Olcum.Select(x => new
            {
                x.musteriID,
                x.boy,
                x.kilo,
                x.omuz,
                x.kol,
                x.bel,
                x.gogus,
                x.boyun ,
                x.ustBacak,
                x.altBacak,
                x.kalca,
                x.tarih,
            }).ToList();
            gridOlcu.DataSource = liste;
        }

        private void frmOlcu_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void EkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOlcuEkle frm = new frmOlcuEkle();
            GymContext db = new GymContext();
            int uyeid = (int)gridOlcu.SelectedRows[0].Cells[0].Value;
            frm.boy = gridOlcu.CurrentRow.Cells[1].Value.ToString();
            frm.kilo = gridOlcu.CurrentRow.Cells[2].Value.ToString();
            frm.omuz = gridOlcu.CurrentRow.Cells[3].Value.ToString();
            frm.kol = gridOlcu.CurrentRow.Cells[4].Value.ToString();
            frm.bel = gridOlcu.CurrentRow.Cells[5].Value.ToString();
            frm.gogus= gridOlcu.CurrentRow.Cells[6].Value.ToString();
            frm.boyun = gridOlcu.CurrentRow.Cells[7].Value.ToString();
            frm.ustbacak = gridOlcu.CurrentRow.Cells[8].Value.ToString();
            frm.altbacak= gridOlcu.CurrentRow.Cells[9].Value.ToString();
            frm.kalca = gridOlcu.CurrentRow.Cells[10].Value.ToString();
            frm.tarih= gridOlcu.CurrentRow.Cells[11].Value.ToString();
            Musteri musteri = db.Musteri.Where(x => x.musteriID == uyeid).SingleOrDefault();


            DialogResult sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
                Doldur();
        }

        private void gridOlcu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOlcuDuzenle frm = new frmOlcuDuzenle();
            GymContext db = new GymContext();
            int uyeid = (int)gridOlcu.SelectedRows[0].Cells[0].Value;
            frm.boy = gridOlcu.CurrentRow.Cells[1].Value.ToString();
            frm.kilo = gridOlcu.CurrentRow.Cells[2].Value.ToString();
            frm.omuz = gridOlcu.CurrentRow.Cells[3].Value.ToString();
            frm.kol = gridOlcu.CurrentRow.Cells[4].Value.ToString();
            frm.bel = gridOlcu.CurrentRow.Cells[5].Value.ToString();
            frm.gogus = gridOlcu.CurrentRow.Cells[6].Value.ToString();
            frm.boyun = gridOlcu.CurrentRow.Cells[7].Value.ToString();
            frm.ustbacak = gridOlcu.CurrentRow.Cells[8].Value.ToString();
            frm.altbacak = gridOlcu.CurrentRow.Cells[9].Value.ToString();
            frm.kalca = gridOlcu.CurrentRow.Cells[10].Value.ToString();
            frm.tarih = gridOlcu.CurrentRow.Cells[11].Value.ToString();
            Musteri musteri = db.Musteri.Where(x => x.musteriID == uyeid).SingleOrDefault();


            DialogResult sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
                Doldur();
        }
    }
}
