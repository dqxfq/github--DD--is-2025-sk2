string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********* TROJUHEKNÍK PRAVOUHLY ************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Doubravka Dostálová *************");
    Console.WriteLine("************** 13.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte číslo výšky a šířky trojúhelníku : ");
    int rozmer;
    while (!int.TryParse(Console.ReadLine(), out rozmer))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

for (int i = 1; i <= rozmer; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }


    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
