using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Car
    {
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public void DisplayStats()
        {
            Console.WriteLine($"Car name: {PetName}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Color: {Color}");
        }
    }
}
