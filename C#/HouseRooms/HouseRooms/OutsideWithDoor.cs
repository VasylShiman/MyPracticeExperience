﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRooms
{
    class OutsideWithDoor: Outside, IHasExteriorDoor
    {
        public  OutsideWithDoor(string name, bool hot, string doorDescription): base(name, hot)
        {
            DoorDescription = doorDescription;
        }


        public string DoorDescription { get; private set; }

        public Location DoorLocation { get; set; }

        public override string Description => base.Description + $"Вы видите {DoorDescription}.";
    }
}
