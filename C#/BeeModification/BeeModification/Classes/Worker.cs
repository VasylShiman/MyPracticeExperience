using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeModification
{
     class Worker: Bee
    {
        public Worker (string[] jobsICanDo,double weightMg): base (weightMg)
        {
            this.jobsICanDo = jobsICanDo;
        }
        private string currentJob = "";
        public string CurrentJob
            
        {
            get
            {
                return currentJob;
            }
        }
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        private const double honeyUnitPerShiftWorked = .65;
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;


        public override double HoneyConsumptionRate()
        {
           double consume = base.HoneyConsumptionRate();
            consume += shiftsWorked * honeyUnitPerShiftWorked;
            return consume;
        }

        public bool DoThisJob(string job, int numberOfShifts)
            {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
                for(int i= 0 ; i < jobsICanDo.Length; i++)
                {
                    if (jobsICanDo[i] == job)
                    {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                    }
                
                }
            return false;
            }
            
        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            shiftsWorked++;
           if (shiftsWorked > shiftsToWork)
            {
                shiftsToWork = 0;
                shiftsWorked = 0;
                currentJob = "";
                return true;
            }
            else
            {
                return true;
            }
        }

    }
}
