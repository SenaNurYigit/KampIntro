using System;
using System.Collections.Generic;//Listi kullanabilmek için ekledik.

namespace Koleksiyonlar
{

    //ctrl+k + ctrl+c --> Toplu yoruma alma (c=comment)
    //ctrl+k + ctrl+u --> Toplu yorumdan geri alma (u=uncomment)
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string> { "Sena", "Muaz","Mehdi","Banu","Rahmi"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[5]);
            Console.WriteLine(isimler2[0]);
        }
    }

}