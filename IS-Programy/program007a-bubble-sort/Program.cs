﻿using System.Diagnostics;
using System.Linq.Expressions;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***** Bubble Sort a vykresleni obrazce *****");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*************** Dostálová ***************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();
    
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    Stopwatch myStopwatch = new Stopwatch();

    int compare = 0;
    int change = 0;

    // Algoritmus Bubble sort
    myStopwatch.Start();
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            compare++;
            if (myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int tmp = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = myRandNumbs[j];
                myRandNumbs[j] = tmp;
                change++;
            }
        }
    }
    myStopwatch.Stop();

    // Výpis seřazených čísel
    Console.WriteLine();
    Console.WriteLine("================================");    
    Console.WriteLine();
    Console.WriteLine("Seřazená čísla: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    Console.WriteLine();
    Console.WriteLine($"Počet porovnání: {compare}");
    Console.WriteLine($"Počet výměn: {change}");
    Console.WriteLine("Čas potřebný na seřazení čísel: {0}", myStopwatch.Elapsed);


    // implementace nalezení druhého nejvyššího čísla
    int max = myRandNumbs[0];
    int secondMax = int.MinValue;
    Console.WriteLine($"\nDruhé největší číslo: {secondMax}");

    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] < max && secondMax == int.MinValue)
        {
            secondMax = myRandNumbs[i];
           
        }
    }
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine();
    Console.WriteLine($"\nDruhé největší číslo: {secondMax}");

    // implementace nalezení i-tého nejvyššího čísla 
    int iValue = 3;  // třeba druhá největší

    int actualRank = 1;           // 1. největší je první prvek
    int currentValue = myRandNumbs[0];
    int ithLargest = 0;              // sem uložíme výsledek
    bool found = false;              // zatím nenalezeno

    // Procházíme čísla od druhého prvku
    for (int j = 1; j < n; j++)
    {
        // Zjišťujeme, jestli je aktuální hodnota nová a menší
        // Pokud není menší, je to duplicita => ignorujeme
        // Pokud je menší, znamená to, že jsme narazili na odlišnou hodnotu a tu si uložíme
        if (myRandNumbs[j] < currentValue)
        {
            currentValue = myRandNumbs[j];
            actualRank++;
        }

        // Sledujeme, jestli jsme právě narazili na i-tou hodnotu.
        // Pokud je to i-tá, nastavíme ji (provede se to pouze jednou).
        if (actualRank == iValue && found==false)
        {
            ithLargest = currentValue;
            found = true;
        }
    }
    Console.WriteLine($"i-tá největší hodnota ({iValue}): {ithLargest}\n\n");


    /* Vykreslení obrazce */
    int height = ithLargest;
    int width = ithLargest * 2;

    // 2× horní plný řádek
    for (int r = 0; r < 2; r++)
    {
        for (int i = 0; i < width; i++)
            Console.Write("*");
        Console.WriteLine();
    }

    // vnitřní řádky (výška – 4, protože 2 plné řádky nahoře + 2 dole)
    for (int i = 0; i < height - 4; i++)
    {
        Console.Write("*");                     // levá strana

        for (int j = 0; j < width - 2; j++)     // prázdná mezera
            Console.Write(" ");

        Console.Write("*");                     // pravá strana
        Console.WriteLine();
    }

    // 2× dolní plný řádek
    for (int r = 0; r < 2; r++)
    {
        for (int i = 0; i < width; i++)
            Console.Write("*");
        Console.WriteLine();
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

    }