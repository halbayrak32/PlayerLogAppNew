using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerLogApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void menuOyuncuKayit_Click(object sender, EventArgs e)
        {
            frmEkle frm = new frmEkle();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        private void menuOyuncuAra_Click(object sender, EventArgs e)
        {
            frmOyuncuAra frm = new frmOyuncuAra();
            frm.MdiParent = this.MdiParent;
            frm.Show();
           
        }                
        
        private void menuOyuncuListe_Click(object sender, EventArgs e)
        {
            frmOyuncuListe frm = new frmOyuncuListe();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void menuTakimKayit_Click(object sender, EventArgs e)
        {
            frmTakim frm = new frmTakim();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void menuTakimListe_Click(object sender, EventArgs e)
        {
            frmTakimListe frm = new frmTakimListe();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }


    }
}
