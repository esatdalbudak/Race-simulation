using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YarismaTest
{
    public class Pist
    {
        private List<IYarismaci> pist;
        public int PistUzunlugu { get; set; }

        public Pist(int pistUzunlugu)
        {
            pist = new List<IYarismaci>();
            this.PistUzunlugu = pistUzunlugu;
        }


        public void DurumYazdır()
        {
            pist = pist.OrderBy(x => x.Konum).ToList();
            foreach (var item in pist)
            {
                Console.WriteLine($"{item.Konum} :: {item.YarismaciNo}, {item.Isim}");
            }
        }

        public IYarismaci KonumdakiYarismaci(int konum)
        {
            foreach (IYarismaci item in pist)
            {
                if (item.Konum == konum) return item;
            }

            return null;
        }
        public void KonumGuncelle(IYarismaci yarismaci)
        {
            for (int i = 0; i < pist.Count; i++)
            {
                if (yarismaci is DeveKusu)
                {
                    for (int j = 0; j < pist.Count; j++)
                    {
                        if (pist[j] is Cakal || pist[j] is MekanikFil)
                            if (yarismaci.Konum == pist[j].Konum)
                            {
                                Random rand = new Random();

                                if (rand.Next(0, 2) == 0 && pist[j] is Cakal)
                                    ((DeveKusu)yarismaci).Paralize = true;
                                else if (rand.Next(0, 5) == 0 && pist[j] is MekanikFil)
                                    ((DeveKusu)yarismaci).Paralize = true;
                            }
                    }
                }
                else if (yarismaci is SalyanBot)
                {
                    for (int j = 0; j < pist.Count; j++)
                    {
                        if (pist[j] is Cakal || pist[j] is DeveKusu)
                        {
                            if (pist[j].YarismaciNo != yarismaci.YarismaciNo)
                            {
                                if (yarismaci.Konum == pist[j].Konum)
                                {
                                    pist[j].Konum -= 1;
                                }
                            }
                        }
                    }
                }

                if (yarismaci.Konum > PistUzunlugu) yarismaci.Konum = PistUzunlugu;

                if (pist[i].YarismaciNo == yarismaci.YarismaciNo)
                    pist[i] = yarismaci;
            }
        }

        public void YarismaciEkle(IYarismaci yarismaci)
        {
            if (yarismaci != null)
            {
                pist.Add(yarismaci);
            }
        }
    }
}
