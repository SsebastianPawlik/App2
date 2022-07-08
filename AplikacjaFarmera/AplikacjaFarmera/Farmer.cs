using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaFarmera
{
    internal class Farmer
    {
        public int WorkiKarmy { get; private set; }
        private int karmienie;
        public int Karmienie { get { return Karmienie; } }

        private int iloscKrow;
        public int IloscKrow
        {
            get
            {
                return iloscKrow;
            }
            set
            {
                iloscKrow = value;
                WorkiKarmy = iloscKrow * Karmienie;
            }
        }
        public Farmer(int iloscKrow, int karmienie)
        {
            this.karmienie = karmienie;
            IloscKrow = iloscKrow;
        }
    }
}
