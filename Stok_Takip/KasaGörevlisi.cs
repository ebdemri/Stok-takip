using System;
using System.Collections.Generic;
using System.Text;

namespace Stok_Takip
{
    public class KasaGörevlisi:Kisi
    {
        public string KasaNo { get; set; }
        public string Parola { get; set; }
    
        public string KasaaNo { get; set; }

        public override void KisiBilgisiDoldur(string Ad, string Soyad, string SigortaNo)
        {
            base.KisiBilgisiDoldur(Ad, Soyad, SigortaNo);
            this.KasaaNo = SigortaNo.ToUpper();

        }
        public KasaGörevlisi()
        {

        }
        public KasaGörevlisi(string ad, string soyad, string sigortaNo, long telefon)
        {
            this.Ad = ad.ToUpper();
            this.Soyad = soyad.ToUpper();
            this.KasaaNo = sigortaNo.ToUpper();
            this.Telefon = telefon;
        }
    }

   
}
