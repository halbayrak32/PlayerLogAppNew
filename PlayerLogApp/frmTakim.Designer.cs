namespace PlayerLogApp
{
    partial class frmTakim
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pnlTextBox = new System.Windows.Forms.Panel();
            this.txtTakim = new PlayerLogApp.CustomControls.MyTextBox();
            this.txtEyl = new PlayerLogApp.CustomControls.MyTextBox();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eyalet Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(62, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Takım Adı:";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Crimson;
            this.btnAra.Location = new System.Drawing.Point(141, 185);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Crimson;
            this.btnEkle.Location = new System.Drawing.Point(141, 229);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Location = new System.Drawing.Point(141, 278);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlTextBox.Controls.Add(this.txtTakim);
            this.pnlTextBox.Controls.Add(this.txtEyl);
            this.pnlTextBox.Location = new System.Drawing.Point(125, 24);
            this.pnlTextBox.Name = "pnlTextBox";
            this.pnlTextBox.Size = new System.Drawing.Size(143, 100);
            this.pnlTextBox.TabIndex = 7;
            // 
            // txtTakim
            // 
            this.txtTakim.CalismaModu = PlayerLogApp.CustomControls.WorkMode.Harf;
            this.txtTakim.Location = new System.Drawing.Point(16, 70);
            this.txtTakim.Name = "txtTakim";
            this.txtTakim.Size = new System.Drawing.Size(100, 20);
            this.txtTakim.TabIndex = 10;
            // 
            // txtEyl
            // 
            this.txtEyl.CalismaModu = PlayerLogApp.CustomControls.WorkMode.Harf;
            this.txtEyl.Location = new System.Drawing.Point(16, 12);
            this.txtEyl.Name = "txtEyl";
            this.txtEyl.Size = new System.Drawing.Size(100, 20);
            this.txtEyl.TabIndex = 9;
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.Navy;
            this.btnVazgec.ForeColor = System.Drawing.Color.Transparent;
            this.btnVazgec.Location = new System.Drawing.Point(304, 302);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 8;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(293, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(62, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Resim";
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(141, 145);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(83, 20);
            this.txtResim.TabIndex = 23;
            // 
            // btnResim
            // 
            this.btnResim.Location = new System.Drawing.Point(230, 145);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(26, 20);
            this.btnResim.TabIndex = 24;
            this.btnResim.Text = "...";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmTakim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlayerLogApp.Properties.Resources.nba2k14_correct_team_logos_e1427375751434;
            this.ClientSize = new System.Drawing.Size(415, 337);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.txtResim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.pnlTextBox);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTakim";
            this.Text = "frmTakim";
            this.Load += new System.EventHandler(this.frmTakim_Load);
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnlTextBox;
        public System.Windows.Forms.Button btnAra;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnVazgec;
        public CustomControls.MyTextBox txtEyl;
        public CustomControls.MyTextBox txtTakim;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtResim;
        public System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}