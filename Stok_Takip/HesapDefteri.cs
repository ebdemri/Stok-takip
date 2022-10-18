using System;
using System.Collections.Generic;
using System.Text;

namespace Stok_Takip
{
    public class HesapDefteri
    {
        public Satis Satıslar = new Satis();
        public Dukkan Dukkanimiz = new Dukkan();
        private int toplamurunadedi;

        public int ToplamUrunAdedi
        {
            get
            {
                UrunAdediHesapla();
                return toplamurunadedi;
            }

        }
        public void stoksifirla()
        {
            toplamurunadedi = 0;

        }
        public void UrunAdediHesapla()
        {
            toplamurunadedi = 0;
            foreach (Urun u in Form3.UrunKatalogu.Dukkanimiz.UrunlerListesi)
            {
                toplamurunadedi += u.Tanım.UrunAdet;
            }
        }
        private decimal toplamsatistutari;
        public decimal ToplamSatisTutari
        {
            get { return toplamsatistutari; }
        }
        public void ToplamSatisTutariHesapla()
        {
            toplamsatistutari =  + Satıslar.NakitOdeme.OdemeMiktari;
        }

    }
}
