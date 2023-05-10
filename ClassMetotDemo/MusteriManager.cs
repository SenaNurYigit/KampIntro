using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + "Eklendi.");
        }

        public void Listele(Musteri musteri) 
        {
            Console.WriteLine(musteri.Adi + " " + "Listelendi.");
        }

        public void Sil(Musteri musteri) 
        {
            Console.WriteLine(musteri.Soyadi + " " + "Silindi.");
        }
    }
}
