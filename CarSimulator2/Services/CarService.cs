using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator2.Services
{
    internal class CarService
    {
        private int tiredness = 0;
        private string direction = "Norrut";
        private int maxTiredness = 5;
        private int maxTirednessWarning = 8;
        private int maxFuelCapacity = 100;
        private int fuelAmount = 100; // Starta med full bränsletank

        public void TurnLeft()
        {
            Console.WriteLine("Du svänger vänster.");
            if (direction == "Norrut")
                direction = "Västerut";
            else if (direction == "Västerut")
                direction = "Söderut";
            else if (direction == "Söderut")
                direction = "Österut";
            else if (direction == "Österut")
                direction = "Norrut";
            tiredness += 1; // Öka trötthet när bilen svänger
        }

        public void TurnRight()
        {
            Console.WriteLine("Du svänger höger.");
            if (direction == "Norrut")
                direction = "Österut";
            else if (direction == "Österut")
                direction = "Söderut";
            else if (direction == "Söderut")
                direction = "Västerut";
            else if (direction == "Västerut")
                direction = "Norrut";
            tiredness += 1; // Öka trötthet när bilen svänger
        }

        public void MoveForward()
        {
            if (fuelAmount > 0)
            {
                Console.WriteLine("Du kör framåt.");
                fuelAmount -= 10;
                tiredness += 1; // Öka trötthet när bilen kör framåt
            }
            else
            {
                Console.WriteLine("Bensinen är slut. Behöver tankas innan den kan åka vidare.");
            }
        }

        public void MoveBackward()
        {
            if (fuelAmount > 0)
            {
                Console.WriteLine("Du backar.");
                fuelAmount -= 5;
                tiredness += 1; // Öka trötthet när bilen backar
            }
            else
            {
                Console.WriteLine("Bensinen är slut. Behöver tankas innan den kan åka vidare.");
            }
        }

        public void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Du rastar.");
            Console.ResetColor();
            tiredness = 0; // Återställ trötthet när bilföraren rastar
        }

        public void Refuel()
        {
            Console.WriteLine("Du tankar bilen.");
            fuelAmount = maxFuelCapacity; // Fyll på bränsletanken till maxkapacitet
            tiredness += 1; // Öka trötthet när bilen tankas
        }

        public void ShowStatus()
        {
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
        }
    }
}
