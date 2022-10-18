using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    public class UrunKatalogu
    {
        public Dukkan Dukkanimiz { get; set; }
        public UrunTanimi UrunTanimi { get; set; }

        public UrunKatalogu()
        {
            this.Dukkanimiz = new Dukkan();
        }
    }
}
