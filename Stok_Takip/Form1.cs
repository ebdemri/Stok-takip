using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class Form1 : Form
    {
        Form2 SecimIslemi = new Form2();
        Form4 DukkanIslemleri = new Form4();
        public Form1()
        {
            InitializeComponent();
        }
        public static KasaGörevlisi yeniKasiyer = new KasaGörevlisi();
        public static KasaGörevlisi GirisYapanKasaGorevlisi = new KasaGörevlisi();
        public static KasaGörevlisi KasaGorevlisi1 = new KasaGörevlisi("Barış", "Çilak", "1", 1);
        public static KasaGörevlisi KasaGorevlisi2 = new KasaGörevlisi("2" ,"2", "2", 1);
        public static KasaGörevlisi KasaGorevlisi3 = new KasaGörevlisi("3", "3", "3", 1);       
        private void btnKasiyerGiris_Click(object sender, EventArgs e)
        {
            GirisYapanKasaGorevlisi.Ad = txtKasiyerAd.Text.ToUpper();
            GirisYapanKasaGorevlisi.Soyad = txtKasiyerSoyadi.Text.ToUpper();
            GirisYapanKasaGorevlisi.KasaaNo = txtKasiyerKasaNo.Text.ToUpper();


            if (GirisYapanKasaGorevlisi.Ad == KasaGorevlisi1.Ad && GirisYapanKasaGorevlisi.Soyad == KasaGorevlisi1.Soyad && GirisYapanKasaGorevlisi.KasaaNo == KasaGorevlisi1.KasaaNo)
            {
                GirisYapanKasaGorevlisi.KisiBilgisiDoldur(txtKasiyerAd.Text, txtKasiyerSoyadi.Text, txtKasiyerKasaNo.Text);
                SecimIslemi.Show();
                this.Hide();
            }
            else if (GirisYapanKasaGorevlisi.Ad == KasaGorevlisi2.Ad && GirisYapanKasaGorevlisi.Soyad == KasaGorevlisi2.Soyad && GirisYapanKasaGorevlisi.KasaaNo == KasaGorevlisi2.KasaaNo)
            {
                GirisYapanKasaGorevlisi.KisiBilgisiDoldur(txtKasiyerAd.Text, txtKasiyerSoyadi.Text, txtKasiyerKasaNo.Text);
                SecimIslemi.Show();
                this.Hide();
            }
            else if (GirisYapanKasaGorevlisi.Ad == KasaGorevlisi3.Ad && GirisYapanKasaGorevlisi.Soyad == KasaGorevlisi3.Soyad && GirisYapanKasaGorevlisi.KasaaNo == KasaGorevlisi3.KasaaNo)
            {
                GirisYapanKasaGorevlisi.KisiBilgisiDoldur(txtKasiyerAd.Text, txtKasiyerSoyadi.Text, txtKasiyerKasaNo.Text);
                SecimIslemi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen Kasiyer Bilgileri Yanlış. Lütfen Tekrar Deneyin.");
                txtKasiyerAd.Text = "";
                txtKasiyerSoyadi.Text = "";
                txtKasiyerKasaNo.Text = "";
            }
        }
    }
}
