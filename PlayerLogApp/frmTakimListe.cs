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
    public partial class frmTakimListe : Form
    {
        public frmTakimListe()
        {
            InitializeComponent();
        }

        private void frmTakimListe_Load(object sender, EventArgs e)
        {
            TakimBL tb = new TakimBL();
            dataGridView1.DataSource = tb.TakimTablosu();
        }
    }
}
