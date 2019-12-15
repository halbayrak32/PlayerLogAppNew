namespace PlayerLogApp
{
    partial class frmEkle
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
            this.cbTakimlar = new System.Windows.Forms.ComboBox();
            this.cbBolgeler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pnlTextBox = new System.Windows.Forms.Panel();
            this.txtBoy = new PlayerLogApp.CustomControls.MyTextBox();
            this.txtNo = new PlayerLogApp.CustomControls.MyTextBox();
            this.txtSoyad = new PlayerLogApp.CustomControls.MyTextBox();
            this.txtAd = new PlayerLogApp.CustomControls.MyTextBox();
            this.txtOvr = new PlayerLogApp.CustomControls.MyTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTakimlar
            // 
            this.cbTakimlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTakimlar.FormattingEnabled = true;
            this.cbTakimlar.Location = new System.Drawing.Point(211, 18);
            this.cbTakimlar.Name = "cbTakimlar";
            this.cbTakimlar.Size = new System.Drawing.Size(141, 21);
            this.cbTakimlar.TabIndex = 0;
            // 
            // cbBolgeler
            // 
            this.cbBolgeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBolgeler.FormattingEnabled = true;
            this.cbBolgeler.Location = new System.Drawing.Point(211, 53);
            this.cbBolgeler.Name = "cbBolgeler";
            this.cbBolgeler.Size = new System.Drawing.Size(141, 21);
            this.cbBolgeler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Takımlar";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Coral;
            this.btnSave.BackgroundImage = global::PlayerLogApp.Properties.Resources.saveicon1;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(174, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 61);
            this.btnSave.TabIndex = 11;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::PlayerLogApp.Properties.Resources.exit_icons_20;
            this.btnExit.Location = new System.Drawing.Point(290, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 61);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(95, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bölgeler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(95, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Overall";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(95, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(94, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(95, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Boy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(94, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Numara";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(94, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Doğum Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Indigo;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(29, 354);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Indigo;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(29, 383);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "VAZGEÇ";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Visible = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlTextBox.Controls.Add(this.txtBoy);
            this.pnlTextBox.Controls.Add(this.txtNo);
            this.pnlTextBox.Controls.Add(this.txtSoyad);
            this.pnlTextBox.Controls.Add(this.txtAd);
            this.pnlTextBox.Controls.Add(this.txtOvr);
            this.pnlTextBox.Location = new System.Drawing.Point(198, 80);
            this.pnlTextBox.Name = "pnlTextBox";
            this.pnlTextBox.Size = new System.Drawing.Size(167, 194);
            this.pnlTextBox.TabIndex = 15;
            // 
            // txtBoy
            // 
            this.txtBoy.CalismaModu = PlayerLogApp.CustomControls.WorkMode.Rakam;
            this.txtBoy.Location = new System.Drawing.Point(14, 162);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(141, 20);
            this.txtBoy.TabIndex = 6;
            // 
            // txtNo
            // 
            this.txtNo.CalismaModu = PlayerLogApp.CustomControls.WorkMode.Rakam;
            this.txtNo.Location = new System.Drawing.Point(14, 125);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(141, 20);
            this.txtNo.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.CalismaModu = PlayerLogApp.CustomControls.WorkMode.Harf;
            this.txtSoyad.Location = new System.Drawing.Point(14, 87);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(141, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.CalismaModu = PlayerLogApp.CustomControls.WorkMode.Harf;
            this.txtAd.Location = new System.Drawing.Point(14, 49);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(141, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtOvr
            // 
            this.txtOvr.CalismaModu = PlayerLogApp.CustomControls.WorkMode.Rakam;
            this.txtOvr.Location = new System.Drawing.Point(14, 12);
            this.txtOvr.Name = "txtOvr";
            this.txtOvr.Size = new System.Drawing.Size(141, 20);
            this.txtOvr.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(29, 415);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(129, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Resim";
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(211, 331);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(106, 20);
            this.txtResim.TabIndex = 18;
            // 
            // btnResim
            // 
            this.btnResim.Location = new System.Drawing.Point(326, 329);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(27, 23);
            this.btnResim.TabIndex = 19;
            this.btnResim.Text = "...";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(424, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlayerLogApp.Properties.Resources.PlayerLogImage;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.txtResim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.pnlTextBox);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBolgeler);
            this.Controls.Add(this.cbTakimlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEkle";
            this.Load += new System.EventHandler(this.frmEkle_Load);
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel pnlTextBox;
        public System.Windows.Forms.Button btnTemizle;
        public System.Windows.Forms.ComboBox cbTakimlar;
        public System.Windows.Forms.ComboBox cbBolgeler;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnSil;
        public CustomControls.MyTextBox txtOvr;
        public CustomControls.MyTextBox txtAd;
        public CustomControls.MyTextBox txtSoyad;
        public CustomControls.MyTextBox txtNo;
        public CustomControls.MyTextBox txtBoy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox txtResim;
        public System.Windows.Forms.Button btnResim;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

