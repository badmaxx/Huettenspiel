using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hüttenspiel
{
    class Rundendauer
    { 
        public string Name { get; }
        public decimal Dauer { get; }       
        
        public Rundendauer(string name, decimal dauer)
        {
            Name = name;
            Dauer = dauer;
        }

        public override String ToString()
        {
            return Name;
        }
    }
}
