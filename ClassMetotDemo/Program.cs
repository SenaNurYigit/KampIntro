using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Riv riv de riv riv");

            Musteri musteri= new Musteri();
            musteri.Adi = "Sena";
            musteri.Soyadi = "Yiğit";
            musteri.Yasi = 28;

            Musteri musteri2= new Musteri();
            musteri2.Adi = "Muaz";
            musteri2.Soyadi = "Erdem";
            musteri2.Yasi = 23;


            MusteriManager musteriManager=new MusteriManager();

            musteriManager.Ekle(musteri);
            musteriManager.Listele(musteri2);
            musteriManager.Sil(musteri);
        }

    }


}