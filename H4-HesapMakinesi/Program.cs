class Program

{
    static void Main()

    {

        Console.Write("1. sayı: ");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.Write("2. sayı: ");
        int sayi2 = int.Parse(Console.ReadLine());

        Console.WriteLine("---İŞLEM SEÇİNİZ---");

        Console.WriteLine("1-Topla");

        Console.WriteLine("2-Cikar");

        Console.WriteLine("3-Carp");

        Console.WriteLine("4-Bolme");

        Console.Write("Seçiminiz: ");

        int secim = int.Parse(Console.ReadLine());


        switch (secim)

        {

            case 1:
                int sonuc = Topla(sayi1, sayi2);
                Console.WriteLine(sonuc);
                break;

            case 2:


                int sonuc2 = Cikar(sayi1, sayi2);
                Console.WriteLine(sonuc2);

                break;

            case 3:

                int sonuc3 = Carp(sayi1, sayi2);
                Console.WriteLine(sonuc3);

                break;

            case 4:

                if (sayi2 == 0)



                {

                    Console.WriteLine("0'a bölünemez!");

                }
                else
                {
                    double sonuc4 = Bolme(sayi1, sayi2);

                    Console.WriteLine(sonuc4);
                }




                break;

            default:

                Console.WriteLine("Geçersiz değer girdiniz");

                break;

        }



    }

    static int Topla(int sayi1, int sayi2)

    {

        return sayi1 + sayi2;
    }

    static int Cikar(int sayi1, int sayi2)

    {

        return sayi1 - sayi2;
    }

    static int Carp(int sayi1, int sayi2)

    {

        return sayi1 * sayi2;
    }

    static double Bolme(double sayi1, double sayi2)

    {

        return sayi1 / sayi2;
    }
}

