using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomu
{
    internal class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public string DoorDescryption { get; private set; }
        public RoomWithDoor(string name, string decoration,string hidingPlaceName, string doorDescryption) 
            : base(name, decoration, hidingPlaceName)
        {
            DoorDescryption = doorDescryption;
        }
        public Location DoorLocation { get; set; }

    }
}
