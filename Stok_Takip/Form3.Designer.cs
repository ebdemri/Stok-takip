
namespace Stok_Takip
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
            this.lbUrunler = new System.Windows.Forms.ListBox();
            this.lbSepet = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnToplamTutarHesapla = new System.Windows.Forms.Button();
            this.btnSiparişOnay = new System.Windows.Forms.Button();
            this.btnDukkanIslemleri = new System.Windows.Forms.Button();
            this.btnYeniSatisIslemi = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblIndirimliTutar = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUrunler
            // 
            this.lbUrunler.FormattingEnabled = true;
            this.lbUrunler.ItemHeight = 15;
            this.lbUrunler.Location = new System.Drawing.Point(12, 80);
            this.lbUrunler.Name = "lbUrunler";
            this.lbUrunler.Size = new System.Drawing.Size(296, 199);
            this.lbUrunler.TabIndex = 0;
            this.lbUrunler.SelectedIndexChanged += new System.EventHandler(this.lbUrunler_SelectedIndexChanged);
            // 
            // lbSepet
            // 
            this.lbSepet.FormattingEnabled = true;
            this.lbSepet.ItemHeight = 15;
            this.lbSepet.Location = new System.Drawing.Point(459, 80);
            this.lbSepet.Name = "lbSepet";
            this.lbSepet.Size = new System.Drawing.Size(296, 199);
            this.lbSepet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(123, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(572, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sepet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(459, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toplam Tutar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tutar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Adet :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(459, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "İndirimli Tutar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(459, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ödeme :";
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(528, 356);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(53, 19);
            this.rbNakit.TabIndex = 10;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(153, 303);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 12;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(153, 358);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSepeteEkle.TabIndex = 13;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnToplamTutarHesapla
            // 
            this.btnToplamTutarHesapla.Location = new System.Drawing.Point(658, 309);
            this.btnToplamTutarHesapla.Name = "btnToplamTutarHesapla";
            this.btnToplamTutarHesapla.Size = new System.Drawing.Size(97, 23);
            this.btnToplamTutarHesapla.TabIndex = 14;
            this.btnToplamTutarHesapla.Text = "Toplam Tutar";
            this.btnToplamTutarHesapla.UseVisualStyleBackColor = true;
            this.btnToplamTutarHesapla.Click += new System.EventHandler(this.btnToplamTutarHesapla_Click);
            // 
            // btnSiparişOnay
            // 
            this.btnSiparişOnay.Location = new System.Drawing.Point(680, 408);
            this.btnSiparişOnay.Name = "btnSiparişOnay";
            this.btnSiparişOnay.Size = new System.Drawing.Size(97, 23);
            this.btnSiparişOnay.TabIndex = 15;
            this.btnSiparişOnay.Text = "Siparişi Onayla";
            this.btnSiparişOnay.UseVisualStyleBackColor = true;
            this.btnSiparişOnay.Click += new System.EventHandler(this.btnSiparişOnay_Click);
            // 
            // btnDukkanIslemleri
            // 
            this.btnDukkanIslemleri.Location = new System.Drawing.Point(314, 98);
            this.btnDukkanIslemleri.Name = "btnDukkanIslemleri";
            this.btnDukkanIslemleri.Size = new System.Drawing.Size(139, 23);
            this.btnDukkanIslemleri.TabIndex = 16;
            this.btnDukkanIslemleri.Text = "Dükkan";
            this.btnDukkanIslemleri.UseVisualStyleBackColor = true;
            this.btnDukkanIslemleri.Click += new System.EventHandler(this.btnDukkanIslemleri_Click);
            // 
            // btnYeniSatisIslemi
            // 
            this.btnYeniSatisIslemi.Location = new System.Drawing.Point(315, 154);
            this.btnYeniSatisIslemi.Name = "btnYeniSatisIslemi";
            this.btnYeniSatisIslemi.Size = new System.Drawing.Size(138, 23);
            this.btnYeniSatisIslemi.TabIndex = 17;
            this.btnYeniSatisIslemi.Text = "Yeni Satış";
            this.btnYeniSatisIslemi.UseVisualStyleBackColor = true;
            this.btnYeniSatisIslemi.Click += new System.EventHandler(this.btnYeniSatisIslemi_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(66, 361);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(42, 15);
            this.lblTutar.TabIndex = 19;
            this.lblTutar.Text = "_______";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(564, 312);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(42, 15);
            this.lblToplam.TabIndex = 20;
            this.lblToplam.Text = "_______";
            // 
            // lblIndirimliTutar
            // 
            this.lblIndirimliTutar.AutoSize = true;
            this.lblIndirimliTutar.Location = new System.Drawing.Point(572, 416);
            this.lblIndirimliTutar.Name = "lblIndirimliTutar";
            this.lblIndirimliTutar.Size = new System.Drawing.Size(42, 15);
            this.lblIndirimliTutar.TabIndex = 21;
            this.lblIndirimliTutar.Text = "_______";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(66, 309);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(66, 23);
            this.nudAdet.TabIndex = 22;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.lblIndirimliTutar);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnYeniSatisIslemi);
            this.Controls.Add(this.btnDukkanIslemleri);
            this.Controls.Add(this.btnSiparişOnay);
            this.Controls.Add(this.btnToplamTutarHesapla);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.rbNakit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSepet);
            this.Controls.Add(this.lbUrunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Satış Ekranı";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUrunler;
        private System.Windows.Forms.ListBox lbSepet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button btnToplamTutarHesapla;
        private System.Windows.Forms.Button btnSiparişOnay;
        private System.Windows.Forms.Button btnDukkanIslemleri;
        private System.Windows.Forms.Button btnYeniSatisIslemi;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblIndirimliTutar;
        private System.Windows.Forms.NumericUpDown nudAdet;
    }
}