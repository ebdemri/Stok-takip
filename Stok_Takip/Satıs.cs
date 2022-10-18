using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    public class Satis
    {
        public DateTime Tarih { get; set; }
        public SatisKalemi Satiskalemi = new SatisKalemi();
        public decimal ToplamTutar { get; set; }

        public NakitOdeme NakitOdeme = new NakitOdeme();
       
    }
}
