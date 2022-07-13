using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomu
{
    internal class OutSideWithHidingPlace : Outside, IHidingPlace
    {
        public string HidingPlaceName { get; private set; }
        public OutSideWithHidingPlace(string name, bool hot, string hidingPlaceName) : base(name, hot)
        {
            HidingPlaceName = hidingPlaceName;
        }
        public override string Descrption
        {
            get
            {
                return base.Descrption + " Ktoś może ukrywać się " + HidingPlaceName + ".";
            }
        }
    }
}
