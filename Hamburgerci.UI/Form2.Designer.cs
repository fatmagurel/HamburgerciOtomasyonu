
namespace Hamburgerci.UI
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenuKaydet = new System.Windows.Forms.Button();
            this.nmrFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenuKaydet);
            this.groupBox1.Controls.Add(this.nmrFiyati);
            this.groupBox1.Controls.Add(this.txtMenuAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(268, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü Ekle";
            // 
            // btnMenuKaydet
            // 
            this.btnMenuKaydet.Location = new System.Drawing.Point(164, 97);
            this.btnMenuKaydet.Name = "btnMenuKaydet";
            this.btnMenuKaydet.Size = new System.Drawing.Size(94, 36);
            this.btnMenuKaydet.TabIndex = 4;
            this.btnMenuKaydet.Text = "KAYDET";
            this.btnMenuKaydet.UseVisualStyleBackColor = true;
            this.btnMenuKaydet.Click += new System.EventHandler(this.btnMenuKaydet_Click);
            // 
            // nmrFiyati
            // 
            this.nmrFiyati.Location = new System.Drawing.Point(83, 67);
            this.nmrFiyati.Name = "nmrFiyati";
            this.nmrFiyati.Size = new System.Drawing.Size(175, 24);
            this.nmrFiyati.TabIndex = 3;
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(83, 30);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(175, 24);
            this.txtMenuAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 177);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenuKaydet;
        private System.Windows.Forms.NumericUpDown nmrFiyati;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}