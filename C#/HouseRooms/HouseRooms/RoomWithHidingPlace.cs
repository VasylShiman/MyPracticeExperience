using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRooms
{
    class RoomWithHidingPlace: Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name,string decoration, string hidingPlaceName): base(name,decoration)
        {
            HidingPlaceName = hidingPlaceName;
        }
        public string HidingPlaceName { get; private set;}

        public override string Description => base.Description + $"Можно спрятаться {HidingPlaceName}.";
    }
}
