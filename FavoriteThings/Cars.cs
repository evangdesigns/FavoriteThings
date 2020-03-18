using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Cars
    {
        public string Name { get; set; }
        public CarType CarType { get; set; }
        public int TopSpeed { get; set; }

        public Cars(string name, CarType bikeType)
        {
            Name = name;
            CarType = bikeType;
            Initializer();
        }
        public void Initializer()
        {
            if (CarType == CarType.sedan || CarType == CarType.SUV)
            { Console.WriteLine($"{Name} says,'VROOM!!"); }
            else { Console.WriteLine($"{Name} says,'ZOOM ZOOM!!"); }

        }

        public void Accelerate(int topSpeed)
        {
            Console.WriteLine($"{Name} accelerates to {topSpeed}mph");
        }
    }

    enum CarType
    {
        sports,
        sedan,
        SUV,
    }
}
