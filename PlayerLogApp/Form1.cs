using PlayerLog.BLL;
using PlayerLog.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerLogApp
{
    public partial class frmEkle : Form
    {

        //SqlConnection connection = null;

        Oyuncu oyuncu;
        public int ID = 0;
        public frmEkle()
        {
            InitializeComponent();

        }
        private void frmEkle_Load(object sender, EventArgs e)
        {
            //Oyuncular o = new Oyuncular();
            //o.OyuncuBilgileriniGetir(cbBolgeler);
            //o.OyuncuBilgileriniGetir(cbTakimlar);
            TakimBL tb = new TakimBL();
            cbTakimlar.DataSource = tb.TakimListesi();
            cbTakimlar.DisplayMember = "TAKIMADI";
            cbTakimlar.ValueMember = "ID";
            tb.Dispose();

            BolgeBL bb = new BolgeBL();
            cbBolgeler.DataSource = bb.BolgeListesi();
            cbBolgeler.DisplayMember = "BOLGE";
            cbBolgeler.ValueMember = "ID";
            bb.Dispose();
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            if (cbTakimlar.SelectedIndex == 0)
            {
                MessageBox.Show("Takım Seçiniz");
                return;
            }

            if (cbBolgeler.SelectedIndex == 0)
            {
                MessageBox.Show("Bölge Seçiniz");
                return;
            }

            OyuncuBL obl = new OyuncuBL();
            try
            {
                oyuncu = new Oyuncu();
                oyuncu.Oyun = ID;
                oyuncu.TAKIMID = (int)cbTakimlar.SelectedValue;
                oyuncu.BOLGEID = (int)cbBolgeler.SelectedValue;
                oyuncu.Overall = txtOvr.Text.Trim();
                oyuncu.Ad = txtAd.Text.Trim();
                oyuncu.Soyad = txtSoyad.Text.Trim();
                oyuncu.Numara = txtNo.Text.Trim();
                oyuncu.Boy = txtBoy.Text.Trim();
                oyuncu.DogumTarihi = (DateTime)dateTimePicker1.Value;
                oyuncu.Resim = txtResim.Text.Trim();


                if (ID == 0)
                {
                    MessageBox.Show(obl.OyuncuEkle(oyuncu) ? "Ekleme Başarılı" : "Ekleme Başarısız");
                }
                else
                {
                    MessageBox.Show(obl.OyuncuGuncelle(oyuncu) ? "Güncelleme Başarılı" : "Güncelleme Başarısız");
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

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmOyuncuAra frmOyuncuAra = new frmOyuncuAra(this);
            frmOyuncuAra.Show();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            this.btnSave.BackgroundImage = global::PlayerLogApp.Properties.Resources.saveicon1;
            pictureBox1.Image = null;

        }

        void Temizle()
        {
            foreach (Control item in this.Controls["pnltextBox"].Controls)
            {

                item.Text = string.Empty;

            }
            cbTakimlar.SelectedIndex = 0;
            cbBolgeler.SelectedIndex = 0;
            ID = 0;
            btnTemizle.Visible = false;
            btnSil.Visible = false;



        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Silme Onayı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cvp == DialogResult.No) return;

            OyuncuBL obl = new OyuncuBL();
            try
            {
                if (obl.OyuncuSil(ID))
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
        }
    }
}

