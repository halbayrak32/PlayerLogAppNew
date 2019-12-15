namespace PlayerLogApp
{
    partial class frmOyuncuListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.clmTakim = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmBolge = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmOverall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOyuncuAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTakim,
            this.clmBolge,
            this.clmOverall,
            this.clmOyuncuAdi,
            this.clmSoyad,
            this.clmNumara,
            this.clmBoy,
            this.clmDogumTarihi,
            this.clmResim});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(331, 323);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "KAYDET\r\n";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // clmTakim
            // 
            this.clmTakim.DataPropertyName = "TAKIMID";
            this.clmTakim.HeaderText = "Takım";
            this.clmTakim.Name = "clmTakim";
            this.clmTakim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmTakim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmBolge
            // 
            this.clmBolge.DataPropertyName = "BOLGEID";
            this.clmBolge.HeaderText = "Bölge";
            this.clmBolge.Name = "clmBolge";
            this.clmBolge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBolge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmOverall
            // 
            this.clmOverall.DataPropertyName = "OVERALL";
            this.clmOverall.HeaderText = "Overall";
            this.clmOverall.Name = "clmOverall";
            // 
            // clmOyuncuAdi
            // 
            this.clmOyuncuAdi.DataPropertyName = "AD";
            this.clmOyuncuAdi.HeaderText = "Oyuncu Adı";
            this.clmOyuncuAdi.Name = "clmOyuncuAdi";
            // 
            // clmSoyad
            // 
            this.clmSoyad.DataPropertyName = "SOYAD";
            this.clmSoyad.HeaderText = "Soyadı";
            this.clmSoyad.Name = "clmSoyad";
            // 
            // clmNumara
            // 
            this.clmNumara.DataPropertyName = "NUMARA";
            this.clmNumara.HeaderText = "Numara";
            this.clmNumara.Name = "clmNumara";
            // 
            // clmBoy
            // 
            this.clmBoy.DataPropertyName = "BOY";
            this.clmBoy.HeaderText = "Boy";
            this.clmBoy.Name = "clmBoy";
            // 
            // clmDogumTarihi
            // 
            this.clmDogumTarihi.DataPropertyName = "DOGUMTARIHI";
            this.clmDogumTarihi.HeaderText = "Doğum Tarihi";
            this.clmDogumTarihi.Name = "clmDogumTarihi";
            // 
            // clmResim
            // 
            this.clmResim.DataPropertyName = "RESIM";
            this.clmResim.HeaderText = "Resim";
            this.clmResim.Name = "clmResim";
            // 
            // frmOyuncuListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::PlayerLogApp.Properties.Resources.indir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmOyuncuListe";
            this.Text = "frmOyuncuListe";
            this.Load += new System.EventHandler(this.frmOyuncuListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmTakim;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmBolge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOverall;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOyuncuAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumara;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResim;
    }
}