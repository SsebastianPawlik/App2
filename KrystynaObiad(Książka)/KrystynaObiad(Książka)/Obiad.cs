using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrystynaObiad_Książka_
{
    internal class Obiad
    {
        private int LiczbaOosob;
        public decimal iloscOsob;
        public decimal KosztNaOsobe = 25;
        public decimal KosztDekoracji;
        public decimal kosztOpcji;
     

        
        public void OpcjaZdrowa(bool opcjaZdrowa)
        {
            if (opcjaZdrowa)
            {
                kosztOpcji = 5;
            }
            else
            {
                kosztOpcji = 20;
            }
        }
        
        public void ObliczonyKosztDekoracji(bool OpcjaDekoracji)
        {
            if (OpcjaDekoracji)
            {
                KosztDekoracji = (iloscOsob * 15) + 50;
            }
            else
            {
                KosztDekoracji = (iloscOsob * 7.5M) + 30;
            }
        }
        public decimal KosztObiadu(bool opcjaZdrowa)
        {
            decimal KosztFinalny = KosztDekoracji + ((kosztOpcji + KosztNaOsobe) * iloscOsob);
            if (opcjaZdrowa)
            {
                return KosztFinalny * 0.95M;
            }
            else
            {
                return KosztFinalny;
            }
        }
        public void UstawieniaImprezy(int ludzie, bool OpcjaDekoracji)
        {
            iloscOsob = ludzie;
            ObliczonyKosztDekoracji(OpcjaDekoracji);
        }

        public int LiczbaOsob()
        {
            return LiczbaOosob;
        }

    }
}
