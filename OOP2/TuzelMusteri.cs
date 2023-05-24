using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class TuzelMusteri : Musteri   //Miras(Inheritance) --> Tüzel müşteri bir müşteridir demiş oluyoruz.
    {
        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }   //Eğer sayısal ifadelerde matematiksel işlemler yapmayacaksak int değil string olarak tanımlarız.


    }
}

