using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator2.Services
{
    public class CarService
    {


        public string TurnLeft(string direction)
        {
            if (direction == "Norrut")
                direction = "Västerut";
            else if (direction == "Västerut")
                direction = "Söderut";
            else if (direction == "Söderut")
                direction = "Österut";
            else if (direction == "Österut")
                direction = "Norrut";
            return direction;

        }

        public string TurnRight(string direction)
        {

            if (direction == "Norrut")
                direction = "Österut";
            else if (direction == "Österut")
                direction = "Söderut";
            else if (direction == "Söderut")
                direction = "Västerut";
            else if (direction == "Västerut")
                direction = "Norrut";
            return direction;

        }

        public int MoveForward(int fuelAmount)
        {
            return fuelAmount -= 10;
        }

        public int MoveBackward(int fuelAmount)
        {
            return fuelAmount -= 5;
        }

        

        
    }
}
