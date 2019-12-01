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
            TakimBL tb = new TakimBL();
            cbTakimlar.DataSource = tb.TakimListesi();
            cbTakimlar.DisplayMember = "TAKIMADI";
            cbTakimlar.ValueMember = "ID";
            tb.Dispose();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Bul(int.Parse(txtOyuncuNo.Text.Trim()), (int)cbTakimlar.SelectedValue);

            if (cbTakimlar.SelectedIndex == 0)
            {
                MessageBox.Show("Takım Seçiniz");
                return;
            }

        }
        private void Bul(int numara,int takımId)
        {
            Oyuncu oyn = null;
            OyuncuBL obl = new OyuncuBL();
            oyn = obl.OyuncuBul(numara,takımId);
            
            if (oyn != null)
            {                
                frm.txtOvr.Text = oyn.Overall;
                frm.txtAd.Text = oyn.Ad;
                frm.txtSoyad.Text = oyn.Soyad;
                frm.txtNo.Text = oyn.Numara;
                frm.txtBoy.Text = oyn.Boy;
                frm.cbBolgeler.SelectedValue = oyn.BOLGEID;
                frm.cbTakimlar.SelectedValue = oyn.TAKIMID;
                frm.dateTimePicker1.Value = Convert.ToDateTime(oyn.DogumTarihi.ToString());
                frm.ID = oyn.Oyun;
                frm.btnTemizle.Visible = true;
                frm.btnSave.BackgroundImage = global::PlayerLogApp.Properties.Resources.updateicon;
                frm.btnSil.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Oyuncu Bulunamadı");
            }
        }
    }
}
