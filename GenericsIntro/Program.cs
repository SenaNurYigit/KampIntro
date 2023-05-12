using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Sena");


            MyDictionary<string> dictionarys=new MyDictionary<string>();
            dictionarys.Add("Muaz");

            Console.WriteLine(isimler.Length);
        }
    }
}