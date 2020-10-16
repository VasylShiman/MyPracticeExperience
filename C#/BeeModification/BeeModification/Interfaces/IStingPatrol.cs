using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeModification.Interfaces
{
    interface IStingPatrol: IWorker
    {
        int AllertLevel { get;}
        int StingerLenght { get; set;}

        bool SharpenStinger(int Lenght);
        bool LookForEnemies();
        
        
    }
}
