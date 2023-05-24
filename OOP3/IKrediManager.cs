using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Interfacleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    interface IKrediManager //Okunurluğu arttırmak için isimlendirirken I ile başlarız.
    {
        //Birisi KrediManeger interfaceini kullanırsa bu interface içindeki metodları içermek zorunda olur.
        void Hesapla();
        void BirSeyYap();


    }
}
