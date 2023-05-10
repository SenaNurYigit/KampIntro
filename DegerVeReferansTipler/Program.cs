using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Riv riv");

            int sayi1 = 10;   //Bunu sayi1'in değeri 10 diye okuruz. 
            int sayi2 = 30;
            int say1 = sayi2;   //Bunu da sayi1'in değeri sayi2'nin değerine eşittir diye okuruz ve sayi1'e sayi2'nin değerini atarız. Sonra da sayi2'yle olan bağlantıyı koparırız. 
            sayi2 = 65;
            //sayi1=? 30

            int[] sayilar1=new int[] { 10, 20, 30 };    //Bu durumda stackte sayilar1 diye bir ifade (referans değeri) oluşur. Heapte ise [10,20,30] diye bir alan oluşur. Stack'teki sayilar1 ifadesi heapteki adresi işaret(referans) eder.
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;       //Burada sayilar1 artık sayilar2'nin işaret ettiği adresi işaret eder.
            sayilar2[0] = 999;
            //sayilar1[0]=? 999


            //int, decimal, float, double, bool --> değer tipli değişkenler
            //array,  class, interface --> referans tipli değişkenler

            //Değer tipli değişkenler stackte tutuluyor. Referans tipli değişkenler ise heapte tutuluyor. 
        }
    }
}