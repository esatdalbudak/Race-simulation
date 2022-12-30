using System;
using System.Collections.Generic;
using System.Text;

namespace YarismaTest
{
    public class SalyanBot : Robot
    {
        public SalyanBot()
        {

        }

        public override void HareketEt()
        {
            base.HareketEt();
            Konum += 1;
        }
    }
}
