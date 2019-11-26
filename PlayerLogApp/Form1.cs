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

        Oyuncular oyuncular;
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




        //#region Eski


        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PlayerLogDB;Integrated Security=SSPI";
        //    SqlCommand komut = new SqlCommand();
        //    komut.CommandText = "SELECT *FROM tbl_takimlar,tbl_bolgeler";           
        //    komut.Connection = connection;
        //    komut.CommandType = CommandType.Text;

        //    SqlDataReader dr;
        //    connection.Open();
        //    dr = komut.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        cbTakimlar.Items.Add(dr["TAKIMADI"]);
        //        cbBolgeler.Items.Add(dr["BOLGE"]);


        //    }
        //    connection.Close();

        //}
        //#endregion




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
                oyuncular = new Oyuncular();
                oyuncular.Oyuncu = ID;
                oyuncular.TAKIMID = (int)cbTakimlar.SelectedValue;
                oyuncular.BOLGEID = (int)cbBolgeler.SelectedValue;
                oyuncular.Overall = txtOvr.Text.Trim();
                oyuncular.Ad = txtAd.Text.Trim();
                oyuncular.Soyad = txtSoyad.Text.Trim();
                oyuncular.Numara =txtNo.Text.Trim();
                oyuncular.Boy = txtBoy.Text.Trim();
                oyuncular.DogumTarihi = (DateTime)dateTimePicker1.Value;
              
                if (ID == 0)
                {
                    MessageBox.Show(obl.OyuncuEkle(oyuncular) ? "Ekleme Başarılı" : "Ekleme Başarısız");
                }
                else
                {
                    MessageBox.Show(obl.OyuncuGuncelle(oyuncular) ? "Güncelleme Başarılı" : "Güncelleme Başarısız");
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

        private void cbTakimlar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmOyuncuAra frmOyuncuAra = new frmOyuncuAra(this);
           
            frmOyuncuAra.Show();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control item in this.Controls["pnltextBox"].Controls)
            {
                
                item.Text = string.Empty;

            }
            cbTakimlar.SelectedIndex = 0;
            cbBolgeler.SelectedIndex = 0;
            

        }

    }
}
//Update_v2.2.1