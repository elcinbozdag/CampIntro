using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Sabun";
            urun1.UrunFiyati = 26;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Krem";
            urun2.UrunFiyati = 30;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Diş Fırçası";
            urun3.UrunFiyati = 40;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunFiyati);
            }

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " : " + urunler[i].UrunFiyati);
            }

            int x = 0;

            while (x<urunler.Length)
            {
                Console.WriteLine(urunler[x].UrunAdi + " : " + urunler[x].UrunFiyati);
                x++;
            }  
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
    }

}


