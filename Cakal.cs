using System;
using System.Collections.Generic;
using System.Text;

namespace YarismaTest
{
    public class Cakal : Hayvan
    {
        public Cakal()
        {

        }
        public override void HareketEt()
        {
            base.HareketEt();
            if (rng >= 0 && rng < 3)
            {
                Konum += 3;
            }
            else if (rng >= 3 && rng < 8)
            {
                Konum += 2;
            }
            else
            {
                Konum -= 4;
                if (Konum < 0) Konum = 0;
            }

        }
    }
}
