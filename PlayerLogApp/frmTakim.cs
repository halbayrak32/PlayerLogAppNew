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
    public partial class frmTakim : Form
    {
        frmTakimAra frmTakimAra;
        Takim takim;
        public int TAKIMID = 0;

        public frmTakim()
        {
            InitializeComponent();
        }

        private void frmTakim_Load(object sender, EventArgs e)
        {
            TakimBL tb = new TakimBL();


            tb.Dispose();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            TakimBL obl = new TakimBL();
            try
            {
                takim = new Takim();

                takim.TAKIMID = TAKIMID;
                takim.TAKIMADI = txtTakim.Text.Trim();
                takim.EYALETADI = txtEyl.Text.Trim();
                takim.Resim = txtResim.Text.Trim();




                if (TAKIMID == 0)
                {
                    MessageBox.Show(obl.TakimEkle(takim) ? "Ekleme Başarılı" : "Ekleme Başarısız");
                }
                else
                {
                    MessageBox.Show(obl.TakimGuncelle(takim) ? "Güncelleme Başarılı" : "Güncelleme Başarısız");
                }
            }
            //catch (SqlException ex)
            //{
            //switch (ex.Number)
            //{
            //    case 245:
            //        MessageBox.Show("Numara girişinde hata!!!");
            //        break;
            //    default:
            //        MessageBox.Show("Veritabanı hatası!!!");
            //        break;
            //}
            //}
            catch (Exception)
            {
                //MessageBox.Show("Bir HATA Oluştu!!!");
                throw;
            }
            finally
            {
                obl.Dispose();
                Temizle();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmTakimAra = new frmTakimAra(this);
            frmTakimAra.Show();
           
        }


        void Temizle()
        {
            foreach (Control item in this.Controls["pnltextBox"].Controls)
            {
                item.Text = string.Empty;
            }
            TAKIMID = 0;
            btnVazgec.Visible = false;
            btnEkle.Text = "Ekle";
            btnSil.Visible = false;
            txtResim.Text = null;
            pictureBox1.Visible = false;

        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
            //frmTakimAra.Visible = false;



        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Silme Onayı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cvp == DialogResult.No) return;

            TakimBL obl = new TakimBL();
            try
            {
                if (obl.TakimSil(TAKIMID))
                {
                    MessageBox.Show("Silme İşlemi Başarılı");
                }
                else
                {
                    MessageBox.Show("Silme İşlemi Hatalı!");
                }
                Temizle();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                obl.Dispose();
            }
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
            pictureBox1.Visible = true;
           
        }
    }
}
