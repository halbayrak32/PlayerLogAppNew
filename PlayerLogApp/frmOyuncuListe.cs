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
    public partial class frmOyuncuListe : Form
    {
        DataTable dt;
        public frmOyuncuListe()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;  
            
                       
        }
        

        private void frmOyuncuListe_Load(object sender, EventArgs e)
        {
            OyuncuBL ob = new OyuncuBL();
            dataGridView1.DataSource = ob.OyuncuTablosu();
            dt = ob.OyuncuTablosu();
            dataGridView1.DataSource = dt;
           
          

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                //dataGridView1.Rows[i].Cells["clmResim"].Value = Image.FromFile(dt.Rows[i]["RESIM"].ToString());
                dataGridView1.Rows[i].Cells["clmResim"].Value = Image.FromFile(dataGridView1.Rows[i].Cells["clmRsmPath"].Value.ToString());
            }
            
                                             

            ob.Dispose();

            TakimBL tb = new TakimBL();
            clmTakim.DataSource = tb.TakimListesi();
            clmTakim.DisplayMember = "TAKIMADI";
            clmTakim.ValueMember = "ID";
            clmTakim.DataSource = tb.TakimListesi();
            tb.Dispose();

            BolgeBL bb = new BolgeBL();
            clmBolge.DataSource = bb.BolgeListesi();
            clmBolge.DisplayMember = "BOLGE";
            clmBolge.ValueMember = "ID";
            clmBolge.DataSource = bb.BolgeListesi();
            bb.Dispose();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OyuncuBL ob = new OyuncuBL();

            foreach (DataRow item in dt.Rows)
            {
                Oyuncu oyn = new Oyuncu();

                if (item.RowState != DataRowState.Deleted)
                {
                    oyn.TAKIMID = (int)item["TAKIMID"];
                    oyn.BOLGEID = (int)item["BOLGEID"];
                    oyn.Overall = item["OVERALL"].ToString();
                    oyn.Ad = item["AD"].ToString();
                    oyn.Soyad = item["SOYAD"].ToString();
                    oyn.Numara = item["NUMARA"].ToString();
                    oyn.Boy = item["BOY"].ToString();
                    oyn.DogumTarihi = Convert.ToDateTime (item["DOGUMTARIHI"].ToString());
                    oyn.Resim = item["RESIM"].ToString();

                    



                }

                switch (item.RowState)
                {                    
                    case DataRowState.Added:
                        ob.OyuncuEkle(oyn);
                        break;
                    case DataRowState.Deleted:
                        ob.OyuncuSil(Convert.ToInt32(item[0, DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        oyn.Oyun = (int)item["ID"];
                        ob.OyuncuGuncelle(oyn);
                        break;
                    default:
                        break;
                }

            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void txtArat_TextChanged(object sender, EventArgs e)
        {
         
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "AD", txtArat.Text);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                //dataGridView1.Rows[i].Cells["clmResim"].Value = Image.FromFile(dt.Rows[i]["RESIM"].ToString());
                dataGridView1.Rows[i].Cells["clmResim"].Value = Image.FromFile(dataGridView1.Rows[i].Cells["clmRsmPath"].Value.ToString());
            }
        }

    }
}
