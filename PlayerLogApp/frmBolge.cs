using PlayerLog.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerLogApp
{
    public partial class frmBolge : Form
    {
        public frmBolge()
        {
            InitializeComponent();
            //dataGridView1.AutoGenerateColumns = false;
        }
        

        private void btnBul_Click(object sender, EventArgs e)
        {
            PlayerLogDBEntities db = new PlayerLogDBEntities();
            dataGridView1.DataSource = db.tbl_bolgeler.ToList();
             dataGridView1.Columns["tbl_main"].Visible = false;
            dataGridView1.Columns["tbl_oyuncu"].Visible = false;
            db.Dispose();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            PlayerLogDBEntities db = new PlayerLogDBEntities();
            tbl_bolgeler b = new tbl_bolgeler();
            b.BOLGE = myTextBox1.Text;
            db.tbl_bolgeler.Add(b);
            db.SaveChanges();
            db.Dispose();
            Temizle();
        }

        private void Temizle()
        {
            txtBolgeID.Text = String.Empty;
            myTextBox1.Text = String.Empty;
            dataGridView1.ClearSelection();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show("Silme İşlemini Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    PlayerLogDBEntities db = new PlayerLogDBEntities();
                    int id = Convert.ToInt32(txtBolgeID.Text);
                    var x = db.tbl_bolgeler.Find(id);
                    db.tbl_bolgeler.Remove(x);
                    db.SaveChanges();
                    db.Dispose();
                    Temizle();
            } 
                
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            PlayerLogDBEntities db = new PlayerLogDBEntities();
            int id = Convert.ToInt32(txtBolgeID.Text);
            var x = db.tbl_bolgeler.Find(id);
            x.BOLGE = myTextBox1.Text;
            db.SaveChanges();
            db.Dispose();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBolgeID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            myTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
