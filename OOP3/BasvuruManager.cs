using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection yaptık burada. Yani metodun hangi kredi türü olacağını yani kullanacağı KrediManagerın ne olacağını ve hangi loglayıcı olacağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) //Buradaki Interface diğer manager classlarına kalıtım verdiği için onların hepsinin referansını tutabilir. O sebeple ben buraya interfacei gönderiyorum ki hangi classı gönderirsem onun içindeki hesapla metodunu çalıştırabileyim. 
        {
            krediManager.Hesapla();
            foreach (var loggerSevice in loggerServices)
            {
                loggerSevice.Log();
            }
            
        }

        public void KrediOnBilgilerindirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
