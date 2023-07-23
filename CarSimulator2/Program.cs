using CarSimulator2.Models;
using CarSimulator2.Services;
using System;

namespace MenuExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            bool running = true;
            int tiredness = 0;
            string direction = "Norrut";
            int maxTiredness = 5;
            int maxTirednessWarning = 8;
            int fuelAmount = 100; // Starta med full bensintank
            var user = new RandomUserName();
            var driverService = new DriverService();
            var carService = new CarService();
            user = await driverService.GetRandomUserDataAsync();

            while (running)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName}\r\nVälj en handling:");
               
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
                        direction = carService.TurnLeft(direction);
                        tiredness = driverService.GetDriverTiredness(tiredness); // Öka trötthet när bilen svänger
                        break;
                    case "2":
                        Console.WriteLine("Du svänger höger.");
                        direction = carService.TurnRight(direction);
                        tiredness = driverService.GetDriverTiredness(tiredness); // Öka trötthet när bilen svänger
                        break;
                    case "3":
                        if (fuelAmount > 0)
                        {
                            Console.WriteLine("Du kör framåt.");
                            fuelAmount = carService.MoveForward(fuelAmount);
                            tiredness = driverService.GetDriverTiredness(tiredness); // Öka trötthet när bilen kör framåt
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Bensinen är slut. Behöver tankas innan den kan åka vidare.");
                            Console.ResetColor();
                        }
                        break;
                    case "4":
                        if (fuelAmount > 0)
                        {
                            Console.WriteLine("Du backar.");
                            fuelAmount = carService.MoveBackward(fuelAmount);
                            tiredness = driverService.GetDriverTiredness(tiredness); // Öka trötthet när bilen backar
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
                        tiredness = driverService.Rest(); // Återställ trötthet när bilföraren rastar
                        Console.ResetColor();
                        break;
                    case "6":
                        Console.WriteLine("Du tankar bilen.");
                        fuelAmount = driverService.Refuel(); // Fyll på bensintanken till maxkapacitet
                        tiredness = driverService.GetDriverTiredness(tiredness); // Öka trötthet när bilen tankas
                        break;
                    case "7":
                        running = false;
                        Console.WriteLine("Programmet avslutas.");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }

                Console.WriteLine("Trötthet: " + tiredness);
                Console.WriteLine("Riktning: " + direction);
                Console.WriteLine("Bensinmängd: " + fuelAmount);

                if (tiredness >= maxTiredness && tiredness < maxTirednessWarning)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Varning: Föraren börjar bli trött. Ta en rast snart!");
                    Console.ResetColor();
                }
                else if (tiredness >= maxTirednessWarning)
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