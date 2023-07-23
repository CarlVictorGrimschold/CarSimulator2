using System;

namespace MenuExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int trötthet = 0;
            string riktning = "Norrut";
            int maxTrötthet = 5;
            int maxTrötthetVarning = 8;
            int maxBensinKapacitet = 100;
            int bensinMängd = maxBensinKapacitet; // Starta med full bensintank

            while (running)
            {
                Console.WriteLine("Välj en handling:");
                Console.WriteLine("1. Sväng Vänster");
                Console.WriteLine("2. Sväng Höger");
                Console.WriteLine("3. Kör framåt");
                Console.WriteLine("4. Backa");
                Console.WriteLine("5. Rasta");
                Console.WriteLine("6. Tanka bilen");
                Console.WriteLine("7. Avsluta");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Du svänger vänster.");
                        if (riktning == "Norrut")
                            riktning = "Västerut";
                        else if (riktning == "Västerut")
                            riktning = "Söderut";
                        else if (riktning == "Söderut")
                            riktning = "Österut";
                        else if (riktning == "Österut")
                            riktning = "Norrut";
                        trötthet += 1; // Öka trötthet när bilen svänger
                        break;
                    case "2":
                        Console.WriteLine("Du svänger höger.");
                        if (riktning == "Norrut")
                            riktning = "Österut";
                        else if (riktning == "Österut")
                            riktning = "Söderut";
                        else if (riktning == "Söderut")
                            riktning = "Västerut";
                        else if (riktning == "Västerut")
                            riktning = "Norrut";
                        trötthet += 1; // Öka trötthet när bilen svänger
                        break;
                    case "3":
                        if (bensinMängd > 0)
                        {
                            Console.WriteLine("Du kör framåt.");
                            bensinMängd -= 10;
                            trötthet += 1; // Öka trötthet när bilen kör framåt
                        }
                        else
                        {
                            Console.WriteLine("Bensinen är slut. Behöver tankas innan den kan åka vidare.");
                        }
                        break;
                    case "4":
                        if (bensinMängd > 0)
                        {
                            Console.WriteLine("Du backar.");
                            bensinMängd -= 5;
                            trötthet += 1; // Öka trötthet när bilen backar
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Bensinen är slut. Behöver tankas innan den kan åka vidare.");
                            Console.ResetColor();
                        }
                        break;
                    case "5":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Du rastar.");
                        Console.ResetColor();
                        trötthet = 0; // Återställ trötthet när bilföraren rastar
                        
                        trötthet = 0; // Återställ trötthet när bilföraren rastar
                        Console.ResetColor();
                        break;
                    case "6":
                        Console.WriteLine("Du tankar bilen.");
                        bensinMängd = maxBensinKapacitet; // Fyll på bensintanken till maxkapacitet
                        trötthet += 1; // Öka trötthet när bilen tankas
                        break;
                    case "7":
                        running = false;
                        Console.WriteLine("Programmet avslutas.");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }

                Console.WriteLine("Trötthet: " + trötthet);
                Console.WriteLine("Riktning: " + riktning);
                Console.WriteLine("Bensinmängd: " + bensinMängd);

                if (trötthet >= maxTrötthet && trötthet < maxTrötthetVarning)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Varning: Föraren börjar bli trött. Ta en rast snart!");
                    Console.ResetColor();
                }
                else if (trötthet >= maxTrötthetVarning)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("VARNING: Föraren är extremt trött! Ta en rast omedelbart!");
                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }
    }
}