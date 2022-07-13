using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomu
{
    internal class RoomWithDoor : Room, IHasExteriorDoor
    {
        public string DoorDescryption { get; set; }
        public RoomWithDoor(string name, string decoration, string doorDescryption) : base(name, decoration)
        {
            DoorDescryption = doorDescryption;
        }
        public Location DoorLocation { get; set; }
    }
}
