using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cue Sound of Music");

            var moto1 = new Motorcycle("Bobber", BikeType.cruiser);
            var moto2 = new Motorcycle("Billy", BikeType.euro);

            moto1.Accelerate(110);
            moto2.Accelerate(250);
        }
    }
}
