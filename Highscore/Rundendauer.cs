using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hüttensammlung.Highscore
{
    /// <summary>
    /// Rundendauer
    /// </summary>
    [Serializable]
    public class Rundendauer
    { 
        /// <summary>
        /// Name der Dauer
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Dauer in Minuten
        /// </summary>
        public int Dauer { get; }       
        
        /// <summary>
        /// Leerer Konstruktor für Serialisierung. Nicht benutzen!
        /// </summary>
        public Rundendauer()
        {

        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dauer"></param>
        public Rundendauer(string name, int dauer)
        {
            Name = name;
            Dauer = dauer;
        }

        /// <summary>
        /// To String für Einsatz in ComboBox etc.
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return Name;
        }
    }
}
