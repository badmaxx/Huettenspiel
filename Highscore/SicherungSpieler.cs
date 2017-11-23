using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hüttensammlung.Highscore
{
    /// <summary>
    /// Sicherung der Spieler
    /// </summary>
    public class SicherungSpieler
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public SicherungSpieler()
        { }

        /// <summary>
        /// Liste der Spieler
        /// </summary>
        public List<Spieler> Spielerliste { get; set; }
    }
}
