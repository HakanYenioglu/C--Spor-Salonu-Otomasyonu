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
    public partial class frmKullaniciGirisi : Form
    {
        public frmKullaniciGirisi()
        {
            InitializeComponent();
        }
        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            GymContext db = new GymContext();
            Kullanici kullanici = db.Kullanici.Where(x => x.kullaniciAdi == txtKullanici.Text && x.sifre == txtSifre.Text).SingleOrDefault();
            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            else
            {
                Program.kullanici = kullanici;
                if (kullanici.Yetki.yetkiID == 1)
                {
                    frmAnasayfa ana = new frmAnasayfa();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    frmUyeBilgileri uye = new frmUyeBilgileri();
                    uye.Show();
                    this.Hide();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
             txtKullanici.Text="";
             txtSifre.Text="";
        }
    }
}
