using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form4
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public void UpdateForm()
        {
            joeCashLable.Text = joe.Name + " ma " + joe.Cash + " zł";
            bobCashLable.Text = bob.Name + " ma " + bob.Cash + " zł";
            bankCashLable.Text = "Bank ma " + bank + " zł";
        }
        public Form1()
        {
            InitializeComponent();
            bob = new Guy() { Cash = 100, Name = "Bob" };
         /*   bob.Name = "Bob";
            bob.Cash = 100;*/

            joe = new Guy() { Cash = 50, Name = "Joe" };
      /*      joe.Name = "Joe";
            joe.Cash = 50;*/

            UpdateForm();
        }

        private void reciveCash_Click(object sender, EventArgs e)
        {
            if(bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada kasy");
            }
        }

        private void GiveCash_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGive_Click(object sender, EventArgs e)
        {
            if(joe.Cash >= 10)
            {
                joe.Cash -= 10;
                bob.Cash += 10;
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Joe biedak nie ma kasy");
            }
        }

        private void bobGive_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                bob.Cash -= 5;
                joe.Cash += 5;
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob biedak nie ma kasy");
            }
        }
    }
}
