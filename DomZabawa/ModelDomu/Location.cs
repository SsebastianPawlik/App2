using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomu
{
    abstract class Location
    {
        public string Name { get; private set; }
        public Location(string name)
        {
            Name = name;
        }
        public Location[] Exits;
        public virtual string Descrption
        {
            get { string descryption = "stoisz w: " + Name + ". Widzisz wejście do następująch loklizacji: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    descryption += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                        descryption += ",";
                }
                descryption += ".";
                return descryption;
            }
        }
    }
}
