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
    public partial class frmOlcuDuzenle : Form
    {
        public frmOlcuDuzenle()
        {
            InitializeComponent();
        }
        public string boy, kilo, omuz, kol, bel, gogus, boyun, ustbacak, altbacak, kalca, tarih;

        public Olcum olcumm;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            GymContext db = new GymContext();
            Olcum olcum = db.Olcum.Where(x => x.musteriID == olcumm.musteriID).SingleOrDefault();
            olcum.boy = Convert.ToInt32(txtBoy.Text);
            olcum.kilo = Convert.ToInt32(txtKilo.Text);
            olcum.omuz = Convert.ToInt32(txtOmuz.Text);
            olcum.kol = Convert.ToInt32(txtKol.Text);
            olcum.bel = Convert.ToInt32(txtBel.Text);
            olcum.gogus = Convert.ToInt32(txtGogus.Text);
            olcum.boyun = Convert.ToInt32(txtBoyun.Text);
            olcum.ustBacak = Convert.ToInt32(txtUstBacak.Text);
            olcum.altBacak = Convert.ToInt32(txtAltBacak.Text);
            olcum.kalca = Convert.ToInt32(txtKalca.Text);

            db.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOlcuDuzenle_Load(object sender, EventArgs e)
        {
            txtBoy.Text = boy;
            txtKilo.Text = kilo;
            txtOmuz.Text = omuz;
            txtKol.Text = kol;
            txtBel.Text = bel;
            txtGogus.Text = gogus;
            txtBoyun.Text = boyun;
            txtUstBacak.Text = ustbacak;
            txtAltBacak.Text = altbacak;
            txtKalca.Text = kalca;
        }
    }
}
