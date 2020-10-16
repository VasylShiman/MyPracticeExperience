using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ketlinproblem
{
    class BirthdayParty: Party
    {
        
        
        
        public string CakeWriting { get; set; }
            public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting) 
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
            }
        private int ActualLenght
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLenght())
                    return MaxWritingLenght();
                else
                    return CakeWriting.Length;
            } 
        }
        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }
        private int MaxWritingLenght()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }
            public bool CakeWritingTooLong
            {
                get
                {
                if (CakeWriting.Length > MaxWritingLenght())
                    return true;
                else
                    return false;
                }
            }
        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecorations;
        }
        public override  decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40M + ActualLenght * .25M;
                else
                    cakeCost = 75M + ActualLenght * .25M;
                return totalCost + cakeCost;
            }
        }
    }
}
