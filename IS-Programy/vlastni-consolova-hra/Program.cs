using System;                    // pouzivani veci z knihob´vny system
using System.Collections.Generic; // Používám HashSet -nedovoli zadat dvakrat stejnou hodnotu

class Program
{
    static void Main() //program tu začiná bezet
    {
       //->nazev pouze
        /*Console.Clear();
        Console.WriteLine("=============================");
        Console.WriteLine("     ⚓ SESTŘEL PONORKU     ");
        Console.WriteLine("=============================");
        Console.WriteLine();*/

        Random generator = new Random();

        string again = "a";
        while (again == "a")
        {
            // char = jeden znak, char[] = pole znaků = řádky mapy
            char[] řadky = { 'a', 'b', 'c' };

            // int = celé číslo, int[] = pole čísel = sloupce mapy
            int[] sloupky = { 1, 2, 3 };

            // Náhodná pozice ponorky:
            // vybere random (4 se nepočítá)
            int ponorkaradek = generator.Next(1, 4);

            // vybereme náhodný sloupek (index 0..2)
            char ponorkasloupek = řadky[generator.Next(0, 3)];

            // bool = true/false, sunk říká, jestli už byla ponorka zasažena 
            bool potopena = false;

            // shots = počítadlo pokusu
            int shots = 0;

            // HashSet<string> = zadavane texty nemohou byt duplicitni
            // sem ukládáme všechny pozice, kam už hráč vystřelil
            HashSet<string> pouzite = new HashSet<string>();

            // Herní smyčka: běží, dokud sunk == false
            while (!potopena)
            {
                // poziceponorky = textový klíč tajné pozice ponorky 
                // $ vytvori text kam muzu dat promnene
                string poziceponorky = $"{ponorkaradek}{ponorkasloupek}";

                // Vykreslení mapy -ponorka se zatím neukaze
                //DRAWBORD JE DEFINOVANY NIŽ
                DrawBoard(řadky, sloupky, pouzite, currentGuess: null, showSubmarine: false, submarineKey: poziceponorky);

                Console.WriteLine();
                Console.Write("🧭 Zadej souřadnici útoku  např. 2c: ");

                // ?? "" = když je null, vezmeme prázdný string
                // Trim = odstraní mezery okolo, ToLower = převede na malá písmena
                string tip = (Console.ReadLine() ?? "").Trim().ToLower();

                // TryParseCoord vrátí jako chybu při špatném formátu
                // a i když je to mimo rozsah tzn. i 5k = neplatný formát
                if (!TryParseCoord(tip, out int cislo, out char pismeno))
                {
                    Console.WriteLine("⚠️ Neplatný formát. Zadej souřadnici např. 1a, 2c, 3b.");
                    Pause();
                    continue; // pokračuj na další kolo smyčky
                }

                // key = text souřadnice hráče 
                string vystrel = $"{cislo}{pismeno}";

                //uz jsem sem strelila
                if (pouzite.Contains(vystrel))
                {
                    Console.WriteLine("Sem uz jsi střelil/a");
                    Pause();
                    continue;
                }

                // ulozim pouzity vysterl a zyvsim pocet pokusu
                pouzite.Add(vystrel);
                shots++;

                // zásah = když se shoduje sloupec i řádek
                potopena = (cislo == ponorkaradek && pismeno == ponorkasloupek);

                // Znovu vykreslíme mapu – ukážu aktuální výstřel, a když je zásah, ukážu i ponorku
                DrawBoard(řadky, sloupky, pouzite, currentGuess: vystrel, showSubmarine: potopena, submarineKey: poziceponorky);

                Console.WriteLine();
                if (potopena)
                {
                    // Barvy v konzoli:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"💥 Zásah. Ponorka na {vystrel} je potopená po {shots} výstřelech!");
                    Console.WriteLine("Gratuluji");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("🌊 Vedle! Tady je jen voda.");
                    Console.ResetColor();
                }

                Pause(); // Pauza - přečíst výsledek
            }

            Console.WriteLine();
            Console.Write(" Pro novou hru stiskni a ");
            again = (Console.ReadLine() ?? "").Trim().ToLower();
        }
    }

    static bool TryParseCoord(string input, out int cislo, out char pismeno)
    {
        // TryParseCoord zkus prevest souradnici
        // Tahle metoda zpracuje vstup string a pokusí se z něj udělat souřadnici.
        // Vrací bool:
        // - jo = vstup je ok a navíc je v rozsahu 1–3 a a–c
        // - ne = cokoliv špatně včetně "5k" -> ne

        // out int col  = metoda nastaví sloupec 1/2/3
        // out char row = metoda nastaví řádek  a/c/b

        cislo = 0;
        pismeno = '\0';
        // '\0' = nic

        // Musí být přesně 2 znaky. input = text co hrac zadal, .Length = pocet znaku v textu
        if (input.Length != 2) return false;

        // 1. znak musí být číslice
        // char.IsDigit(input[0]) = se da brat jako otazka je tenhle znak cislo?
        if (!char.IsDigit(input[0])) return false;
        cislo = input[0] - '0'; // '2' -> 2

        // 2. znak musí být písmeno
        if (!char.IsLetter(input[1])) return false;
        pismeno = input[1];

       
        // vše mimo 1–3 a a–c vrací Neplatný formát
        if (cislo < 1 || cislo > 3) return false;
        if (pismeno < 'a' || pismeno > 'c') return false;

        return true;
    }

//toto static void DrawBoard je poze navod pro porgram jak vytvorip planek, je to defnice
//SPUSTI SE AZ DAM PRIKAZ DRAWBOARD
    static void DrawBoard(char[] radky, int[] sloupce, HashSet<string> fired, string? currentGuess, bool showSubmarine, string submarineKey)
    {
        // DrawBoard = vytvori planek nebo mapu idk
        //void = tato metoda mi jan namalije moji mapu
        // fired = všechny už vystřelené pozice
        // currentGuess = aktuální výstřel
        // showSubmarine = když je pravda ukáže ponorku
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("=============================");
        Console.WriteLine("     ⚓ SESTŘEL PONORKU     ");
        Console.WriteLine("=============================");
        Console.ResetColor();
        Console.WriteLine();

        // Vypíšeme hlavičku sloupců
        // foreach = projdi postupně všechny hodnoty
        //cols = pole { 1, 2, 3 }
        //c = proměnná, do které se vždy uloží jedna hodnota
        Console.Write("    "); //ta mezera tam je aby osunula cisilka aby to hezky vycházelo hihi
        foreach (int c in sloupce)
            Console.Write($" {c} "); // vypise mezeru cislo sloupce a mezeru
        Console.WriteLine();

        // Pro každý řádek a b a c mam 3 pole
        //radky = pole { 'a', 'b', 'c' }
        //r = proměnná, do které se postupně uloží:
        //nejdřív 'a' pak 'b' pak 'c'
  
        foreach (char r in radky)
        {
            Console.Write($" {r}  "); //vypise mezeru pismeno mezeru

            foreach (int c in sloupce)
            // foreach = projdi postupně všechny hodnoty, takze ve vysledku bude mit kazda hodnotu 1a 2a 3a 1b 2b 3b 1c 2c 3c
            {
                string key = $"{c}{r}"; //$"{c}{r}" → spojí to do textu

                if (showSubmarine && key == submarineKey)// kdyz jsem tipla spravne policko jak to rndom vybrane programem je to zasah
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("💥 "); // Ponorka zasažená
                }
                else if (currentGuess != null && key == currentGuess)
                //fired obsahuje texty jako "2c"
                //currentGuess je text jako "1a"
                //submarineKey je text jako "3b"
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("🎯 "); // ted strela
                }
                else if (fired.Contains(key))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("🌊 "); // sama voda
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" ~ "); //  moře
                }

                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }

    static void Pause()
    {
        // Pauza na Enter – používáme ReadLine, aby se nemizel první znak dalšího vstupu
        Console.WriteLine();
        Console.Write("➡️ Stiskni Enter pro pokračování...");
        Console.ReadLine();
    }
}
