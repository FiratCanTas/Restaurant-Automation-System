
namespace HamburgerciOdevi
{
    partial class Form1
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
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEkstraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisOlustur,
            this.tsmSiparisBilgileri});
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // tsmSiparisOlustur
            // 
            this.tsmSiparisOlustur.Name = "tsmSiparisOlustur";
            this.tsmSiparisOlustur.Size = new System.Drawing.Size(224, 26);
            this.tsmSiparisOlustur.Text = "Sipariş Oluştur";
            this.tsmSiparisOlustur.Click += new System.EventHandler(this.tsmSiparisOlustur_Click_1);
            // 
            // tsmSiparisBilgileri
            // 
            this.tsmSiparisBilgileri.Name = "tsmSiparisBilgileri";
            this.tsmSiparisBilgileri.Size = new System.Drawing.Size(224, 26);
            this.tsmSiparisBilgileri.Text = "Sipariş Bilgileri";
            this.tsmSiparisBilgileri.Click += new System.EventHandler(this.tsmSiparisBilgileri_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuEkle,
            this.tsmEkstraMalzemeEkle});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // tsmMenuEkle
            // 
            this.tsmMenuEkle.Name = "tsmMenuEkle";
            this.tsmMenuEkle.Size = new System.Drawing.Size(227, 26);
            this.tsmMenuEkle.Text = "Menü Ekle";
            this.tsmMenuEkle.Click += new System.EventHandler(this.tsmMenuEkle_Click);
            // 
            // tsmEkstraMalzemeEkle
            // 
            this.tsmEkstraMalzemeEkle.Name = "tsmEkstraMalzemeEkle";
            this.tsmEkstraMalzemeEkle.Size = new System.Drawing.Size(227, 26);
            this.tsmEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.tsmEkstraMalzemeEkle.Click += new System.EventHandler(this.tsmEkstraMalzemeEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 826);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HamburgerciMdiForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisOlustur;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisBilgileri;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmMenuEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmEkstraMalzemeEkle;
    }
}

