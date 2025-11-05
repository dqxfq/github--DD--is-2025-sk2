﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpis číselné řady *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Doubravka Dostálová *************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }








    Console.WriteLine("Zadejte cele cislo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte cislo A znovu: ");
    }
    Console.WriteLine("Pro opakovani programu stisknete klavesu a");
    again = Console.ReadLine();
    Console.WriteLine("Zadejte cele cislo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte cislo B znovu: ");
    }
    Console.WriteLine(Zadejte cele cislo C:);
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte cislo C znovu: ");
    }

}
int pom;
//Checeme seřadit čísla vzestupně
if (a > b > c)
{
    pom = a;
    a = b;
    b = pom;
}
{
    if (a > c)
    {
        pom = a;
        a = c;
        c = pom;
    }
    if (b > c)
    {
        pom = b;
        b = c;
        c = pom;
    }
}
Console.WriteLine("================================");
Console.WriteLine("Seřazená čísla: {a}, {b}, {c}");
Console.WriteLine("================================");
