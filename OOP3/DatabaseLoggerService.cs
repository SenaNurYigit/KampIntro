using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }

    }
    //class FileLoggerService : ILoggerService
    //{
    //    public void Log()
    //    {
    //        Console.WriteLine("Dosyaya loglandı.");
    //    }

    //}

    //FileLoggerService'i burada oluşturduk. Sonradan FileLoggerservice'e bir kez tıklayıp çıkan ampule tıkladık. Move Type To ....cs seçeneğini seçince bu class için ayrı bir FileLoggerServic.cs class dosyası oluşturuluyor otomatik olarak.
}
