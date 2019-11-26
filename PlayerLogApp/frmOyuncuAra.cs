using PlayerLog.MODEL;
using PlayerLog.BLL;
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
    public partial class frmOyuncuAra : Form
    {
        frmEkle frm;
        public frmOyuncuAra()
        {
            InitializeComponent();
        }

        public frmOyuncuAra(frmEkle frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frmOyuncuAra_Load(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Bul(int.Parse(txtOyuncuNo.Text.Trim()));
        }
        private void Bul(int numara)
        {
            Oyuncular oyn = null;
            OyuncuBL obl = new OyuncuBL();
            oyn = obl.OyuncuBul(numara);
            
            if (oyn != null)
            {                
                frm.txtOvr.Text = oyn.Overall;
                frm.txtAd.Text = oyn.Ad;
                frm.txtSoyad.Text = oyn.Soyad;
                frm.txtNo.Text = oyn.Numara;
                frm.txtBoy.Text = oyn.Boy;
                frm.ID = oyn.Oyuncu;
                frm.btnTemizle.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Oyuncu Bulunamadı");
            }
        }
    }
}
