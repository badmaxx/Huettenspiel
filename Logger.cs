﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Hüttenspiel
{
    class Logger
    {
        private string _aktuellerLogpfad;
        /// <summary>
        /// Pfad zu allen Logs
        /// </summary>
        public string Logpfad
        {
            get
            {
                if (!Directory.Exists("Logs"))
                {
                    Directory.CreateDirectory("Logs");
                }
                return "Logs";
            }
        }

        /// <summary>
        /// Erstellt eine neue Logdatei
        /// </summary>
        /// <param name="getraenk">Getränk der Runde</param>
        /// <param name="spieltyp">Spieltyp der Runde</param>
        /// <returns>FileStream auf die aktuelle Logdatei</returns>
        public void ErstelleAutosave(string getraenk, Typ spieltyp)
        {
            string pfad = Path.Combine(Logpfad, spieltyp.ToString(), getraenk.ToString(),DateTime.Now.ToShortDateString());

            if (!Directory.Exists(pfad))
            {
                Directory.CreateDirectory(pfad);
            }

            _aktuellerLogpfad = Path.Combine(pfad, DateTime.Now.ToShortTimeString() + ".txt");
            _aktuellerLogpfad = _aktuellerLogpfad.Replace(':', '_');
                       
        }

        /// <summary>
        /// Schreibt den aktuellen Stand in die Logdatei
        /// </summary>
        /// <param name="file">Stream auf die aktuelle Logdatei</param>
        /// <param name="stringTabelle">Aktuelle Tabelle als String</param>
        public void UpdateAutosave(string stringTabelle)
        {
            StreamWriter ausgabe = new StreamWriter(_aktuellerLogpfad);
            ausgabe.Write(stringTabelle);
            ausgabe.Close();
        }
    }
}
