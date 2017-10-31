using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace Hüttenspiel
{
    class BestenlisteErsteller
    {
        private SicherungSpieler _spieler;
        private string _getränk;
        private Spieltyp _spieltyp;
        private Rundendauer _rundendauer;

        public BestenlisteErsteller(SicherungSpieler liste, string getränk, Spieltyp spieltyp, Rundendauer rundendauer)
        { 
            _spieler = liste;
            _getränk = getränk;
            _spieltyp = spieltyp;
            _rundendauer = rundendauer;

            SchreibeDatei(ErstelleListe());        
        }


        /// <summary>
        /// Erstellt die Liste der Bestleistungen
        /// </summary>
        /// <returns></returns>
        private List<Tuple<Bestleistung, string>> ErstelleListe()
        {
            List<Spieler> temp = new List<Spieler>();
            List<Tuple<Bestleistung, string>> leistungen = new List<Tuple<Bestleistung, string>>();

            foreach (Spieler sp in _spieler.Spielerliste)
            {
                if (sp.Bestleistungen.Find(lst => lst.Getränk == _getränk) != null && 
                    sp.Eintragstyp == _spieltyp &&
                    sp.Bestleistungen.Find(lst => lst.DauerRunde == _rundendauer.Dauer) != null)
                {                    
                    temp.Add(sp);
                }            
            }

            temp = temp.OrderByDescending(
                sp => sp.Bestleistungen[sp.Bestleistungen.FindIndex(lst => lst.Getränk == _getränk)].Anzahl).ToList();

                for (int i = 0; i < temp.Count; i++)
                {
                    leistungen.Add(new Tuple<Bestleistung, string>(new Bestleistung(
                        temp[i].Bestleistungen[temp[i].Bestleistungen.FindIndex(lst => lst.Getränk == _getränk)].Anzahl,
                        temp[i].Bestleistungen[temp[i].Bestleistungen.FindIndex(lst => lst.Getränk == _getränk)].Datum, 
                        _rundendauer.Dauer),
                        temp[i].Name));

                    //rückgabe.Add( "Platz " + (i + 1) + " : " + temp[i].Name + " " + temp[i].Bestleistungen[temp[i].Bestleistungen.FindIndex(lst => lst.Getränk == _getränk)].Anzahl +
                    //" am " + temp[i].Bestleistungen[temp[i].Bestleistungen.FindIndex(lst => lst.Getränk == _getränk)].Datum.ToShortDateString());
                }
                return leistungen;
          
        }

        /// <summary>
        /// Schreibt die Tabelle 
        /// </summary>
        /// <param name="schreiben">Bestleistung mit Name</param>
        private void SchreibeDatei(List<Tuple<Bestleistung, string>> schreiben)
        {
            string pfad = Path.Combine("Ranglisten",_spieltyp.ToString(), _getränk, _rundendauer.Name);
            string dateiname = "Ewige_Rangliste.txt";           

            if (!Directory.Exists(pfad))
            {
                Directory.CreateDirectory(pfad);            
            }

            StreamWriter ausgabe = new StreamWriter(Path.Combine(pfad, dateiname));

            ausgabe.WriteLine("Ewige Rangliste in der Kategorie " + _spieltyp.ToString() + " mit " +
                _getränk + " (" + _rundendauer.Name + ")");
            ausgabe.WriteLine("Stand: " + DateTime.Now.ToShortDateString());
            ausgabe.WriteLine();

            Tuple<string, string, string, string>[] cases = new Tuple<string, string, string, string>[schreiben.Count];

            for (int i = 0; i < schreiben.Count; i++)
            {
                cases[i] = Tuple.Create((i + 1).ToString(), ((Bestleistung)schreiben[i].Item1).Anzahl.ToString(), schreiben[i].Item2,
                    ((Bestleistung)schreiben[i].Item1).Datum.ToShortDateString());
            }

            IEnumerable<Tuple<string, string, string, string>> Icases = cases;

            ausgabe.WriteLine(Icases.ToStringTable(new[] { "Platz", "Anzahl", "Name", "Datum" },
                 a => a.Item1, a => a.Item2, a => a.Item3, a => a.Item4));

            ausgabe.Close();
        }
    }
}
