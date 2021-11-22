int toplam = 0;
int adet = 0;
for (int i = 1; i <= 1907; i++)
{
    if ((i % 6 == 0) && (i % 1907 != 0))
    {//sayıların 5e bölünüp 7ye bölünemeyenleri burada ayrıştırıyoruz
        Console.WriteLine(i);//sonuçları ekrana yazıyoruz
        toplam = toplam + i;//yazdığımız kurallara uyan sayıları topluyoruz
        adet++;// yazdığımız kurallara uyan sayıların adeti arttırıyoruz 
    };

}
Console.WriteLine("Sayıların toplamı : " + toplam);
Console.WriteLine("Sayıların adeti : " + adet);
Console.ReadLine();