class Program
{
    static void Main()
    {
        int sonuc = Topla(3, 5);
        Console.WriteLine(sonuc);

        int sonuc2 = Topla(3, 5, 10);
        Console.WriteLine(sonuc2);
    }


    static int Topla(int a, int b)

    {

        return a + b;

    }

    static int Topla(int a, int b, int c)

    {

        return a + b + c;

    }
}

