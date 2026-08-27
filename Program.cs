
Console.WriteLine("----MENÜ----");
Console.WriteLine("1. - Merhaba de");
Console.WriteLine("2. - Saati Göster");
Console.WriteLine("3. - Çıkış");
Console.Write("Seçiminiz: ");

int secim = int.Parse(Console.ReadLine());

switch (secim)

{
    
    case 1:
Console.WriteLine("Merhaba Burak");

break;

case 2: 

Console.WriteLine(DateTime.Now);

break;

case 3:
 Console.WriteLine("Program sonlandırılıyor");

 break;

default:

Console.WriteLine("Geçersiz seçim");

break;
}