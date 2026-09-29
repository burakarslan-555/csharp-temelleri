﻿Console.Write("Notunuzu girin: ");
int not = int.Parse(Console.ReadLine());

   if (not > 100 || not < 0)

   {
    Console.WriteLine("Hatalı not girdiniz");
   }



else if (not >= 90)
{
    Console.WriteLine("Harf notunuz AA");
}

else if (not >= 80 )
{
    Console.WriteLine("Harf notunuz BA");

}
else if (not >= 70 )
{
    Console.WriteLine("Harf notunuz BB");

}
else if (not >= 60 )
{
    Console.WriteLine("Harf notunuz CB");


}
else if (not >= 50 )
{
    Console.WriteLine("Harf notunuz CC");

}
else 
{
    Console.WriteLine("Harf notunuz FF");

}
