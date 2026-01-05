string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** obdélník *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Doubravka Dostálová *************");
    Console.WriteLine("************** 13.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte číslo výšky obdélníku: ");
    int vyska;
    while (!int.TryParse(Console.ReadLine(), out vyska))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }
Console.WriteLine();

    Console.Write("Zadejte číslo sirka obdélníku: ");
    int sirka;
    while (!int.TryParse(Console.ReadLine(), out sirka))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

Console.WriteLine();

    for(int i = 1; i<= vyska; i++)
    {
        for(int j = 1; j<= sirka; j++)
        {
            Console.Write(" # ");
        }
        Console.WriteLine();
    }



    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
