using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomu
{
    internal class Outside : Location
    {
        private bool hot;
        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }
        public override string Descrption
        {
            get
            {
                string NewDescrption = base.Descrption;
                if (hot)
                    NewDescrption += " Tutaj jest bardzo gorąco.";
                return NewDescrption;
            }
        }
    }
}
