using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hüttensammlung.Highscore
{
    /// <summary>
    /// Bestleistung
    /// </summary>
    public class Bestleistung
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public Bestleistung()
        { }

        /// <summary>
        /// Konstruktor der befüllt
        /// </summary>
        /// <param name="anzahl"></param>
        /// <param name="datum"></param>
        /// <param name="dauer"></param>
        public Bestleistung(int anzahl, DateTime datum, int dauer)
        {
            Anzahl = anzahl;
            Datum = datum;
            DauerRunde = dauer;
        }

        /// <summary>
        /// Getränke
        /// </summary>
        public string Getränk { get; set; }

        /// <summary>
        /// Datum des Triumphes
        /// </summary>
        public DateTime Datum { get; set; }

        /// <summary>
        /// Anzahl Getränke
        /// </summary>
        public int Anzahl { get; set; }

        /// <summary>
        /// Dauer der Runde
        /// </summary>
        public int DauerRunde { get; set; }
    }
}
