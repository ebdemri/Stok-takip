using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class Form3 : Form
    {
        Form4 DukkanIslemleri = new Form4();
        public static decimal ToplamSatisTutari = 0;
        public static decimal GeciciTutar = 0;
        public Form3()
        {
            InitializeComponent();
        }
        public static UrunKatalogu UrunKatalogu = new UrunKatalogu();
        public static HesapDefteri HesapDefteri = new HesapDefteri();
        public static SatisKalemi SatisKalemi = new SatisKalemi();
        public static Satis Satis = new Satis();
        public static NakitOdeme Nakit = new NakitOdeme();     
        private void Form3_Load_1(object sender, EventArgs e)
        {
            foreach (Urun u in UrunKatalogu.Dukkanimiz.UrunlerListesi)
            {
                lbUrunler.Items.Add(u);
            }
            if (lbUrunler.SelectedItem == null)
            {
                btnHesapla.Enabled = false;
            }
            else
            {
                btnHesapla.Enabled = true;
            }
        }
        private void lbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUrunler.SelectedItem == null)
            {
                btnHesapla.Enabled = false;
            }
            else
            {
                nudAdet.Value = 1;
                Urun u = (Urun)lbUrunler.SelectedItem;
                nudAdet.Maximum = u.Tanım.UrunAdet;
                btnHesapla.Enabled = true;
            }
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Urun u = (Urun)lbUrunler.SelectedItem;
            u.Tanım.Miktar = Convert.ToInt32(nudAdet.Value);
            lblTutar.Text = u.Tanım.tutarhesapla().ToString() + " TL";
            btnSepeteEkle.Enabled = true;
        }
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            Urun u = (Urun)lbUrunler.SelectedItem;
            u.Tanım.Miktar = Convert.ToInt32(nudAdet.Value);

            SatisKalemi.UrunEkle(u);
            lbSepet.Items.Add(u.Tanım.Ad + " " + u.Tanım.Fiyatı + " x " + u.Tanım.Miktar + " = " + u.Tanım.tutarhesapla().ToString() + " TL");
            lblTutar.Text = "    ";
            lbUrunler.SelectedItem = null;
            nudAdet.Value = 1;
            btnSepeteEkle.Enabled = false;
            GeciciTutar += u.Tanım.Fiyatı * u.Tanım.Miktar;
        }
        private void btnToplamTutarHesapla_Click(object sender, EventArgs e)
        {
            lblToplam.Text = GeciciTutar.ToString() + "  TL";
        }
        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            Satis.NakitOdeme.Ode(GeciciTutar);
            lblIndirimliTutar.Text = Satis.NakitOdeme.OdemeMiktari.ToString() + " TL";
            btnSiparişOnay.Visible = true;
            // Satis.KrediliOdeme.OdemeMiktari = 0;
        }
        private void btnSiparişOnay_Click(object sender, EventArgs e)
        {
            foreach (Urun u in SatisKalemi.AlinanUrunler)
            {
                UrunKatalogu.Dukkanimiz.UrunCikar(u);
            }
            SatisKalemi.AlinanUrunler.Clear();
            Satis.Tarih = DateTime.Now;
            string mesaj = "";
            string[] veriler1 = new string
            [lbSepet.Items.Count];
            for (int i = 0; i < lbSepet.Items.Count; i++)
            {
                veriler1[i] = lbSepet.Items[i].ToString();
                mesaj += veriler1[i] + 
                    
                    
                    
                    "  ";
            }
            MessageBox.Show("" + HesapDefteri.Dukkanimiz.DukkanAdi +
                            "\n" + HesapDefteri.Dukkanimiz.DukkanAdresi +
                            "\n\nSatış Tarihi : " + Satis.Tarih.ToString() +
                            // "\nTerminal Seri Numarası : " + HesapDefteri.Dukkanimiz.Terminal1.SeriNo.ToString() +
                            "\nAlınan Ürünler" + mesaj +
                            "\n--------------------------------------------------------------" +
                            "\nToplam Tutar : " + (Satis.NakitOdeme.OdemeMiktari).ToString() +
                            "\n--------------------------------------------------------------" +
                            "\n\n Kasiyer : " + Form1.GirisYapanKasaGorevlisi.Ad + " " + Form1.GirisYapanKasaGorevlisi.Soyad +
                            "\n--------------------------------------------------------------" +
                            "\n \n.Json Uzantısı Oluşturuldu ! !  "
                );
            var dateString = DateTime.Now.ToString("MM/dd/yyyy");
            string strResultJson = JsonConvert.SerializeObject(mesaj);
            File.WriteAllText(dateString + ".json", strResultJson);

            ToplamSatisTutari += Satis.NakitOdeme.OdemeMiktari;
            Satis.ToplamTutar += ToplamSatisTutari;
            btnHesapla.Enabled = false;
            btnSepeteEkle.Enabled = false;
            btnToplamTutarHesapla.Enabled = false;
        }

        private void btnYeniSatisIslemi_Click(object sender, EventArgs e)
        {
            GeciciTutar = 0;
            if (Application.OpenForms[0] == this)
            {
                Application.Restart();
            }
            else
            {
                Form3 f = new Form3();
                f.Show();
                this.Close();

            }
        }
        private void btnDukkanIslemleri_Click(object sender, EventArgs e)
        {
            DukkanIslemleri.Show();
            this.Close();
        }
    }
}
