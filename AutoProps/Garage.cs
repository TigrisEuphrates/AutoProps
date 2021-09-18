using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Garage
    {
        public int NumberOfCars { get; set; } = 1;
        public Car MyAuto { get; set; } = new Car();
        public Garage() { }//:this(null,0){}
        public Garage(Car car, int number)
        {
            if (car != null)
            {
                MyAuto = car;
            }
            else
            {
                MyAuto = new Car();
            }
            if (number!=0)
            {
                NumberOfCars = number;
            }
            else
            {
                NumberOfCars = 1;
            }
        }
    }
}
