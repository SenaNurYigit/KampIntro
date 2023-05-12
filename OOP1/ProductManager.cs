using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            // product.ProductName = "Kamera";

            Console.WriteLine(product.ProductName + "Eklendi.");
        }
       // public void BirSeyYap(int sayi)
       // {
        //    sayi = 99;
       // }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            //void olduğunda işlemi yapar, daha sonrasında biz o değeri kullanamayız. Ama  eğer benim programın akışında o değere ihtiyacım varsa voi dememeliyim. return ile bir değer döndürmeliyim.

            Console.WriteLine(sayi1+sayi2);
        }
    }
}
