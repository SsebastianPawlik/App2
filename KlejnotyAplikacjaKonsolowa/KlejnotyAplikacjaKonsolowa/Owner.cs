﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlejnotyAplikacjaKonsolowa
{
    internal class Owner
    {
        private Jewels returnedContents;
        public void ReceiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Dziękuję za zwrócenie klejnotów" + safeContents.Sprakle());
        }
    }
}
