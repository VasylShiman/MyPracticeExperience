using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ketlinproblem
{
    class DinnerParty:Party
    {
        
        public bool Healthyoption { get; set; }
        

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
                NumberOfPeople = numberOfPeople;
                FancyDecorations = fancyDecorations;
                Healthyoption = healthyOption;
        }

       

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (Healthyoption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }
               
        
        public override decimal Cost {

            get {
            decimal totalCost = base.Cost;
                totalCost +=CalculateCostOfBeveragesPerPerson() * NumberOfPeople;
                if (Healthyoption)
                
                    totalCost *= .95M;
                
                return totalCost;
                }   
            
        }
        
    }
}
