using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriManager
    {
       public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Kişi eklendi : " + musteri.MusteriAdi);

        }

        public void Listele (Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriId);
                Console.WriteLine(musteri.MusteriYas);
            }
        }
       

       

    }
}
