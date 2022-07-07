using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    internal class Faceci
    {
        public string imie;
        public int kasa;
        public zaklady obstawienie = new zaklady();

        public RadioButton radio;
        public Label tekst;
        public Faceci()
        {
            obstawienie.Obstwiajacy = this;     
        }
        public void UpdateTekst()
        {
            radio.Text = imie + " ma " + kasa + " zł";
            tekst.Text = obstawienie.ObstawienieOpis();
        }
        public void WyczyscZaklady()
        {
            obstawienie.Kwota = 0;
            obstawienie.PiesNumer = 0;
        }
        public bool Obstaw(int Kwota, int WygranPies)
        {
            if (kasa >= Kwota)
            {
                obstawienie.Kwota = Kwota;
                obstawienie.PiesNumer = WygranPies;
                UpdateTekst();
                return true;
            }
            else
            {
                MessageBox.Show(imie + " nie ma wsarczająco pieniędzy");
                return false;
            }
        }
        public void Zbierz(int wygrany)
        {
            kasa += obstawienie.wyplata(wygrany);
        }
    }
}
