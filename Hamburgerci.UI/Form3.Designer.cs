
namespace Hamburgerci.UI
{
    partial class Form3
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
            this.grpEkstaMalzemeEkle = new System.Windows.Forms.GroupBox();
            this.btnEkstraMalzemeEkle = new System.Windows.Forms.Button();
            this.nmrEkstraMalzemeFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEkstaMalzemeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEkstaMalzemeEkle
            // 
            this.grpEkstaMalzemeEkle.Controls.Add(this.btnEkstraMalzemeEkle);
            this.grpEkstaMalzemeEkle.Controls.Add(this.nmrEkstraMalzemeFiyati);
            this.grpEkstaMalzemeEkle.Controls.Add(this.txtEkstraMalzemeAdi);
            this.grpEkstaMalzemeEkle.Controls.Add(this.label2);
            this.grpEkstaMalzemeEkle.Controls.Add(this.label1);
            this.grpEkstaMalzemeEkle.Location = new System.Drawing.Point(15, 16);
            this.grpEkstaMalzemeEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEkstaMalzemeEkle.Name = "grpEkstaMalzemeEkle";
            this.grpEkstaMalzemeEkle.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEkstaMalzemeEkle.Size = new System.Drawing.Size(312, 181);
            this.grpEkstaMalzemeEkle.TabIndex = 1;
            this.grpEkstaMalzemeEkle.TabStop = false;
            this.grpEkstaMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            // 
            // btnEkstraMalzemeEkle
            // 
            this.btnEkstraMalzemeEkle.Location = new System.Drawing.Point(192, 119);
            this.btnEkstraMalzemeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkstraMalzemeEkle.Name = "btnEkstraMalzemeEkle";
            this.btnEkstraMalzemeEkle.Size = new System.Drawing.Size(109, 44);
            this.btnEkstraMalzemeEkle.TabIndex = 4;
            this.btnEkstraMalzemeEkle.Text = "KAYDET";
            this.btnEkstraMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnEkstraMalzemeEkle.Click += new System.EventHandler(this.btnEkstraMalzemeEkle_Click);
            // 
            // nmrEkstraMalzemeFiyati
            // 
            this.nmrEkstraMalzemeFiyati.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nmrEkstraMalzemeFiyati.Location = new System.Drawing.Point(143, 82);
            this.nmrEkstraMalzemeFiyati.Margin = new System.Windows.Forms.Padding(4);
            this.nmrEkstraMalzemeFiyati.Name = "nmrEkstraMalzemeFiyati";
            this.nmrEkstraMalzemeFiyati.Size = new System.Drawing.Size(158, 24);
            this.nmrEkstraMalzemeFiyati.TabIndex = 3;
            // 
            // txtEkstraMalzemeAdi
            // 
            this.txtEkstraMalzemeAdi.Location = new System.Drawing.Point(143, 37);
            this.txtEkstraMalzemeAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            this.txtEkstraMalzemeAdi.Size = new System.Drawing.Size(157, 24);
            this.txtEkstraMalzemeAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı: ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 212);
            this.Controls.Add(this.grpEkstaMalzemeEkle);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grpEkstaMalzemeEkle.ResumeLayout(false);
            this.grpEkstaMalzemeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEkstaMalzemeEkle;
        private System.Windows.Forms.Button btnEkstraMalzemeEkle;
        private System.Windows.Forms.NumericUpDown nmrEkstraMalzemeFiyati;
        private System.Windows.Forms.TextBox txtEkstraMalzemeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}