using System;
using System.Collections.Generic;

namespace Indexators
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car() {Name = "Ferari", Number= "0001" },
                new Car() {Name = "Ford", Number= "1001" }
            };

            var parking = new Parking();
            foreach(var car in cars)
            {
                parking.Add(car);
            }

            Console.WriteLine(parking["0001"].Name);
            Console.WriteLine(parking["0021"]?.Name);

            Console.ReadLine();
        }
    }
}
