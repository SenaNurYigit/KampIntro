using System;


namespace OOP2
{
    //OOP2de verilmek istenen mesaj; eğer senin bir base sınıfın varsa o sınıf senin referans tutucundur.
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1=new GercekMusteri();
            musteri1.Id = 1;    
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Sena";
            musteri1.Soyadi = "Yiğit";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12346";
            musteri2.SirketAdi = "Sena A.Ş";
            musteri2.VergiNo = "9876543210";

            Musteri musteri3 = new GercekMusteri(); // new yapıldığını gördüğümüz zaman onu bellekteki referans numarası diye okuyoruz.
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager =new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}