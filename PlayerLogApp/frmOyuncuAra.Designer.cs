namespace PlayerLogApp
{
    partial class frmOyuncuAra
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
            this.btnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTakimlar = new System.Windows.Forms.ComboBox();
            this.txtOyuncuNo = new PlayerLogApp.CustomControls.MyTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma Numarası Giriniz:";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Black;
            this.btnAra.ForeColor = System.Drawing.Color.Transparent;
            this.btnAra.Location = new System.Drawing.Point(61, 143);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Takım Seçiniz:";
            // 
            // cbTakimlar
            // 
            this.cbTakimlar.FormattingEnabled = true;
            this.cbTakimlar.Location = new System.Drawing.Point(12, 25);
            this.cbTakimlar.Name = "cbTakimlar";
            this.cbTakimlar.Size = new System.Drawing.Size(121, 21);
            this.cbTakimlar.TabIndex = 4;
            // 
            // txtOyuncuNo
            // 
            this.txtOyuncuNo.CalismaModu = PlayerLogApp.CustomControls.WorkMode.Rakam;
            this.txtOyuncuNo.Location = new System.Drawing.Point(12, 93);
            this.txtOyuncuNo.Name = "txtOyuncuNo";
            this.txtOyuncuNo.Size = new System.Drawing.Size(121, 20);
            this.txtOyuncuNo.TabIndex = 5;
            // 
            // frmOyuncuAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(186, 178);
            this.Controls.Add(this.txtOyuncuNo);
            this.Controls.Add(this.cbTakimlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label1);
            this.Name = "frmOyuncuAra";
            this.Text = "frmOyuncuAra";
            this.Load += new System.EventHandler(this.frmOyuncuAra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        public CustomControls.MyTextBox txtOyuncuNo;
        public System.Windows.Forms.ComboBox cbTakimlar;
    }
}