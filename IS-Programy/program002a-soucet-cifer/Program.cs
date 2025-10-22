using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej celé číslo: ");
        int cislo = int.Parse(Console.ReadLine());

        int soucet = 0;
        int soucin = 1;
        int n = Math.Abs(cislo);

        if (n == 0)
        {
            soucet = 0;
            soucin = 0;
        }
        else
        {
            while (n > 0)
            {
                int cifra = n % 10;
                soucet += cifra;
                soucin *= cifra;
                n /= 10;
            }
        }

        Console.WriteLine($"Součet číslic: {soucet}");
        Console.WriteLine($"Součin číslic: {soucin}");
    }
}