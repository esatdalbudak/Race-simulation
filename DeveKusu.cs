using System;
using System.Collections.Generic;
using System.Text;

namespace YarismaTest
{
    public class DeveKusu : Hayvan
    {
        public bool Paralize { get; set; }

        public DeveKusu()
        {

        }
        public override void HareketEt()
        {
            base.HareketEt();

            if (rng >= 0 && rng < 5)
            {
                Konum += 3;
            }
            else if (rng >= 5 && rng < 8)
            {
                Konum += 6;
            }
            else
            {
                Konum -= 4;

                if (Konum < 0) Konum = 0;
            }

        }
    }
}
