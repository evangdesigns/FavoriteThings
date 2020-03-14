using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Motorcycle
    {
        public string Name { get; set; }
        public BikeType BikeType { get; set; }
        public int TopSpeed { get; set; }

        public Motorcycle(string name, BikeType bikeType)
        { 
            Name = name;
            BikeType = bikeType;
            Initializer();
        }
        public void Initializer()
        {
            if (BikeType == BikeType.euro || BikeType == BikeType.sport)
            {Console.WriteLine($"{Name} says,'BRAAAAAP!!");}
            else {Console.WriteLine($"{Name} says,'VROOM VROOM!!"); }
            
        }

        public void Accelerate(int topSpeed)
        {
            Console.WriteLine($"{Name} accelerates to {topSpeed}mph");
        }
    }

    enum BikeType
    {
        cruiser,
        sport,
        euro,
    }
}
