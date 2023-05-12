using System;


namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classları genel olarak ikiye ayırabiliriz. 1-İçerisinde özellik barınıran classlar. 2-İçerisinde operasyon/metot barındıran classlar.

            Product product1=new Product();
            product1.Id= 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;


            //Aşağıdaki şekilde de nesne üretebiliyoruz.
            Product product2 = new Product {Id=2, CategoryId=5, UnitInStock=5, ProductName="Kalem", UnitPrice=35};

            //PascalCase   //camelCase
            ProductManager productManager=new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //int sayi = 100;
            //productManager.BirSeyYap(sayi);
            //Console.WriteLine(sayi);


            //Yukarıdaki örnekte int sayi, değer tipli bir değişkendir. Bu değişkene 100 değerini atadık. (Değer türlü değişkenler stackte tutulurlar.)
            //Daha sonra bu değeri managerdaki BirSeyYap metoduna parametre olarak gönderdik ve bu değeri ekrana yazdırdık. 
            //Sonrasında managerda yapılan yeni değer ataması burayı etkilemiyor. Çünkü biz onun değerini aldık ve değişkenle işimiz bitti.


            //Diğer örnekte product nesnesi referans türlü bir değişken olduğu için biz Add metoduna onun değerini değil adresini göndermiş oluyoruz aslında. 
            //Dolayısıyla sonradan bu nesnede yapılan değişiklik bizim son değerimizi etkiliyor.

            productManager.Topla2(3,6);
            int toplamsayi= productManager.Topla(5, 9);

            Console.WriteLine(toplamsayi*2);
        }
    }

}