using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();   
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // Interfaceler de o interfacei implemente eden sınıfın referans numarasını tutabiliyor. O yüzden üstteki satırla bu satır aynı işleve sahip.

            //TasitKrediManager tasitKrediManager= new TasitKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();

            //KonutKrediManager konutKrediManager=new KonutKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerSevice = new FileLoggerService();

            List<ILoggerService> loggers =new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() };

            BasvuruManager basvuruManager=new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);

            List<IKrediManager> krediler =new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilerindirmesiYap(krediler);

        }
    }
}