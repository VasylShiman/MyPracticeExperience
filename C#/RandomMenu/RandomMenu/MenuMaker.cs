using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMenu
{
    class MenuMaker
    {
        public Random Randomizer;
        string[] Meats = {"Roast beef","Salami","Turkey","Ham","Pastrami" };
        string[] Condiments={"yellow mustard","brown mustard","mayo","relish" };
        string[] Breads = {"rye","white","wheat","aroll" };
            public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBreads = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " with " + randomCondiments + " on " + randomBreads;
        }
    }
}
