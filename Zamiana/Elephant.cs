using System.Windows.Forms;

namespace Zamiana
{
    internal class Elephant
    {
        public string Name;
        public int EarSize;
        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy mają " + EarSize + " centymerów szerokości.", Name + " mówi...");
        }

        
    }
}