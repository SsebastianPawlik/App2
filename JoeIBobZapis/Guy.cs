using System;
using System.Windows.Forms;

namespace form4
{
    [Serializable]
    internal class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Nie ma wystarczającej ilości pieniędzy, aby oddać" + amount, Name + "powedział...");
                return 0;
            }
        }
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " to nie jest ilość pieniędzy jaką mogą wziąć ", Name + " powiedział...");
                return 0;
            }
        }
    }
}

