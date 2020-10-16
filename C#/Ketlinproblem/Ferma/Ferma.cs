using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Ferma
    {
        private int numberOfCows;
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } set { feedMultiplier = value; } }
        public int BagsOfFeed { get; private set; }

        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
            public Ferma(int numberOfCows, int feedMultiplier)
                {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
                }
    }
}
