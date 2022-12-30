using System;
using System.Collections.Generic;
using System.Text;

namespace YarismaTest
{
    class MekanikFil : Robot
    {
        public MekanikFil()
        {

        }

        public override void HareketEt()
        {
            base.HareketEt();
            if (rng >= 0 && rng < 4)
            {
                Konum += 3;
            }
            else if (rng >= 4 && rng < 5)
            {
                Konum += 6;
            }
        }
    }
}
