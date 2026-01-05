﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("************** MAX A MIN ******************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("********* Doubravka Dostálová *************");
    Console.WriteLine("************** 6.11.2025 ******************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
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
    Console.WriteLine("==========================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}, Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("==========================================================");
    Console.WriteLine();

    // deklarace pole (array)
    int[] myRandNumbs = new int[n];

    // příprava pro využití třídy Random
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(15);
    
    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for(int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0}; ",myRandNumbs[i]);
    }  


    // Hledání maxima, pozice maxima, minima, pozice minima
    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0;
    int posMin = 0;
    
    
    for(int i = 1; i < n ; i++)
    {
        if(myRandNumbs[i] > max)  
        {
            max = myRandNumbs[i];
            posMax = i;
        }
        
        if(myRandNumbs[i] < min)  
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("==========================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice minima: {posMin}");
    Console.WriteLine("==========================================");
    Console.WriteLine();
    

    // Vykreslování přesýpacích hodin
    if(max >= 3)
    {

        Console.WriteLine();    
        Console.WriteLine("==========================================");
        Console.WriteLine();
        Console.WriteLine($"Přesýpací hodiny o velikosti {max}");
        Console.WriteLine();

        // Tento cyklus se stará o to, aby se vykreslil správný počet řádku
        for(int i=0; i < max ;i++)
        {
          int spaces, stars;

          if(i < max / 2) {
            // horní polovina - počet mezer v i-tém řádku
            spaces = i;

            // horní polovina - s každým dalším řádkem ubývají dvě hvězdičky (po jedné z každé strany)
            stars = max - 2*i;
            }
          else {
            // dolní polovina - počet mezer v i-tém řádku                
            spaces = max - i - 1;
            if(max % 2 == 1) {
                stars = 2 * (i - max / 2) + 1;     
                }
            else {
                stars = 2 * (i - max / 2) + 2;     
                }    
            }

          Console.ForegroundColor = ConsoleColor.DarkCyan;   
          // vykreslení správného počtu mezer pro každý řádek
          // sp - space (1 mezera) 
          for(int sp = 0; sp < spaces ; sp++)
            Console.Write(" ");
          
          // vykreslení správného počtu hvězdiček pro každý řádek
          // st = star (1 hvězdička)
          for(int st=0; st < stars; st++)
            Console.Write("*");

          Console.WriteLine();


        } 
        Console.ResetColor();  
    






    }
    else {
        Console.WriteLine("Maximum je menší než 3 => obrazec se nebude vykreslovat!!! ");
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}