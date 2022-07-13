using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomu
{
    interface IHasExteriorDoor
    {
        string DoorDescryption { get; }
        Location DoorLocation { get; set; }
    }
}
