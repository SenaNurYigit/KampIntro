using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
    {
        //Burada birinterfaceten kalıtım alındığı için ilgili interface içindeki metotları burada implement etmek zorundayız. Yani burada onlar kullanılmak zorunda.
        public void BirSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}
