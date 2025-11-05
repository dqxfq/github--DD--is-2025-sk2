using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Název programu ***************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Doubravka Dostálová**************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.WriteLine("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo A znovu: ");
    }

    Console.WriteLine("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo B znovu: ");
    }

    Console.WriteLine();

    int pom;
    // Chci seřadit čísla vzestupně
    if (a > b)
    {
        pom = a;
        a = b;
        b = pom;
        Console.WriteLine("Došlo k prohození proměnných.");
    }
    Console.WriteLine();
Console.WriteLine("=============================================");
    Console.WriteLine($"Seřazená čísla: {a}, {b}");
    Console.WriteLine("=============================================");
Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    string? input = Console.ReadLine();
}