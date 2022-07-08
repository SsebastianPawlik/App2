using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrstynaObiadV2
{
    internal class Obiad
    {
        public int KosztObiadu = 25;
        public int IloscOsob {get; set;}
        public bool Dekoracje {get; set;}
        public bool Opcja { get; set; }
        public Obiad(int iloscOsob, bool dekoracje, bool opcja)
        {
            IloscOsob = iloscOsob;
            Dekoracje = dekoracje;
            Opcja = opcja;
        }
        private decimal KosztDekoracji() {
            decimal KosztDekoracji;
            if (Dekoracje)
            {
                KosztDekoracji = (IloscOsob * 15) + 50;
            }
            else
            {
                KosztDekoracji = (IloscOsob * 7.5M) + 30;
            }
            return KosztDekoracji;
        }
        private decimal KosztObiaduNaOsobe() {
            decimal kosztObiaduOpcja;
                if (Opcja)
            {
                kosztObiaduOpcja = 5;
            }
            else
            {
                kosztObiaduOpcja = 20;
            }
            return kosztObiaduOpcja;
        }
        public decimal Koszt { get {
                decimal KoszRazem = KosztDekoracji();
                KoszRazem += ((KosztObiaduNaOsobe() + KosztObiadu) * IloscOsob);
                if (Opcja) { KoszRazem *= 0.95M; }
                return KoszRazem;
            } }
    }
}
