using PlayerLog.BLL;
using PlayerLog.MODEL;
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
    public partial class frmTakimAra : Form
    {
        frmTakim frm1;
        public frmTakimAra()
        {
            InitializeComponent();
        }
        public frmTakimAra(frmTakim frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void frmTakimAra_Load(object sender, EventArgs e)
        {
            TakimBL tb = new TakimBL();
            tb.Dispose();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Bul( txtTakimAra.Text.Trim() , txtEylAra.Text.Trim() );
        }

        private void Bul(string takımAdi, string eyaletAdi)
        {
            Takim tkm = null;
            TakimBL obl = new TakimBL();
            tkm = obl.TakimBul(takımAdi,eyaletAdi);

            if (tkm != null)
            {
                frm1.txtTakim.Text = tkm.TAKIMADI;
                frm1.txtEyl.Text = tkm.EYALETADI;
                frm1.TAKIMID = tkm.TAKIMID;
                frm1.btnVazgec.Visible = true;
                frm1.btnEkle.Text = "Güncelle";
                frm1.btnSil.Visible = true;
                

            }
            else
            {
                MessageBox.Show("Takım Bulunamadı");
            }
        }
    }
}
