using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hüttenspiel
{
    [Serializable]
    class Runde
    {
        public Runde()
        { }
        
        public List<Spieler> Mitspieler { get; set; }

        public string Getränk { get; set; }

        public DateTime Datum { get; set; }
    }
}
