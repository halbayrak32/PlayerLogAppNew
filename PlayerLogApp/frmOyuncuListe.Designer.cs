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
            this.label1 = new System.Windows.Forms.Label();
            this.txtArat = new System.Windows.Forms.TextBox();
            this.clmTakim = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmBolge = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmOverall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOyuncuAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResim = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(862, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(310, 296);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "KAYDET\r\n";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rosewood Std Regular", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARA";
            // 
            // txtArat
            // 
            this.txtArat.BackColor = System.Drawing.Color.Black;
            this.txtArat.ForeColor = System.Drawing.Color.Transparent;
            this.txtArat.Location = new System.Drawing.Point(83, 12);
            this.txtArat.Name = "txtArat";
            this.txtArat.Size = new System.Drawing.Size(645, 20);
            this.txtArat.TabIndex = 3;
            this.txtArat.TextChanged += new System.EventHandler(this.txtArat_TextChanged);
            // 
            // clmTakim
            // 
            this.clmTakim.DataPropertyName = "TAKIMID";
            this.clmTakim.FillWeight = 16.56259F;
            this.clmTakim.HeaderText = "Takım";
            this.clmTakim.Name = "clmTakim";
            this.clmTakim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmTakim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmBolge
            // 
            this.clmBolge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmBolge.DataPropertyName = "BOLGEID";
            this.clmBolge.FillWeight = 16.56259F;
            this.clmBolge.HeaderText = "Bölge";
            this.clmBolge.Name = "clmBolge";
            this.clmBolge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBolge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmOverall
            // 
            this.clmOverall.DataPropertyName = "OVERALL";
            this.clmOverall.FillWeight = 16.56259F;
            this.clmOverall.HeaderText = "Overall";
            this.clmOverall.Name = "clmOverall";
            // 
            // clmOyuncuAdi
            // 
            this.clmOyuncuAdi.DataPropertyName = "AD";
            this.clmOyuncuAdi.FillWeight = 16.56259F;
            this.clmOyuncuAdi.HeaderText = "Oyuncu Adı";
            this.clmOyuncuAdi.Name = "clmOyuncuAdi";
            // 
            // clmSoyad
            // 
            this.clmSoyad.DataPropertyName = "SOYAD";
            this.clmSoyad.FillWeight = 16.56259F;
            this.clmSoyad.HeaderText = "Soyadı";
            this.clmSoyad.Name = "clmSoyad";
            // 
            // clmNumara
            // 
            this.clmNumara.DataPropertyName = "NUMARA";
            this.clmNumara.FillWeight = 16.56259F;
            this.clmNumara.HeaderText = "Numara";
            this.clmNumara.Name = "clmNumara";
            // 
            // clmBoy
            // 
            this.clmBoy.DataPropertyName = "BOY";
            this.clmBoy.FillWeight = 16.56259F;
            this.clmBoy.HeaderText = "Boy";
            this.clmBoy.Name = "clmBoy";
            // 
            // clmDogumTarihi
            // 
            this.clmDogumTarihi.DataPropertyName = "DOGUMTARIHI";
            this.clmDogumTarihi.FillWeight = 16.56259F;
            this.clmDogumTarihi.HeaderText = "Doğum Tarihi";
            this.clmDogumTarihi.Name = "clmDogumTarihi";
            // 
            // clmResim
            // 
            this.clmResim.FillWeight = 16.65723F;
            this.clmResim.HeaderText = "Resim";
            this.clmResim.Name = "clmResim";
            this.clmResim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmResim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmOyuncuListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::PlayerLogApp.Properties.Resources.indir;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.txtArat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmOyuncuListe";
            this.Text = "frmOyuncuListe";
            this.Load += new System.EventHandler(this.frmOyuncuListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArat;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmTakim;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmBolge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOverall;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOyuncuAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumara;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDogumTarihi;
        private System.Windows.Forms.DataGridViewImageColumn clmResim;
    }
}