﻿Random rnd = new Random();
int hedef = rnd.Next(1, 100);

Console.Write("Sayı seçiniz: ");

int sayi = int.Parse(Console.ReadLine());

while (sayi != hedef)

{
    
    
    if (sayi < hedef)
    {
    Console.WriteLine("Daha büyük rakam giriniz");
    }

    else 
    {
    Console.WriteLine("Daha küçük rakam giriniz");
    }
     sayi = int.Parse(Console.ReadLine());

}

Console.Write("Tebrikler ");

int toplam = 0;
for (int i = 1 ; i <= 100; i++)
{
    toplam = toplam + i;


}
Console.WriteLine(toplam);