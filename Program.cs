// class Program

// {
//     static void Main()

//     {

//       int para = 100;
//       Harca(ref para);
//       Console.WriteLine(para);


//     }

// static void Harca(ref int miktar)
// {
//     miktar = miktar - 30;


// }

// }

Console.Write("Sayı gir:");
string girdi = Console.ReadLine();

bool basarili = int.TryParse(girdi, out int sayi);

if (basarili)
    Console.WriteLine("Sayı: " + sayi);

else
    Console.WriteLine("Bu sayı değil ki!");