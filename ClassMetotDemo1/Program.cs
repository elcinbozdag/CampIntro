using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Elçin";
            musteri1.MusteriId = 566;
            musteri1.MusteriYas = 20;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Türkü";
            musteri2.MusteriId = 123;
            musteri2.MusteriYas = 20;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriId);
                Console.WriteLine(musteri.MusteriYas);
            }


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Listele(musteriler);


        }
    }
}
