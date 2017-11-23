using System;
using System.Collections.Generic;



namespace Hüttensammlung.Highscore
{
    /// <summary>
    /// Helper für Spiel Highscore
    /// </summary>
    static class Helper
    {
        /// <summary>
        /// Erstellt eine Liste mit Rundenzeiten
        /// </summary>
        /// <returns></returns>
        public static List<Rundendauer> ErstelleRundenzeiten()
        {
            List<Rundendauer> listeDauer = new List<Rundendauer>();

            Rundendauer halbeStund = new Rundendauer("Halbe Stunde", 30);
            Rundendauer Stund = new Rundendauer("Eine Stunde", 60);
            Rundendauer eineinhalbStund = new Rundendauer("Eineinhalb Stunden", 90);
            Rundendauer zweiStund = new Rundendauer("Zwei Stunden", 120);

            listeDauer.Add(halbeStund);
            listeDauer.Add(Stund);
            listeDauer.Add(eineinhalbStund);
            listeDauer.Add(zweiStund);

            halbeStund = null;
            Stund = null;
            eineinhalbStund = null;
            zweiStund = null;

            return listeDauer;
        }
    }
}
