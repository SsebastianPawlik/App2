using System;
using System.Windows.Forms;

namespace KrystynaPrzyjecie
{
    public partial class Form1 : Form
    {
        public double osoba = 25;
        public double iloscOsob;
        public double Soki = 5;
        public double Alkohol = 20;
        public double fantazyjne = 15;
        public double zwykle = 7.5;

        public double kosztOsoby, kosztOpcja, kosztDekoracje, kosztRazem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iloscOsob = (int)numericUpDown1.Value;

            kosztOsoby = iloscOsob * osoba;
            if (radioButton1.Checked)
            {
                kosztOpcja = iloscOsob * Soki;
            }
            else
            {
                kosztOpcja = iloscOsob * Alkohol;
            }
            if (radioButton3.Checked)
            {
                kosztDekoracje = iloscOsob * fantazyjne + 50;
            }
            else
            {
                kosztDekoracje = iloscOsob * zwykle + 30;
            }

            kosztRazem = kosztDekoracje + kosztOpcja + kosztOsoby;

            if (radioButton1.Checked)
            {
                kosztRazem *= 0.95;
            }
            label2.Text = "Łączny koszt: " + kosztRazem + " zł";
        }
    }
}


