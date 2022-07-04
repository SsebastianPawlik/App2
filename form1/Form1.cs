using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(enableCheckbox.Checked == true)
            {
                if(lableToChange.Text =="Z prawej")
                {
                    lableToChange.Text = "Z lewej";
                    lableToChange.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    lableToChange.Text = "Z prawej";
                    lableToChange.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                lableToChange.Text = "Możliwość zmiany tekstu wyłaczona";
                lableToChange.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
