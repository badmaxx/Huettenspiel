using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hüttenspiel
{
    public enum Typ
    {
        Spieler,
        Team
    }


    public class Spieler : IComparable
    {
        private int _platzierung, _anzahl;
        Bestleistung _temp;

        public Spieler()
        { }

        public Spieler(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
            Anzahl = 0;
            Bestleistungen = new List<Bestleistung>();
        }

        public int ID { get; set; }

        public string Vorname { get; set; }

        public string Nachname { get; set; }

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

                    if (_temp == null)
                    {
                        _temp = new Bestleistung();
                        _temp.Anzahl = 0;
                    }

                    if (Anzahl > _temp.Anzahl)
                    {
                        Bestleistungen.Remove(_temp);
                        _temp.Anzahl = Anzahl;
                        _temp.Datum = DateTime.Now;
                        _temp.Getränk = AktuellesGetränk;
                        Bestleistungen.Add(_temp);
                    }
                }
            }
        }

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

        public int LetztePlatzierung
        {
            get;
            set;
            //get
            //{
            //    if (Platzierung == 0)
            //        return 1000;
            //    else
            //        return _letztePlatzierung;
            //}
            //set
            //{
            //    _letztePlatzierung = value;
            //}
        }

        public Typ Eintragstyp { get; set; }

        public string AktuellesGetränk { get; set; }

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
        public class SicherungSpieler
        {
            public SicherungSpieler()
            { }

            public List<Spieler> Spielerliste { get; set; }
        }


        public class Bestleistung
        {
            public Bestleistung()
            { }

            public Bestleistung(int anzahl, DateTime datum)
            {
                Anzahl = anzahl;
                Datum = datum;
            }

            public string Getränk { get; set; }

            public DateTime Datum { get; set; }

            public int Anzahl { get; set; }
              
          
        }
    
 }
