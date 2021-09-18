using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";

            Console.WriteLine($"Your car is named {c.PetName}? That's odd...");
            c.DisplayStats();

            Car d = new Car();
            d.PetName = "Edd";
            Garage g = new Garage(d,1);
            Console.WriteLine($"Number of Cars: {g.NumberOfCars}");

            Console.WriteLine(g.MyAuto.PetName);

            Console.WriteLine();
        }
    }
}
