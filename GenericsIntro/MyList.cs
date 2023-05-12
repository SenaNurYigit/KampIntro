using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    //Buradaki T(Type) bana herhangi bir tip ver ben aşağıyı ona göre yapılandıracağım demek oluyor.
    //Generic Classlarda çalışacağı tipi vermek zorundayız.
    class MyList<T> 
    {
        //Metodun dışında tanımladığımız değişkeni class içindeki tüm metotlarda kullanabiliyoruz. O sebeple buraya tanımladık.
        T[] items; //Bu bir dizi ve dizileri bizim mutlaka newlememiz gerekiyor(Zorunluluk çünkü bu bir referans tip). Bu işlem diziyi oluşturacağımız bir adresi referans etmiş oluyor. Dizi boş bile olsa newlememiz egrekir. Yoksa null referance hatası alırız.
        //Bu diziyi newleme işlemini de class'ı newlediğim esnada yapmam gerekiyor. 

        //Constructor:Classı newlediğimiz yerde başlangıçta otomatik çalışan kod bloğu. ctor+tab+tab yapınca otomatik oluşur. Classla aynı isme sahip olur.
        public MyList()
        {
            items = new T[0];
            //Burada direkt yukarıda tanımladığımız diziyi newlemiş olduk ve sıfır elemanlı bir diziyi referans ettik.
        }
       public void Add(T item)
        {
            //Temporary Array= Geçici Dizi
            T[] tempArray = items;
            items=new T[items.Length+1]; //Newleme yaptığımız an yeni referans numarası alacağı için biz öncelikle üst satırda geçici bir dizide items'ın referans numarasını tutuyoruz. Yoksa her ekleme yaptığımızada eski değerler yok olur, eski referans adresinde kalır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1]= item;    
        }
        public int Length
        {
            get { return items.Length; }
        }
    }
}
