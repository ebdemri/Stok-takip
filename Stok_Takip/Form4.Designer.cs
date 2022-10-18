
namespace Stok_Takip
{
    partial class Form4
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
            this.tabControlDukkanIslemleri = new System.Windows.Forms.TabControl();
            this.tabPageUrunKatalogu = new System.Windows.Forms.TabPage();
            this.btnSatisIslemleriGecis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUrunKatalogu = new System.Windows.Forms.ListBox();
            this.tabPageUrunEkle = new System.Windows.Forms.TabPage();
            this.lblEklenenUrun = new System.Windows.Forms.Label();
            this.nudUrunAdedi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunTanimi = new System.Windows.Forms.ComboBox();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.lblUrunFiyati = new System.Windows.Forms.Label();
            this.lbUrunAdi = new System.Windows.Forms.Label();
            this.lbUrunTanimi = new System.Windows.Forms.Label();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tabPageHesapDefteri = new System.Windows.Forms.TabPage();
            this.lblToplamSatisTutari = new System.Windows.Forms.Label();
            this.lblSatoktakiUrunSayisi = new System.Windows.Forms.Label();
            this.lbToplamSatisTutariyazi = new System.Windows.Forms.Label();
            this.lbStoktakiUrunSayisiyazi = new System.Windows.Forms.Label();
            this.tabPageUrunGuncelle = new System.Windows.Forms.TabPage();
            this.lblGuncellenenUrun = new System.Windows.Forms.Label();
            this.btnHesapDefteri = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.nudStokUrunAdedi = new System.Windows.Forms.NumericUpDown();
            this.txtStokUrunKodu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControlDukkanIslemleri.SuspendLayout();
            this.tabPageUrunKatalogu.SuspendLayout();
            this.tabPageUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdedi)).BeginInit();
            this.tabPageHesapDefteri.SuspendLayout();
            this.tabPageUrunGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokUrunAdedi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDukkanIslemleri
            // 
            this.tabControlDukkanIslemleri.Controls.Add(this.tabPageUrunKatalogu);
            this.tabControlDukkanIslemleri.Controls.Add(this.tabPageUrunEkle);
            this.tabControlDukkanIslemleri.Controls.Add(this.tabPageHesapDefteri);
            this.tabControlDukkanIslemleri.Controls.Add(this.tabPageUrunGuncelle);
            this.tabControlDukkanIslemleri.Location = new System.Drawing.Point(1, 1);
            this.tabControlDukkanIslemleri.Name = "tabControlDukkanIslemleri";
            this.tabControlDukkanIslemleri.SelectedIndex = 0;
            this.tabControlDukkanIslemleri.Size = new System.Drawing.Size(578, 452);
            this.tabControlDukkanIslemleri.TabIndex = 0;
            // 
            // tabPageUrunKatalogu
            // 
            this.tabPageUrunKatalogu.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPageUrunKatalogu.Controls.Add(this.btnSatisIslemleriGecis);
            this.tabPageUrunKatalogu.Controls.Add(this.label1);
            this.tabPageUrunKatalogu.Controls.Add(this.lbUrunKatalogu);
            this.tabPageUrunKatalogu.Location = new System.Drawing.Point(4, 24);
            this.tabPageUrunKatalogu.Name = "tabPageUrunKatalogu";
            this.tabPageUrunKatalogu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunKatalogu.Size = new System.Drawing.Size(570, 424);
            this.tabPageUrunKatalogu.TabIndex = 0;
            this.tabPageUrunKatalogu.Text = "Ürün Kataloğu";
            // 
            // btnSatisIslemleriGecis
            // 
            this.btnSatisIslemleriGecis.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSatisIslemleriGecis.Location = new System.Drawing.Point(327, 186);
            this.btnSatisIslemleriGecis.Name = "btnSatisIslemleriGecis";
            this.btnSatisIslemleriGecis.Size = new System.Drawing.Size(214, 39);
            this.btnSatisIslemleriGecis.TabIndex = 2;
            this.btnSatisIslemleriGecis.Text = "Satış Ekranına Git";
            this.btnSatisIslemleriGecis.UseVisualStyleBackColor = true;
            this.btnSatisIslemleriGecis.Click += new System.EventHandler(this.btnSatisIslemleriGecis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürünler";
            // 
            // lbUrunKatalogu
            // 
            this.lbUrunKatalogu.FormattingEnabled = true;
            this.lbUrunKatalogu.ItemHeight = 15;
            this.lbUrunKatalogu.Location = new System.Drawing.Point(24, 58);
            this.lbUrunKatalogu.Name = "lbUrunKatalogu";
            this.lbUrunKatalogu.Size = new System.Drawing.Size(247, 334);
            this.lbUrunKatalogu.TabIndex = 0;
            this.lbUrunKatalogu.SelectedIndexChanged += new System.EventHandler(this.lbUrunKatalogu_SelectedIndexChanged);
            // 
            // tabPageUrunEkle
            // 
            this.tabPageUrunEkle.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPageUrunEkle.Controls.Add(this.lblEklenenUrun);
            this.tabPageUrunEkle.Controls.Add(this.nudUrunAdedi);
            this.tabPageUrunEkle.Controls.Add(this.label2);
            this.tabPageUrunEkle.Controls.Add(this.cmbUrunTanimi);
            this.tabPageUrunEkle.Controls.Add(this.txtUrunFiyati);
            this.tabPageUrunEkle.Controls.Add(this.txtUrunAdi);
            this.tabPageUrunEkle.Controls.Add(this.txtUrunKodu);
            this.tabPageUrunEkle.Controls.Add(this.lblUrunFiyati);
            this.tabPageUrunEkle.Controls.Add(this.lbUrunAdi);
            this.tabPageUrunEkle.Controls.Add(this.lbUrunTanimi);
            this.tabPageUrunEkle.Controls.Add(this.lblUrunKodu);
            this.tabPageUrunEkle.Controls.Add(this.btnEkle);
            this.tabPageUrunEkle.Location = new System.Drawing.Point(4, 24);
            this.tabPageUrunEkle.Name = "tabPageUrunEkle";
            this.tabPageUrunEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunEkle.Size = new System.Drawing.Size(570, 424);
            this.tabPageUrunEkle.TabIndex = 1;
            this.tabPageUrunEkle.Text = "Ürün Ekle";
            // 
            // lblEklenenUrun
            // 
            this.lblEklenenUrun.AutoSize = true;
            this.lblEklenenUrun.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEklenenUrun.Location = new System.Drawing.Point(184, 336);
            this.lblEklenenUrun.Name = "lblEklenenUrun";
            this.lblEklenenUrun.Size = new System.Drawing.Size(0, 23);
            this.lblEklenenUrun.TabIndex = 13;
            // 
            // nudUrunAdedi
            // 
            this.nudUrunAdedi.Location = new System.Drawing.Point(248, 209);
            this.nudUrunAdedi.Name = "nudUrunAdedi";
            this.nudUrunAdedi.Size = new System.Drawing.Size(99, 23);
            this.nudUrunAdedi.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(144, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ürün Adedi :";
            // 
            // cmbUrunTanimi
            // 
            this.cmbUrunTanimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunTanimi.FormattingEnabled = true;
            this.cmbUrunTanimi.Location = new System.Drawing.Point(247, 91);
            this.cmbUrunTanimi.Name = "cmbUrunTanimi";
            this.cmbUrunTanimi.Size = new System.Drawing.Size(100, 23);
            this.cmbUrunTanimi.TabIndex = 10;
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(247, 171);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(100, 23);
            this.txtUrunFiyati.TabIndex = 8;
            this.txtUrunFiyati.TextChanged += new System.EventHandler(this.txtUrunFiyati_TextChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(247, 126);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 23);
            this.txtUrunAdi.TabIndex = 7;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(247, 43);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(100, 23);
            this.txtUrunKodu.TabIndex = 6;
            this.txtUrunKodu.TextChanged += new System.EventHandler(this.txtUrunKodu_TextChanged);
            // 
            // lblUrunFiyati
            // 
            this.lblUrunFiyati.AutoSize = true;
            this.lblUrunFiyati.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUrunFiyati.Location = new System.Drawing.Point(154, 171);
            this.lblUrunFiyati.Name = "lblUrunFiyati";
            this.lblUrunFiyati.Size = new System.Drawing.Size(87, 18);
            this.lblUrunFiyati.TabIndex = 4;
            this.lblUrunFiyati.Text = "Ürün Fiyatı :";
            // 
            // lbUrunAdi
            // 
            this.lbUrunAdi.AutoSize = true;
            this.lbUrunAdi.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUrunAdi.Location = new System.Drawing.Point(168, 131);
            this.lbUrunAdi.Name = "lbUrunAdi";
            this.lbUrunAdi.Size = new System.Drawing.Size(73, 18);
            this.lbUrunAdi.TabIndex = 3;
            this.lbUrunAdi.Text = "Ürün Adı :";
            // 
            // lbUrunTanimi
            // 
            this.lbUrunTanimi.AutoSize = true;
            this.lbUrunTanimi.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUrunTanimi.Location = new System.Drawing.Point(122, 91);
            this.lbUrunTanimi.Name = "lbUrunTanimi";
            this.lbUrunTanimi.Size = new System.Drawing.Size(124, 18);
            this.lbUrunTanimi.TabIndex = 2;
            this.lbUrunTanimi.Text = "Ürün Kategorisi : ";
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.AutoSize = true;
            this.lblUrunKodu.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUrunKodu.Location = new System.Drawing.Point(156, 48);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(85, 18);
            this.lblUrunKodu.TabIndex = 1;
            this.lblUrunKodu.Text = "Ürün Kodu :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(221, 273);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(126, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tabPageHesapDefteri
            // 
            this.tabPageHesapDefteri.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPageHesapDefteri.Controls.Add(this.lblToplamSatisTutari);
            this.tabPageHesapDefteri.Controls.Add(this.lblSatoktakiUrunSayisi);
            this.tabPageHesapDefteri.Controls.Add(this.lbToplamSatisTutariyazi);
            this.tabPageHesapDefteri.Controls.Add(this.lbStoktakiUrunSayisiyazi);
            this.tabPageHesapDefteri.Location = new System.Drawing.Point(4, 24);
            this.tabPageHesapDefteri.Name = "tabPageHesapDefteri";
            this.tabPageHesapDefteri.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHesapDefteri.Size = new System.Drawing.Size(570, 424);
            this.tabPageHesapDefteri.TabIndex = 2;
            this.tabPageHesapDefteri.Text = "Hesap Defteri";
            // 
            // lblToplamSatisTutari
            // 
            this.lblToplamSatisTutari.AutoSize = true;
            this.lblToplamSatisTutari.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplamSatisTutari.Location = new System.Drawing.Point(325, 206);
            this.lblToplamSatisTutari.Name = "lblToplamSatisTutari";
            this.lblToplamSatisTutari.Size = new System.Drawing.Size(76, 30);
            this.lblToplamSatisTutari.TabIndex = 3;
            this.lblToplamSatisTutari.Text = "_______";
            // 
            // lblSatoktakiUrunSayisi
            // 
            this.lblSatoktakiUrunSayisi.AutoSize = true;
            this.lblSatoktakiUrunSayisi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSatoktakiUrunSayisi.Location = new System.Drawing.Point(325, 92);
            this.lblSatoktakiUrunSayisi.Name = "lblSatoktakiUrunSayisi";
            this.lblSatoktakiUrunSayisi.Size = new System.Drawing.Size(76, 30);
            this.lblSatoktakiUrunSayisi.TabIndex = 2;
            this.lblSatoktakiUrunSayisi.Text = "_______";
            // 
            // lbToplamSatisTutariyazi
            // 
            this.lbToplamSatisTutariyazi.AutoSize = true;
            this.lbToplamSatisTutariyazi.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbToplamSatisTutariyazi.Location = new System.Drawing.Point(112, 209);
            this.lbToplamSatisTutariyazi.Name = "lbToplamSatisTutariyazi";
            this.lbToplamSatisTutariyazi.Size = new System.Drawing.Size(207, 25);
            this.lbToplamSatisTutariyazi.TabIndex = 1;
            this.lbToplamSatisTutariyazi.Text = "Toplam Satış Tutarı : ";
            // 
            // lbStoktakiUrunSayisiyazi
            // 
            this.lbStoktakiUrunSayisiyazi.AutoSize = true;
            this.lbStoktakiUrunSayisiyazi.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStoktakiUrunSayisiyazi.Location = new System.Drawing.Point(106, 95);
            this.lbStoktakiUrunSayisiyazi.Name = "lbStoktakiUrunSayisiyazi";
            this.lbStoktakiUrunSayisiyazi.Size = new System.Drawing.Size(213, 25);
            this.lbStoktakiUrunSayisiyazi.TabIndex = 0;
            this.lbStoktakiUrunSayisiyazi.Text = "Stoktaki Ürün Sayısı :";
            // 
            // tabPageUrunGuncelle
            // 
            this.tabPageUrunGuncelle.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPageUrunGuncelle.Controls.Add(this.lblGuncellenenUrun);
            this.tabPageUrunGuncelle.Controls.Add(this.btnHesapDefteri);
            this.tabPageUrunGuncelle.Controls.Add(this.btnGuncelle);
            this.tabPageUrunGuncelle.Controls.Add(this.nudStokUrunAdedi);
            this.tabPageUrunGuncelle.Controls.Add(this.txtStokUrunKodu);
            this.tabPageUrunGuncelle.Controls.Add(this.label12);
            this.tabPageUrunGuncelle.Controls.Add(this.label11);
            this.tabPageUrunGuncelle.Location = new System.Drawing.Point(4, 24);
            this.tabPageUrunGuncelle.Name = "tabPageUrunGuncelle";
            this.tabPageUrunGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunGuncelle.Size = new System.Drawing.Size(570, 424);
            this.tabPageUrunGuncelle.TabIndex = 3;
            this.tabPageUrunGuncelle.Text = "Stok Ekle";
            // 
            // lblGuncellenenUrun
            // 
            this.lblGuncellenenUrun.AutoSize = true;
            this.lblGuncellenenUrun.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGuncellenenUrun.Location = new System.Drawing.Point(39, 265);
            this.lblGuncellenenUrun.Name = "lblGuncellenenUrun";
            this.lblGuncellenenUrun.Size = new System.Drawing.Size(0, 25);
            this.lblGuncellenenUrun.TabIndex = 6;
            // 
            // btnHesapDefteri
            // 
            this.btnHesapDefteri.Location = new System.Drawing.Point(119, 187);
            this.btnHesapDefteri.Name = "btnHesapDefteri";
            this.btnHesapDefteri.Size = new System.Drawing.Size(209, 35);
            this.btnHesapDefteri.TabIndex = 5;
            this.btnHesapDefteri.Text = "Hesap Defterini Görüntüle";
            this.btnHesapDefteri.UseVisualStyleBackColor = true;
            this.btnHesapDefteri.Click += new System.EventHandler(this.btnHesapDefteri_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(315, 76);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 31);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // nudStokUrunAdedi
            // 
            this.nudStokUrunAdedi.Location = new System.Drawing.Point(155, 117);
            this.nudStokUrunAdedi.Name = "nudStokUrunAdedi";
            this.nudStokUrunAdedi.Size = new System.Drawing.Size(120, 23);
            this.nudStokUrunAdedi.TabIndex = 3;
            // 
            // txtStokUrunKodu
            // 
            this.txtStokUrunKodu.Location = new System.Drawing.Point(155, 54);
            this.txtStokUrunKodu.Name = "txtStokUrunKodu";
            this.txtStokUrunKodu.Size = new System.Drawing.Size(100, 23);
            this.txtStokUrunKodu.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(39, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Eklenecek Adet :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(64, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ürün Kodu :";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.tabControlDukkanIslemleri);
            this.Name = "Form4";
            this.Text = "Dükkan";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControlDukkanIslemleri.ResumeLayout(false);
            this.tabPageUrunKatalogu.ResumeLayout(false);
            this.tabPageUrunKatalogu.PerformLayout();
            this.tabPageUrunEkle.ResumeLayout(false);
            this.tabPageUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdedi)).EndInit();
            this.tabPageHesapDefteri.ResumeLayout(false);
            this.tabPageHesapDefteri.PerformLayout();
            this.tabPageUrunGuncelle.ResumeLayout(false);
            this.tabPageUrunGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokUrunAdedi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDukkanIslemleri;
        private System.Windows.Forms.TabPage tabPageUrunKatalogu;
        private System.Windows.Forms.Button btnSatisIslemleriGecis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbUrunKatalogu;
        private System.Windows.Forms.TabPage tabPageUrunEkle;
        private System.Windows.Forms.ComboBox cmbUrunTanimi;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Label lblUrunFiyati;
        private System.Windows.Forms.Label lbUrunAdi;
        private System.Windows.Forms.Label lbUrunTanimi;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TabPage tabPageHesapDefteri;
        private System.Windows.Forms.TabPage tabPageUrunGuncelle;
        private System.Windows.Forms.Label lblToplamSatisTutari;
        private System.Windows.Forms.Label lblSatoktakiUrunSayisi;
        private System.Windows.Forms.Label lbToplamSatisTutariyazi;
        private System.Windows.Forms.Label lbStoktakiUrunSayisiyazi;
        private System.Windows.Forms.Button btnHesapDefteri;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.NumericUpDown nudStokUrunAdedi;
        private System.Windows.Forms.TextBox txtStokUrunKodu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudUrunAdedi;
        private System.Windows.Forms.Label lblEklenenUrun;
        private System.Windows.Forms.Label lblGuncellenenUrun;
    }
}