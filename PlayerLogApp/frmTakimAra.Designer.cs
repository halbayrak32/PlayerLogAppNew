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
            this.btnAra = new System.Windows.Forms.Button();
            this.txtEylAra = new PlayerLogApp.CustomControls.MyTextBox();
            this.txtTakimAra = new PlayerLogApp.CustomControls.MyTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eyalet Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Takım Adı:";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Crimson;
            this.btnAra.ForeColor = System.Drawing.Color.Transparent;
            this.btnAra.Location = new System.Drawing.Point(113, 134);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtEylAra
            // 
            this.txtEylAra.CalismaModu = PlayerLogApp.CustomControls.WorkMode.Harf;
            this.txtEylAra.Location = new System.Drawing.Point(88, 17);
            this.txtEylAra.Name = "txtEylAra";
            this.txtEylAra.Size = new System.Drawing.Size(100, 20);
            this.txtEylAra.TabIndex = 6;
            // 
            // txtTakimAra
            // 
            this.txtTakimAra.CalismaModu = PlayerLogApp.CustomControls.WorkMode.Harf;
            this.txtTakimAra.Location = new System.Drawing.Point(88, 62);
            this.txtTakimAra.Name = "txtTakimAra";
            this.txtTakimAra.Size = new System.Drawing.Size(100, 20);
            this.txtTakimAra.TabIndex = 7;
            // 
            // frmTakimAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(198, 169);
            this.Controls.Add(this.txtTakimAra);
            this.Controls.Add(this.txtEylAra);
            this.Controls.Add(this.btnAra);
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
        public System.Windows.Forms.Button btnAra;
        public CustomControls.MyTextBox txtEylAra;
        public CustomControls.MyTextBox txtTakimAra;
    }
}