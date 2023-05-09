using System;

namespace KampIntro
{
    class  Program
    {
        static void Main(string[] args)
        {
            //type safety (Tip güvenliği) : Tanımladığımız değişkenin başına onun hangi tipte olduğunun yazılmasıdır. C# ve Java dillerinde bu durum daha sıkıdır. 
            //Do not repeat yourself : Kendini tekrarlama.
            string kategorietiketi = "Kategoriler";
            //Buradaki kategorietiketi bir değer tutucudur. Yani bir takma addır(alias).
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            Console.WriteLine(kategorietiketi);
            //Eğer değişkende tutulan değer değiştirilirse onun kullanıldığı her yerde gerekli değişiklik yapılmış olur. Diğer türlü olursa her sayfaya ayrı ayrı gidip o değişikliği yapmamız gerekirdi.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
        }    
    }
}


