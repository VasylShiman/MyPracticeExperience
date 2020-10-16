using BeeModification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeModification
{
    class NectarStinger: Worker,INectarCollector,IStingPatrol
    {
        public int AllertLevel { get;private set; }
        public int StingerLenght { get; set; }
        public int Nectar { get; set; }

        public bool SharpenStinger(int Lenght)
        { }
        public bool LookForEnemies()
        { }
        public void FindFlowers() { }
        public void GatherNectar() { }
        public void ReturnToHive() { }

    }
}


