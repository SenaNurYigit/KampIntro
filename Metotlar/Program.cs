
//Metotlar; tekrar tekrar kullanılabilirliği sağlayan kodlar.
//Class'tan b,r değişken
namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama="Amasya elması";
            urun1.StokAdedi = 2;

            Urun urun2= new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 40;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 8;


            Urun[] urunler = new Urun[] { urun1, urun2};

            //C# type-safe (Tip güvenli) bir programlama dilidir. Bu sebeple oluşturduğumuz değişkenlerin başına hangi tipte olduğunu da yazmamız gerekir. 

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("----Metotlar----");


            //Metotlar bana Reusability(tekrar tekrar kullanabilme) özelliği kazandırıyor. Bir metot tanımlayıp o metodu farklı sayfalarda kullanabiliyoruz.
            //Instance örnek
            //Encapsulation(Kapsülleme): Nesne yönelimli programlamada verilerin tek bir birim altında toplanması ve nesne kullanıcısından gereksiz uygulama ayrıntılarının saklanmasıdır.
            SepetManager sepetManager = new SepetManager();
            
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //Örneğin burada nesneye yeni bir özellik daha eklenecek olsa Ekle2 metodunda parantes içine yazdığımız değerlere bir yenisini ekliyoruz. Sonra o metodu çağırdığımız her sayfada da bu değeri yazmamız gerekiyor.
            //Ama eğer biz Ekle metodundaki gibi bir Urun nesnesi/classı üretirsek o neyseye ilgii özelliği de ekleriz ve ekle diyince her sayfaya ayrı ayrı yazmamıza gerek kalmaz.
            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15);
            sepetManager.Ekle2("Karpuz", "diyarbakır karpuzu", 18);
             
        }
    }
}