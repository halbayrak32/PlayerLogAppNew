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
        frmTakim frm;
        public frmTakimAra()
        {
            InitializeComponent();
        }
        public frmTakimAra(frmTakim frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frmTakimAra_Load(object sender, EventArgs e)
        {
            TakimBL tb = new TakimBL();
            tb.Dispose();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Bul((txttakim.Text.Trim()), (txteyl.Text.Trim()));
        }

        private void Bul(string takımAdi, string eyaletAdi)
        {
            Takim tkm = null;
            TakimBL obl = new TakimBL();
            tkm = obl.TakimBul(takımAdi,eyaletAdi);

            if (tkm != null)
            {
                //frm.txttakim = tkm.TAKIMADI;
                //frm.txteyl = tkm.EYALETADI;
                frm.TAKIMID = tkm.TAKIMID;
                frm.btnSil.Visible = true;

            }
            else
            {
                MessageBox.Show("Takım Bulunamadı");
            }
        }
    }
}
