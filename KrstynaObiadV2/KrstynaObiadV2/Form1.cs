using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrstynaObiadV2
{
    public partial class Form1 : Form
    {
        Obiad obiad;
        public Form1()
        {
            InitializeComponent();
            obiad = new Obiad((int)numericUpDown1.Value, checkBox1.Checked, checkBox2.Checked);
            WyswietKosztObiadu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            obiad.Dekoracje = checkBox1.Checked;
            WyswietKosztObiadu();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            obiad.Opcja = checkBox2.Checked;
            WyswietKosztObiadu();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            obiad.IloscOsob = (int)numericUpDown1.Value;
            WyswietKosztObiadu();
        }
        private void WyswietKosztObiadu()
        {
            decimal Koszt = obiad.Koszt;
            label3.Text = Koszt.ToString("c");
        }
    }
}
