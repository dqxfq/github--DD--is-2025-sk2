﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("**** Generátor pseoudonáhodných čísel ******");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Doubravka Dostálová *************");
    Console.WriteLine("************** 6.11.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte počet předgenerovaných čísel: ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet předgenerovaných čísel znovu: ");
    }

 Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound; // Dolní mez
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound; // Horní mez
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }





    Console.WriteLine();
    Console.WriteLine("============================================");
    Console.WriteLine("Zadané hodnoty: ");
    Console.WriteLine("Počet čísel {0}, dolní mez: {1}, horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("============================================");
    Console.WriteLine();

    //deklarace pole (array)
    int[] myRandnumbs = new int[n];

    //příprava pro využitíní třídy random
    Random myRandnumb = new Random();
    //Random myRandnumb = new Random(15);

    //kladná, záporná, nebo nuly
    int negativeNumbs = 0;
    int positiveNumbs = 0;
    int zeros = 0;

    //sudá, nebo lichá
    int evenNumbs = 0;
    int oddNumbs = 0;

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n ;i++)
    {
        myRandnumbs[i] = myRandnumb.Next(lowerBound, upperBound);
        Console.WriteLine(myRandnumbs[i]);
    }


    again = Console.ReadLine() ?? "";

}