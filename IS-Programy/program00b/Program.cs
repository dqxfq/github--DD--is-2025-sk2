﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********** Generátor pseudonáhodných čísel *************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("************* Doubravka Dostálová ******************");
    Console.WriteLine("************** 6.11.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int pocet;
    while (!int.TryParse(Console.ReadLine(), out pocet))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
    }


    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dolnimez; // Dolní mez
    while (!int.TryParse(Console.ReadLine(), out dolnimez))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }



    Console.Write("Zadejte horní mez (celé číslo): ");
    int hornimez; // Horní mez
    while (!int.TryParse(Console.ReadLine(), out hornimez))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }


    Console.WriteLine();
    Console.WriteLine("==========================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}, Horní mez: {2}", pocet, dolnimez, hornimez);
    Console.WriteLine("==========================================================");
    Console.WriteLine();

    // deklarace pole (array)
    int[] cisla = new int[pocet];

    // příprava pro využití třídy Random
    Random generator = new Random();
    //Random myRandNumb = new Random(15);
    
    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for(int i = 0; i < pocet ; i++)
    {
        cisla[i] = generator.Next(dolnimez, hornimez+1);
        Console.Write("{0}; ",cisla[i]);

    }  



    Console.WriteLine();
    Console.WriteLine("==========================================================");
    again = Console.ReadLine();

}