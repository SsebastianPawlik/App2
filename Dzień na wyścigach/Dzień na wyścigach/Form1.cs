using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    public partial class Form1 : Form
    {
        Psy[] psy = new Psy[4];
        Faceci[] facet = new Faceci[3];
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            facet[0] = new Faceci() { imie = "Janek", kasa = 50, radio = Janekkasa, tekst = JanekBet };
            facet[1] = new Faceci() { imie = "Bartek", kasa = 75, radio = Bartekkasa, tekst = BartekBet };
            facet[2] = new Faceci() { imie = "Arek", kasa = 45, radio = Arekkasa, tekst = ArekBet };
            facet[0].UpdateTekst();
            facet[1].UpdateTekst();
            facet[2].UpdateTekst();
            JanekBet.Text = facet[0].imie + " nie zwarł jeszcze zakładu";
            BartekBet.Text = facet[1].imie + " nie zwarł jeszcze zakładu";
            ArekBet.Text = facet[2].imie + " nie zwarł jeszcze zakładu";
            label6.Text = "Stawiający";
            MinimalnyZaklad.Text = "Minimalny zakład: " + numericUpDown1.Minimum + " zł";
            InicjalizacjaPsy();

        }

        public void InicjalizacjaPsy()
        {
            for (int i = 0; i<4; i++)
            {
                psy[i] = new Psy()
                {
                    pozcjaStartowa = pictureBox1.Left,
                    dlugoscTrasy = pictureBoxWyscig.Width - pictureBox1.Width,
                    rand = random
                };
            }
            psy[0].zdjecie = pictureBox1;
            psy[1].zdjecie = pictureBox2;
            psy[2].zdjecie = pictureBox3;
            psy[3].zdjecie = pictureBox4;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Janekkasa.Checked)
            {
                facet[0].Obstaw((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
            else if (Bartekkasa.Checked)
            {
                facet[1].Obstaw((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
            else if (Arekkasa.Checked)
            {
                facet[2].Obstaw((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (psy[i].wyscig())
                {
                    timer1.Stop();
                    MessageBox.Show("Wygrał Pies z numerem: " + (i + 1));
                    for (int j = 0; j < 4; j++)
                    {
                        psy[j].wyzerujPozycjeSartowe();
                    }
                    for (int x = 0; x < 3; x++)
                    {
                        facet[x].Zbierz(i + 1);
                        facet[x].WyczyscZaklady();
                        facet[x].UpdateTekst();
                    }
                    groupBox1.Enabled = true;
                }
            }
        }

        private void Janekkasa_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Janek";
        }

        private void Bartekkasa_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Bartek";
        }

        private void Arekkasa_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Arek";
        }
    }
}
