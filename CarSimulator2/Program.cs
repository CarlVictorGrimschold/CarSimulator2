using System;

namespace MenuExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

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
                        break;
                    case "2":
                        Console.WriteLine("Du svänger höger.");
                        break;
                    case "3":
                        Console.WriteLine("Du kör framåt.");
                        break;
                    case "4":
                        Console.WriteLine("Du backar.");
                        break;
                    case "5":
                        Console.WriteLine("Du rastar.");
                        break;
                    case "6":
                        Console.WriteLine("Du tankar bilen.");
                        break;
                    case "7":
                        running = false;
                        Console.WriteLine("Programmet avslutas.");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
