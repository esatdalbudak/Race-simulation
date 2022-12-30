using System;
using System.Collections.Generic;
using System.Text;

namespace YarismaTest
{
    public abstract class Robot : IYarismaci
    {
        public Robot()
        {

        }

        private string isim;
        protected int rng;
        private string yarismaciNo;
        protected int yarismaPisti;

        public string Isim { get; set; }
        public int Konum { get; set; }
        public int YarismaciNo { get; set; }

        public virtual void HareketEt()
        {
            Random random = new Random();
            rng = random.Next(0, 10);
        }
    }
}
