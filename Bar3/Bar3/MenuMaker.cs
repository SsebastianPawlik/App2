using System;

namespace Bar3
{
    internal class MenuMaker
    {
            public Random Randomizer;

            string[] Meats = { "Pieczona wołowina", "Salami", "Indyk", "Szynka", "Karkówka" };
            string[] Condiments = {"Zółta musztarda", "brąowa musztarda", "musztarda miodowa",
            "majonez", "przyprawa","sos francuski"};
            string[] Bread = {"Chleb ryżowy", "Chleb biały", "Chleb zbożowy","pumpernikiel",
            "Chleb włoski","bułka"};
        
        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Bread[Randomizer.Next(Bread.Length)];

            return randomMeat + ", " + randomCondiments + ", " + randomBread;
        }
    }

}
