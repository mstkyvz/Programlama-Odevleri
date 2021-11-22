for (int i = 0; i < 5; i++)
{
    int asal = 1;
    Console.WriteLine("Sayıyı Girin :");
    int sayi = Convert.ToInt16(Console.ReadLine());
    if (sayi == 1 || sayi < 1) //girilen sayının 1'den büyük olup olmadığı kontrol ediliyor
    {
        Console.WriteLine("Girdiğiniz sayı pozitif ve 1'den büyük olmalı");
    }
    else
    {
        for (int x = 2; x < sayi; x++) //2'den girilen sayıya kadar döngü açılıyor
        {
            if (sayi % x == 0) asal = 0; //sayı kendisine kadar olan sayılardan herhangi birine bölünürse asal değildir
        }
        if (asal == 0)
        {
            Console.WriteLine("sayı asal değil");
        }
        else
        {
            Console.WriteLine("sayı asal ");
        }
    }
}
Console.ReadLine();
