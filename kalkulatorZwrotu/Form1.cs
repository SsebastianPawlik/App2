using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorZwrotu
{
    public partial class Form1 : Form
    {
        // KM = kilometers/kilometry
        public int KMTraveled, startKM1, endKM1;
        public double stawka = 0.39;
        public double kwota;
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            endKM1 = Convert.ToInt32(endKM.Value);
            startKM1 = Convert.ToInt32(startKM.Value);
            KMTraveled = endKM1 - startKM1;
            if (startKM1 == endKM1)
            {
                MessageBox.Show("Początkowy stan licznika musi być mniejszy niż końcowy");
            }
            else
            {
                kwota = KMTraveled * stawka;
                label4.Text = kwota.ToString() + " zł";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            endKM1 = Convert.ToInt32(endKM.Value);
            startKM1 = Convert.ToInt32(startKM.Value);
            KMTraveled = endKM1 - startKM1;
            MessageBox.Show(KMTraveled + " Kilometrów", "Przebyta odległość");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
