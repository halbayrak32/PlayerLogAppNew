namespace PlayerLogApp
{
    partial class frmTakimListe
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
            this.clmTakimAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEyaletAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTakimAdi,
            this.clmEyaletAdi,
            this.clmResim});
            this.dataGridView1.Location = new System.Drawing.Point(69, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(357, 367);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET\r\n";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // clmTakimAdi
            // 
            this.clmTakimAdi.DataPropertyName = "TAKIMADI";
            this.clmTakimAdi.HeaderText = "Takım Adı";
            this.clmTakimAdi.Name = "clmTakimAdi";
            // 
            // clmEyaletAdi
            // 
            this.clmEyaletAdi.DataPropertyName = "EYALETADI";
            this.clmEyaletAdi.HeaderText = "Eyalet Adı";
            this.clmEyaletAdi.Name = "clmEyaletAdi";
            // 
            // clmResim
            // 
            this.clmResim.DataPropertyName = "RESIM";
            this.clmResim.HeaderText = "Resim";
            this.clmResim.Name = "clmResim";
            // 
            // frmTakimListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlayerLogApp.Properties.Resources.basketball_team_information_icons_87018;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 428);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "frmTakimListe";
            this.Text = "frmTakimListe";
            this.Load += new System.EventHandler(this.frmTakimListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTakimAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEyaletAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResim;
    }
}