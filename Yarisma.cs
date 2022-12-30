using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace YarismaTest
{
    public class Yarisma
    {
        private List<IYarismaci> yarismacilar;
        private Pist yarismaPisti;
        public Yarisma(string file, int uzunluk)
        {
            yarismaPisti = new Pist(uzunluk);
            yarismacilar = new List<IYarismaci>();
            IEnumerable<string> lines = File.ReadLines(file);

            foreach (var line in lines)
            {
                string[] items = line.Split(' ');

                IYarismaci yarismaci = null;
                if (items[2] == "CAKAL")
                {
                    yarismaci = new Cakal();
                    yarismaci.Isim = items[1];
                    yarismaci.YarismaciNo = int.Parse(items[0]);
                    yarismacilar.Add(yarismaci);
                }
                else if(items[2] == "MEKANIKFIL")
                {
                    yarismaci = new MekanikFil();
                    yarismaci.Isim = items[1];
                    yarismaci.YarismaciNo = int.Parse(items[0]);
                    yarismacilar.Add(yarismaci);
                }
                else if (items[2] == "SALYANBOT")
                {
                    yarismaci = new SalyanBot();
                    yarismaci.Isim = items[1];
                    yarismaci.YarismaciNo = int.Parse(items[0]);
                    yarismacilar.Add(yarismaci);
                }
                else if (items[2] == "DEVEKUSU")
                {
                    yarismaci = new DeveKusu();
                    yarismaci.Isim = items[1];
                    yarismaci.YarismaciNo = int.Parse(items[0]);
                    yarismacilar.Add(yarismaci);
                }

                yarismaPisti.YarismaciEkle(yarismaci);
            }


        }

        public void Baslat()
        {
            while (true)
            {
                foreach (IYarismaci yarismaci in yarismacilar)
                {
                    if(yarismaci is DeveKusu)
                    {
                        if (((DeveKusu)yarismaci).Paralize)
                            continue;
                    }

                    yarismaci.HareketEt();
                    yarismaPisti.KonumGuncelle(yarismaci);

                    if (yarismaci.Konum >= yarismaPisti.PistUzunlugu) return;
                }
            }
        }

        public void KonumlariYazdir()
        {
            yarismaPisti.DurumYazdır();
        }
    }
}
