using System;
using System.Collections.Generic;
using System.Text;

namespace YarismaTest
{
    public interface IYarismaci
    {
        public string Isim { get; set; }
        public int Konum { get; set; }
        public int YarismaciNo { get; set; }

        void HareketEt();
    }
}
