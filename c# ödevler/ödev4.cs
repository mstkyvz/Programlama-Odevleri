Console.Write("Sayıyı Girin:");
double sayi = Convert.ToInt32(Console.ReadLine());
double faktoriyel = 1;

for (int i = 1; i <= sayi; i++)
{
    faktoriyel = faktoriyel * i;
}

Console.WriteLine("{0} sayısının faktöriyeli={1}", sayi, faktoriyel);
Console.ReadKey();