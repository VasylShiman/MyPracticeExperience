using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeModification
{
    class Bee: Interfaces.IStingPatrol
    {
        public const double HoneyUnitConsumePerMg = 0.25;
        public double WeightMg { get; private set; }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }


        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitConsumePerMg;  
        }
        public int AllertLevel { get; private set; }
        public int StingerLenght { get; set; }
        

        public bool SharpenStinger(int Lenght)
        { }
        public bool LookForEnemies()
        { }
    }

}
