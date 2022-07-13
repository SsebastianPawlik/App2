using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomu
{
    internal class OutSideWithDoor : Outside, IHasExteriorDoor
    {
        public string DoorDescryption { get; private set; }
        public Location DoorLocation { get; set; }
        public OutSideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            this.DoorDescryption = doorDescription;
        }
        public override string Descrption
        {
            get
            {
                return base.Descrption + " Widzisz teraz " + DoorDescryption + ".";
            }
        }
    }
}
