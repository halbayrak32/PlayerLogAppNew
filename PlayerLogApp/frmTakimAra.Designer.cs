namespace PlayerLogApp
{
    partial class frmTakimAra
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
            this.txteyl = new System.Windows.Forms.TextBox();
            this.txttakim = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eyalet Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Takım Adı:";
            // 
            // txteyl
            // 
            this.txteyl.Location = new System.Drawing.Point(88, 39);
            this.txteyl.Name = "txteyl";
            this.txteyl.Size = new System.Drawing.Size(100, 20);
            this.txteyl.TabIndex = 3;
            // 
            // txttakim
            // 
            this.txttakim.Location = new System.Drawing.Point(88, 85);
            this.txttakim.Name = "txttakim";
            this.txttakim.Size = new System.Drawing.Size(100, 20);
            this.txttakim.TabIndex = 4;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(103, 146);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmTakimAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 230);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txttakim);
            this.Controls.Add(this.txteyl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTakimAra";
            this.Text = "frmTakimAra";
            this.Load += new System.EventHandler(this.frmTakimAra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txteyl;
        public System.Windows.Forms.TextBox txttakim;
        public System.Windows.Forms.Button btnAra;
    }
}