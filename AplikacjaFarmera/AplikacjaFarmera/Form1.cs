using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaFarmera
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer() { IloscKrow = 15, karmienie = 30 };
            farmer = new Farmer() { 15, 30 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Potrzebne {0} worków do wykarmienia {1} krów", farmer.WorkiKarmy, farmer.IloscKrow);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.IloscKrow = (int)numericUpDown1.Value;
        }
    }
}
