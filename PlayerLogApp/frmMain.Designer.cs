namespace PlayerLogApp
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOyuncuIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOyuncuKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOyuncuListe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTakimIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTakimKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTakimListe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOyuncuIslemleri,
            this.menuTakimIslemleri});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOyuncuIslemleri
            // 
            this.menuOyuncuIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOyuncuKayit,
            this.menuOyuncuListe});
            this.menuOyuncuIslemleri.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuOyuncuIslemleri.Name = "menuOyuncuIslemleri";
            this.menuOyuncuIslemleri.Size = new System.Drawing.Size(114, 20);
            this.menuOyuncuIslemleri.Text = "Oyuncu İşlemleri";
            // 
            // menuOyuncuKayit
            // 
            this.menuOyuncuKayit.Name = "menuOyuncuKayit";
            this.menuOyuncuKayit.Size = new System.Drawing.Size(180, 22);
            this.menuOyuncuKayit.Text = "Oyuncu Kayıt";
            this.menuOyuncuKayit.Click += new System.EventHandler(this.menuOyuncuKayit_Click);
            // 
            // menuOyuncuListe
            // 
            this.menuOyuncuListe.Name = "menuOyuncuListe";
            this.menuOyuncuListe.Size = new System.Drawing.Size(180, 22);
            this.menuOyuncuListe.Text = "Oyuncu Listeleme";
            this.menuOyuncuListe.Click += new System.EventHandler(this.menuOyuncuListe_Click);
            // 
            // menuTakimIslemleri
            // 
            this.menuTakimIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTakimKayit,
            this.menuTakimListe});
            this.menuTakimIslemleri.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuTakimIslemleri.Name = "menuTakimIslemleri";
            this.menuTakimIslemleri.Size = new System.Drawing.Size(105, 20);
            this.menuTakimIslemleri.Text = "Takım İşlemleri";
            // 
            // menuTakimKayit
            // 
            this.menuTakimKayit.Name = "menuTakimKayit";
            this.menuTakimKayit.Size = new System.Drawing.Size(158, 22);
            this.menuTakimKayit.Text = "Takım Kayıt";
            this.menuTakimKayit.Click += new System.EventHandler(this.menuTakimKayit_Click);
            // 
            // menuTakimListe
            // 
            this.menuTakimListe.Name = "menuTakimListe";
            this.menuTakimListe.Size = new System.Drawing.Size(158, 22);
            this.menuTakimListe.Text = "Takım Listeleme";
            this.menuTakimListe.Click += new System.EventHandler(this.menuTakimListe_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuOyuncuIslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuOyuncuKayit;
        private System.Windows.Forms.ToolStripMenuItem menuOyuncuListe;
        private System.Windows.Forms.ToolStripMenuItem menuTakimIslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuTakimKayit;
        private System.Windows.Forms.ToolStripMenuItem menuTakimListe;
    }
}