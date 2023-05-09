
string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";

//array-dizi

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java" };


for (int i = 0; i < kurslar.Length   ; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("For bitti.");

foreach (string kurs in kurslar)
{
    Console.WriteLine();
}
Console.WriteLine("Sayfa sonu-footer");