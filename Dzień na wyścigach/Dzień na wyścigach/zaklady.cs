using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzień_na_wyścigach
{
    internal class zaklady
    {
            public int Kwota;
            public int PiesNumer;
            public Faceci Obstwiajacy;

        public string ObstawienieOpis()
        {
            if ((Kwota >= 5) && (Kwota <= 15))
            {
                return Obstwiajacy.imie + " obstawił " + Kwota + " zł" + " na psa: " + PiesNumer;
            }
            else
            {
                return Obstwiajacy.imie + " nie zawar zakładu";
            }
            
        }

        public int wyplata(int wygrany)
        {
            if(wygrany == PiesNumer)
            {
                return Kwota;
            }
            else
            {
                return Kwota -= Kwota;
            }
        }
    }
}
