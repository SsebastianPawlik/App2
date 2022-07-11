namespace KkrystynaDziedziczenie
{
    internal class Impreza
    {
        public int KosztObiadu = 25;
        public int IloscOsob { get; set; }
        public bool Dekoracje { get; set; }
        public bool Opcja { get; set; }
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
        virtual public decimal Koszt
        {
            get
            {
                decimal KosztRazem = KosztDekoracji();
                KosztRazem += KosztObiadu * IloscOsob;
                if (IloscOsob > 12)
                {
                    KosztRazem += 100;

                    return KosztRazem;
                }
                return KosztRazem;
            }
        }
    }
}
