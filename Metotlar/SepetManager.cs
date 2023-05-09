using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //Fonksiyon=Metot
        //Naming convention = İsimlendirme kuralı
        //C#'ta eğer normal parantez görürsek orda bir metot çalıştığını anlayabiliriz.
        //Metodun parantezinin içerisine alacağı parametre yazılıyor. Yani aşağıdaki metotta ne ekleyeceğini parantez içine yazıyoruz.
        public void Ekle(Urun urun)
        //void Ekle(Urun urun) bu kısma metodun imzası deniyor. Biz metodu bir yerde çağırırken bu imzaya uygun hareket etmek zorundayız.
        //Burada eğer bir parametre alıyorsa metodu çağırırken o türde bir parametre göndermemiz gerekir.
        {
            //Bu parantez aralığında urun nesnesine ulaşabiliyoruz. Bu nesne üzerinde istediğimiz işlemi yapabiliyoruz.
            Console.WriteLine("Sepete eklendi:" + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler sepete eklendi: " + urunAdi);
        }
    }
}
