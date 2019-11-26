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
            this.txtOyuncuNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyuncu Bilgisi Giriniz:";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(58, 82);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Search";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtOyuncuNo
            // 
            this.txtOyuncuNo.Location = new System.Drawing.Point(48, 56);
            this.txtOyuncuNo.Name = "txtOyuncuNo";
            this.txtOyuncuNo.Size = new System.Drawing.Size(100, 20);
            this.txtOyuncuNo.TabIndex = 2;
            // 
            // frmOyuncuAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 141);
            this.Controls.Add(this.txtOyuncuNo);
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
        public System.Windows.Forms.TextBox txtOyuncuNo;
    }
}