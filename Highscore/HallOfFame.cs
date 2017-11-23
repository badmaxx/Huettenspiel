using System.Collections.Generic;
using System.Linq;


namespace Hüttensammlung.Highscore
{
    /// <summary>
    /// Erzeuge Hall Of Fame Bestandteile
    /// </summary>
    public class HallOfFame
    {
        /// <summary>
        /// Name 
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Bestleistung für Hall of Fame
        /// </summary>
        public Bestleistung Beste { get; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public HallOfFame(string name, Bestleistung beste)
        {
            Name = name;
            Beste = beste;
        }

        /// <summary>
        /// Erstelle Liste für Hall of Fame
        /// </summary>
        /// <param name="spielerliste"></param>
        /// <param name="rundendauer"></param>
        /// <param name="getränk"></param>
        /// <returns></returns>
        public static List<HallOfFame> Create(List<Spieler> spielerliste, int rundendauer, string getränk)
        {
            List<HallOfFame> hallOfFameListe = new List<HallOfFame>();

            foreach (Spieler sp in spielerliste)
            {
                foreach (Bestleistung best in sp.Bestleistungen)
                {
                    if (best.Getränk == getränk && best.DauerRunde == rundendauer)
                    {
                        hallOfFameListe.Add(new HallOfFame(sp.Name, best));
                    }
                }
            }
            hallOfFameListe = hallOfFameListe.OrderByDescending(sp => sp.Beste.Anzahl).ToList();

            return hallOfFameListe;
        }
    }
}
