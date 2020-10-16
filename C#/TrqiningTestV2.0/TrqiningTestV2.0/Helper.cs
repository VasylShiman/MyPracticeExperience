using System;


namespace TrqiningTestV2._0
{
    public static class Helper
    {
    public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }


        public static Road CreateRoad(this Road road, int min, int max)
        {
            var rnd = new Random();
            road.Number = "km" + rnd.Next(min, max);
            road.Lenght = rnd.Next(1, 100);
            return road;
        }
    }
}
