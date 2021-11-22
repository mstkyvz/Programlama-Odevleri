int taban, us, sonuc = 1;
Console.Write("Taban Sayısı : ");
taban = Convert.ToInt32(Console.ReadLine());
Console.Write("Kuvveti : ");
us = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= us; i++)
{
    sonuc = sonuc * taban;
}

Console.Write("Tabanı {0} ve kuvveti {1} olan sayının değeri = {2}", taban, us, sonuc);
Console.ReadLine();