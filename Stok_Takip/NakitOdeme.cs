using System;
using System.Collections.Generic;
using System.Text;

namespace Stok_Takip
{
     public class NakitOdeme : Odeme
    {
        private const decimal INDIRIMORANI = 0.05M;
        public decimal Indirim { get; private set; }
        public override void Ode(decimal tutar)
        {
            Indirim = tutar * INDIRIMORANI;
            OdemeMiktari = tutar - Indirim;


        }
    }
}
