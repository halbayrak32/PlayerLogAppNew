﻿using PlayerLog.BLL;
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
        public frmOyuncuListe()
        {
            InitializeComponent();
        }

        private void frmOyuncuListe_Load(object sender, EventArgs e)
        {
            OyuncuBL ob = new OyuncuBL();
            dataGridView1.DataSource = ob.OyuncuTablosu();
        }
    }
}