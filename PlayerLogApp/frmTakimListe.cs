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
    public partial class frmTakimListe : Form
    {
        DataTable dt;
        public frmTakimListe()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

        }

        private void frmTakimListe_Load(object sender, EventArgs e)
        {
            TakimBL tb = new TakimBL();
            dataGridView1.DataSource = tb.TakimTablosu();
            dt = tb.TakimTablosu();
            dataGridView1.DataSource = dt;
            tb.Dispose();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TakimBL tb = new TakimBL();

            foreach (DataRow item in dt.Rows)
            {
                Takim tkm  = new Takim();

                if (item.RowState != DataRowState.Deleted)
                {
                    tkm.TAKIMADI = item["TAKIMADI"].ToString();
                    tkm.EYALETADI = item["EYALETADI"].ToString();
                    tkm.Resim = item["RESIM"].ToString();
                   


                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        tb.TakimEkle(tkm);
                        break;
                    case DataRowState.Deleted:
                        tb.TakimSil(Convert.ToInt32(item[0, DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        tkm.TAKIMID = (int)item["ID"];
                        tb.TakimGuncelle(tkm);
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
