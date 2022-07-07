using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrystynaObiad_Książka_
{
    public partial class Form1 : Form
    {
        Obiad obiad;
        public Form1()
        {
            InitializeComponent();
            obiad = new Obiad() { iloscOsob = numericUpDown1.Value };
            obiad.OpcjaZdrowa(false);
            obiad.ObliczonyKosztDekoracji(true);
            KosztObiadu();
        }
        private void KosztObiadu()
        {
            decimal koszt = obiad.KosztObiadu(OpcjaZdrowa.Checked);
            label3.Text = koszt.ToString("c");
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            obiad.iloscOsob = (int)numericUpDown1.Value;
            KosztObiadu();
        }

        private void DdekoracjeFfantazyjne_CheckedChanged(object sender, EventArgs e)
        {
            obiad.ObliczonyKosztDekoracji(DdekoracjeFfantazyjne.Checked);
            KosztObiadu();
        }

        private void OpcjaZdrowa_CheckedChanged(object sender, EventArgs e)
        {
            obiad.OpcjaZdrowa(OpcjaZdrowa.Checked);
            KosztObiadu();
        }

    }
}
