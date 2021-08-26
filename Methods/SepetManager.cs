 using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product product) 
        {
            Console.WriteLine("Sepete Eklendi : " + product.Adi);
        
        }


        public void Ekle2(string productAdi, double Fiyati, string Aciklama, int stokAdedi) 
        {
            Console.WriteLine("Sepete Eklendi : " + productAdi + " " + Fiyati);
        }
    }
}
