using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {
        //Burada bir interfaceten kalıtım alındığı için ilgili interface içindeki metotları burada implement etmek zorundayız. Yani burada onlar kullanılmak zorunda.
        public void BirSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
