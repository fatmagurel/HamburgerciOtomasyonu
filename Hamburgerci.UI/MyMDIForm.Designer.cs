
namespace Hamburgerci.UI
{
    partial class MyMDIForm
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
            this.tsmSiparisYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUrunYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEkstraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisYonetimi,
            this.tsmUrunYonetimi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSiparisYonetimi
            // 
            this.tsmSiparisYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisOlustur,
            this.tsmSiparisBilgileri});
            this.tsmSiparisYonetimi.Name = "tsmSiparisYonetimi";
            this.tsmSiparisYonetimi.Size = new System.Drawing.Size(103, 20);
            this.tsmSiparisYonetimi.Text = "Sipariş Yönetimi";
            // 
            // tsmUrunYonetimi
            // 
            this.tsmUrunYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuEkle,
            this.tsmEkstraMalzemeEkle});
            this.tsmUrunYonetimi.Name = "tsmUrunYonetimi";
            this.tsmUrunYonetimi.Size = new System.Drawing.Size(95, 20);
            this.tsmUrunYonetimi.Text = "Ürün Yönetimi";
            // 
            // tsmSiparisOlustur
            // 
            this.tsmSiparisOlustur.Name = "tsmSiparisOlustur";
            this.tsmSiparisOlustur.Size = new System.Drawing.Size(180, 22);
            this.tsmSiparisOlustur.Text = "Sipariş Oluştur";
            this.tsmSiparisOlustur.Click += new System.EventHandler(this.tsmSiparisOlustur_Click);
            // 
            // tsmMenuEkle
            // 
            this.tsmMenuEkle.Name = "tsmMenuEkle";
            this.tsmMenuEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmMenuEkle.Text = "Menü Ekle";
            this.tsmMenuEkle.Click += new System.EventHandler(this.tsmMenuEkle_Click);
            // 
            // tsmEkstraMalzemeEkle
            // 
            this.tsmEkstraMalzemeEkle.Name = "tsmEkstraMalzemeEkle";
            this.tsmEkstraMalzemeEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.tsmEkstraMalzemeEkle.Click += new System.EventHandler(this.tsmEkstraMalzemeEkle_Click);
            // 
            // tsmSiparisBilgileri
            // 
            this.tsmSiparisBilgileri.Name = "tsmSiparisBilgileri";
            this.tsmSiparisBilgileri.Size = new System.Drawing.Size(180, 22);
            this.tsmSiparisBilgileri.Text = "Sipariş Bilgileri";
            this.tsmSiparisBilgileri.Click += new System.EventHandler(this.tsmSiparisBilgileri_Click);
            // 
            // MyMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyMDIForm";
            this.Text = "MyMDIForm";
            this.Load += new System.EventHandler(this.MyMDIForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisYonetimi;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisOlustur;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisBilgileri;
        private System.Windows.Forms.ToolStripMenuItem tsmUrunYonetimi;
        private System.Windows.Forms.ToolStripMenuItem tsmMenuEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmEkstraMalzemeEkle;
    }
}