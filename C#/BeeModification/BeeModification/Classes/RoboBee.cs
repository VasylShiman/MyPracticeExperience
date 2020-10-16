using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeModification.Classes
{
    class RoboBee: Robot, Interfaces.IWorker
    {
        private int shiftsToWork;

        private int shiftsWorked;

        public int ShiftsLeft

        { get { return shiftsToWork - shiftsWorked; } }
        public string Job { get; private set; }

        public void DoThisJob(string job, int shiftsToWork) {}// возвращаемое значение или bool

        public void WorkOneShift() {}
    }

}
}
