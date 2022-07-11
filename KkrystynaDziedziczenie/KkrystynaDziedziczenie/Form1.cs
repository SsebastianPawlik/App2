using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KkrystynaDziedziczenie
{
    public partial class Form1 : Form
    {
        Urodziny urodziny;
        Obiad obiad;
        public Form1()
        {
            InitializeComponent();
            obiad = new Obiad((int)numericUpDown1.Value, checkBox1.Checked, checkBox2.Checked);
            urodziny = new Urodziny((int)numericUpDown2.Value, checkBox3.Checked, textBox1.Text);
            WyswietlKosztUrodzin();
            WyswietlKosztObiad();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            obiad.IloscOsob = (int)numericUpDown1.Value;
            WyswietlKosztObiad();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            obiad.Dekoracje = checkBox1.Checked;
            WyswietlKosztObiad();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            obiad.Opcja = checkBox2.Checked;
            WyswietlKosztObiad();
        }
        private void WyswietlKosztObiad()
        {
            decimal Koszt = obiad.Koszt;
            label3.Text = Koszt.ToString("c");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            urodziny.IloscOsob = (int)numericUpDown2.Value;
            WyswietlKosztUrodzin();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            urodziny.Dekoracje = checkBox3.Checked;
            WyswietlKosztUrodzin();
        }
        private void WyswietlKosztUrodzin()
        {
            label6.Visible = urodziny.NapisCiastoZbytDlugi;
            decimal Koszt = urodziny.Koszt;
            label8.Text = Koszt.ToString("c");
        }
    }
}
