
namespace Hamburgerci.UI
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.grpBoyut = new System.Windows.Forms.GroupBox();
            this.rdoBuyuk = new System.Windows.Forms.RadioButton();
            this.rdoOrta = new System.Windows.Forms.RadioButton();
            this.rdoKucuk = new System.Windows.Forms.RadioButton();
            this.flpEkstraMalzeme = new System.Windows.Forms.FlowLayoutPanel();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hamburgerci.UI.Properties.Resources.hamburger;
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menü Seçiniz: ";
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(18, 226);
            this.cmbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(154, 24);
            this.cmbMenu.TabIndex = 2;
            // 
            // grpBoyut
            // 
            this.grpBoyut.Controls.Add(this.rdoBuyuk);
            this.grpBoyut.Controls.Add(this.rdoOrta);
            this.grpBoyut.Controls.Add(this.rdoKucuk);
            this.grpBoyut.Location = new System.Drawing.Point(18, 261);
            this.grpBoyut.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoyut.Name = "grpBoyut";
            this.grpBoyut.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoyut.Size = new System.Drawing.Size(210, 55);
            this.grpBoyut.TabIndex = 3;
            this.grpBoyut.TabStop = false;
            this.grpBoyut.Text = "Boyut Seçiniz";
            // 
            // rdoBuyuk
            // 
            this.rdoBuyuk.AutoSize = true;
            this.rdoBuyuk.Location = new System.Drawing.Point(142, 25);
            this.rdoBuyuk.Margin = new System.Windows.Forms.Padding(4);
            this.rdoBuyuk.Name = "rdoBuyuk";
            this.rdoBuyuk.Size = new System.Drawing.Size(65, 21);
            this.rdoBuyuk.TabIndex = 2;
            this.rdoBuyuk.TabStop = true;
            this.rdoBuyuk.Text = "Büyük";
            this.rdoBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdoOrta
            // 
            this.rdoOrta.AutoSize = true;
            this.rdoOrta.Location = new System.Drawing.Point(81, 25);
            this.rdoOrta.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOrta.Name = "rdoOrta";
            this.rdoOrta.Size = new System.Drawing.Size(53, 21);
            this.rdoOrta.TabIndex = 1;
            this.rdoOrta.TabStop = true;
            this.rdoOrta.Text = "Orta";
            this.rdoOrta.UseVisualStyleBackColor = true;
            // 
            // rdoKucuk
            // 
            this.rdoKucuk.AutoSize = true;
            this.rdoKucuk.Location = new System.Drawing.Point(8, 25);
            this.rdoKucuk.Margin = new System.Windows.Forms.Padding(4);
            this.rdoKucuk.Name = "rdoKucuk";
            this.rdoKucuk.Size = new System.Drawing.Size(65, 21);
            this.rdoKucuk.TabIndex = 0;
            this.rdoKucuk.TabStop = true;
            this.rdoKucuk.Text = "Küçük";
            this.rdoKucuk.UseVisualStyleBackColor = true;
            // 
            // flpEkstraMalzeme
            // 
            this.flpEkstraMalzeme.Location = new System.Drawing.Point(18, 341);
            this.flpEkstraMalzeme.Margin = new System.Windows.Forms.Padding(4);
            this.flpEkstraMalzeme.Name = "flpEkstraMalzeme";
            this.flpEkstraMalzeme.Size = new System.Drawing.Size(210, 226);
            this.flpEkstraMalzeme.TabIndex = 4;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(67, 575);
            this.nmrAdet.Margin = new System.Windows.Forms.Padding(4);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(111, 24);
            this.nmrAdet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 578);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adet";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(19, 607);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(158, 33);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "SİPARİŞ EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.ItemHeight = 16;
            this.lbxSiparisler.Location = new System.Drawing.Point(236, 13);
            this.lbxSiparisler.Margin = new System.Windows.Forms.Padding(4);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(422, 564);
            this.lbxSiparisler.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 582);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Toplam Tutar: ";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(283, 582);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(35, 17);
            this.lblToplamTutar.TabIndex = 10;
            this.lblToplamTutar.Text = "0 TL";
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(512, 583);
            this.btnSiparisiTamamla.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(146, 57);
            this.btnSiparisiTamamla.TabIndex = 11;
            this.btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Eksta Malzemeler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 653);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxSiparisler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.flpEkstraMalzeme);
            this.Controls.Add(this.grpBoyut);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoyut.ResumeLayout(false);
            this.grpBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.GroupBox grpBoyut;
        private System.Windows.Forms.RadioButton rdoBuyuk;
        private System.Windows.Forms.RadioButton rdoOrta;
        private System.Windows.Forms.RadioButton rdoKucuk;
        private System.Windows.Forms.FlowLayoutPanel flpEkstraMalzeme;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lbxSiparisler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.Label label5;
    }
}

