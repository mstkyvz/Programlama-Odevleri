float sayi1, sayi2;

Console.Write("1.Sayıyı Giriniz : ");
sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.Sayıyı Giriniz : ");
sayi2 = Convert.ToInt32(Console.ReadLine());

Console.Write("\n 1-) Toplama \n 2-) Çıkarma \n 3-) Çarpma \n 4-) Bölme\n");

Console.Write("Hangi 4 işlemi yapmak istediğinizi seçiniz:");
string secenek = Console.ReadLine();

switch (secenek)
{
    case "1":
        Console.WriteLine("Toplama İşleminin Sonucu = " + (sayi1 + sayi2));
        break;
    case "2":
        Console.WriteLine("Çıkarma İşleminin Sonucu = " + (sayi1 - sayi2));
        break;
    case "3":
        Console.WriteLine("Çarpma İşleminin Sonucu = " + (sayi1 * sayi2));
        break;
    case "4":
        Console.WriteLine("Bölme İşleminin Sonucu = " + (sayi1 / sayi2));
        break;
}
Console.ReadKey();