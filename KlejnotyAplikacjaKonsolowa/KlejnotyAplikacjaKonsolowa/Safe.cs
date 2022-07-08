using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlejnotyAplikacjaKonsolowa
{
    internal class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "12345";
        public Jewels Open(string combination)
        {
            if(combination == safeCombination)
            {
                return contents; 
            }
            else
            {
                return null;
            }
        }
        public void PickLlock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }
    }
}
