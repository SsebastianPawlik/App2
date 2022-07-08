namespace KrystynaUrodziny
{
    internal class Urodziny
    {
        public int KosztObiadu = 25;
        public int IloscOsob { get; set; }
        public bool Dekoracje { get; set; }
        public string NapisCiasto { get; set; }
        public Urodziny(int iloscOsob, bool dekoracje, string napisCiasto)
        {
            IloscOsob = iloscOsob;
            Dekoracje = dekoracje;
            NapisCiasto = napisCiasto;
        }
        public bool Opcja { get; set; }
        public bool NapisCiastoZbytDlugi
        {
            get
            {
                if (NapisCiasto.Length > MaksymalnaDlugosc())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Urodziny(int iloscOsob, bool dekoracje, bool opcja)
        {
            IloscOsob = iloscOsob;
            Dekoracje = dekoracje;
            Opcja = opcja;
        }
        private decimal KosztDekoracji()
        {
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
        private decimal KosztObiaduNaOsobe()
        {
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
        public decimal Koszt
        {
            get
            {
                decimal KoszRazem = KosztDekoracji();
                KoszRazem += ((KosztObiaduNaOsobe() + KosztObiadu) * IloscOsob);
                decimal KosztCiasta;
                if (RozmiarCiasta() == 20) {
                    KosztCiasta = 40 + AktualnaDlugosc * 0.25M;
                }
                else
                {
                    KosztCiasta = 75 + AktualnaDlugosc * 0.25M;
                }
                return KoszRazem + KosztCiasta;
            }
        }
        private int AktualnaDlugosc
        {
            get
            {
                if (NapisCiasto.Length > MaksymalnaDlugosc())
                {
                    return MaksymalnaDlugosc();
                }
                else
                {
                    return NapisCiasto.Length;
                }
            }
        }
        private int RozmiarCiasta()
        {
            if (IloscOsob <= 4)
            {
                return 20;
            }
            else
            {
                return 40;
            }
        }
        private int MaksymalnaDlugosc()
        {
            if (RozmiarCiasta() == 8)
            {
                return 16;
            }
            else
            {
                return 40;
            }
        }
    }
}

