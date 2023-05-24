using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Buradaki mirasta ebeveyn Musteri'dir. Musteri sınıfıda olan her şey GercekMusteri'de de vardır demiş oluruz.
    class GercekMusteri : Musteri //Miras(Inheritance) --> Gerçek müşteri bir müşteridir demiş oluyoruz.
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
