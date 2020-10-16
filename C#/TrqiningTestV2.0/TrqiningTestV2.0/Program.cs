using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrqiningTestV2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            var input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    if (result.IsEven())
                    {
                        Console.WriteLine($"{result}-четное.");
                    }
                    else
                    {
                        Console.WriteLine($"{result}-нечетное.");
                    }
                }

            var road1 = new Road();
            road1.CreateRoad(10, 50);
            Console.WriteLine(road1);
            Console.ReadLine();
        }
    }
}
