using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hüttenspiel
{
    /// <summary>
    /// Spieltypen
    /// </summary>
    public enum Spieltyp
    {
        /// <summary>
        /// Spieler
        /// </summary>
        Spieler,
        /// <summary>
        /// Teams
        /// </summary>
        Team
    }

    /// <summary>
    /// Spieler mit seinen Leistungen
    /// </summary>
    public class Spieler : IComparable
    {
        private int _platzierung, _anzahl;
        Bestleistung _temp;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Spieler()
        { }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="vorname"></param>
        /// <param name="nachname"></param>
        public Spieler(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
            Anzahl = 0;
            Bestleistungen = new List<Bestleistung>();
        }

        /// <summary>
        /// ID des Spielers
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Vorname
        /// </summary>
        public string Vorname { get; set; }

        /// <summary>
        /// Nachname
        /// </summary>
        public string Nachname { get; set; }

        /// <summary>
        /// Anzahl des Getränks
        /// </summary>
        public int Anzahl
        {
            get
            {
                return _anzahl;
            }
            set
            {
                _anzahl = value;

                if (AktuellesGetränk != null)
                {
                    _temp = Bestleistungen.Find(lst => lst.Getränk == AktuellesGetränk);
                    _temp = Bestleistungen.Find(lst => lst.DauerRunde == DauerRunde);

                    if (_temp == null)
                    {
                        _temp = new Bestleistung();
                        _temp.Anzahl = -1;
                    }

                    if (Anzahl > _temp.Anzahl || _temp.Anzahl == -1)
                    {
                        Bestleistungen.Remove(_temp);
                        _temp.Anzahl = Anzahl;
                        _temp.Datum = DateTime.Now;
                        _temp.Getränk = AktuellesGetränk;
                        _temp.DauerRunde = DauerRunde;
                        Bestleistungen.Add(_temp);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Platzierung
        {
            get
            {
                return _platzierung;
            }
            set
            {
                LetztePlatzierung = Platzierung;
                _platzierung = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int LetztePlatzierung { get; set; }

        /// <summary>
        /// Spieltyp
        /// </summary>
        public Spieltyp Eintragstyp { get; set; }

        /// <summary>
        /// Temp für Getränk
        /// </summary>
        public string AktuellesGetränk { get; set; }

        /// <summary>
        /// Temp für Dauer der Runde
        /// </summary>
        public int DauerRunde { get; set; }

        /// <summary>
        /// Liste der Bestleistungen
        /// </summary>
        public List<Bestleistung> Bestleistungen { get; set; }


        /// <summary>
        /// Wenn Anzahl 0 nur namen ausgeben sonst auch anzahl davor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Anzahl == 0)
            {
                return Name;
            }
            else
            {
                return Anzahl + " - " + Name;
            }
        }

        /// <summary>
        /// Erzeuge Namen
        /// </summary>
        public string Name
        {
            get
            {
                return Vorname + " " + Nachname;
            }
        }

        /// <summary>
        /// Nach der Anzahl sortieren absteigend
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is Spieler)
            {
                return((Spieler)obj).Anzahl.CompareTo(this.Anzahl);               
            }

            throw new NotImplementedException();
        }

    }
}
