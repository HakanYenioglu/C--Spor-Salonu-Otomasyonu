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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        private void btnEgitmenBilg_Click_1(object sender, EventArgs e)
        {
            frmEgitmenBilgileri egitmenbilgi = new frmEgitmenBilgileri();
            egitmenbilgi.Show();
        }

        private void btnUrunSatis_Click_1(object sender, EventArgs e)
        {
            frmUrunSatis urunsatis = new frmUrunSatis();
            urunsatis.Show();
        }

        private void lblCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUyeBilg_Click(object sender, EventArgs e)
        {
            frmUyeBilgileri uyebil = new frmUyeBilgileri();
            uyebil.Show();
        }
    }
}
