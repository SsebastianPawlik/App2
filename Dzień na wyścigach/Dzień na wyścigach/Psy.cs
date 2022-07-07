using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    internal class Psy
    {
        public int pozcjaStartowa;
        public int dlugoscTrasy;
        public int polozenie = 0;
        public Random rand;
        public PictureBox zdjecie;

        public bool wyscig()
        {
            zdjecie.Left += rand.Next(1, 4);
            polozenie = zdjecie.Left;

            if(polozenie >= dlugoscTrasy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void wyzerujPozycjeSartowe()
        {
            polozenie = 0;
            zdjecie.Left = 0;
        }
    }
}
