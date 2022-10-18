using System;
using System.Collections.Generic;
using System.Text;

namespace Stok_Takip
{
    
        public abstract class Odeme
        {
            public decimal OdemeMiktari { get; set; }

            public abstract void Ode(decimal tutar);
        }
    
}
