using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace JanekXAML
{
    internal class MenuMaker
    {
        private Random random = new Random();
        private List<string> meats = new List<string>()
        {"Pieczona wołowina","Salami","Indyk","Szynka","Karkówka"};
        private List<string> condiments = new List<string>()
        { "żółta musztarda","brązowa musztarda","musztarda miodowa","majonez","przyprawa","sos francuski"};
        private List<string> breads = new List<string>()
        { "chleb ryżowy","chleb biały","chleb zbożowy","pumpernikiel","chleb włoski","bułka"};
        public ObservableCollection<MenuItem> Menu { get; private set; }
        public DateTime GeneratedDate { get; private set; }
        public int NumberOfItems { get; set; }
        public MenuMaker()
        {
            Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
            UpdateMenu();
        }
        private MenuItem CreateMenuItem()
        {
            string randomMeat = meats[random.Next(meats.Count)];
            string randomCondiment = condiments[random.Next(condiments.Count)];
            string randomBreads = breads[random.Next(breads.Count)];
            return new MenuItem(randomMeat, randomCondiment, randomBreads);
        }
        public void UpdateMenu()
        {
            Menu.Clear();
            for(int i = 0; i<NumberOfItems; i++)
            {
                Menu.Add(CreateMenuItem());
            }
            GeneratedDate = DateTime.Now;
        }
    }
}
