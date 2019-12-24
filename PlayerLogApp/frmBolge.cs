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
    public partial class frmBolge : Form
    {
        public frmBolge()
        {
            InitializeComponent();
        }
        PlayerLogDBEntities db = new PlayerLogDBEntities();

        private void btnBul_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = db.tbl_bolgeler.ToList();
            dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[4].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tbl_bolgeler b = new tbl_bolgeler();
            b.BOLGE = myTextBox1.Text;
            db.tbl_bolgeler.Add(b);
            db.SaveChanges();
            MessageBox.Show("Bölge Adı Başarıyla Eklendi");


            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBolgeID.Text);
            var x = db.tbl_bolgeler.Find(id);
            db.tbl_bolgeler.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Bölge Adı Başarıyla Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBolgeID.Text);
            var x = db.tbl_bolgeler.Find(id);
            x.BOLGE = myTextBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Bölge Adı Başarıyla Güncellendi");
        }
    }
}
