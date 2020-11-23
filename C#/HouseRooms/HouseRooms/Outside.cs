using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRooms
{
    class Outside: Location
    {
        public bool Hot { get => hot; }
        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }
        private bool hot;

        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                //if (hot)
                //    NewDescription += " Очень жарко";

                NewDescription = hot ? NewDescription += " Очень жарко" : base.Description;
                return NewDescription;
                
            }
        }
    }
}
