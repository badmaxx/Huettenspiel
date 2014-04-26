using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hüttenspiel
{
    public partial class Ansicht : Form
    {
        private Typ _spieltyp;
        private string[] _bestenliste;
        private int _bestenlisteAktuell = 0;
        private Logger _log;       

        /// <summary>
        /// Erstellt das Endergebnis in einer temp file
        /// </summary>
        public Mitteilung ErstelleEndergebnis()
        {
            //Ergebnis in eine temp Datei ablegen zur Sicherung   
            StreamWriter ausgabe = new StreamWriter("tempEndergebnis.txt");

            //Tuple erzeugen aller Zeilen
            Tuple<string, string, string>[] cases = new Tuple<string, string, string>[DgvRangliste.Rows.Count];

            //Alle Tuple mit den Werten aus dem DGV füllen
            for (int i = 0; i < DgvRangliste.Rows.Count; i++)
            {
                cases[i] = Tuple.Create((i + 1).ToString(),DgvRangliste.Rows[i].Cells[2].Value.ToString(), 
                        DgvRangliste.Rows[i].Cells[1].Value.ToString());
            }
            //Tuple zu Enumarable machen
            IEnumerable<Tuple<string, string, string>> Icases = cases;
                       
            //Ausgabe String füllen
            string stringAusgabe = (" Endergebnis der letzten Runde " + LblGetränk.Text + ":\n") +
                (Icases.ToStringTable(new[] { "Platz", "Anzahl", "Name" },
                                    a => a.Item1, a => a.Item2, a => a.Item3));
            //Temp Datei füllen 
            ausgabe.WriteLine(stringAusgabe);
            ausgabe.Close();

            //Neue Mitteilung erstellen
            Mitteilung ergebnis = new Mitteilung();
            //Tabelle mit Endergebnis als Mitteilung
            ergebnis.Nachricht = stringAusgabe;          
            return ergebnis;
        }

        /// <summary>
        /// Neue Ansicht laden
        /// </summary>
        /// <param name="getränk">Getränk dieser Runde</param>
        /// <param name="spieltyp">Spieltyp (Einzelspieler oder Teams)</param>
        /// <param name="rundenzeit">Zeit einer Runde</param>
        public Ansicht(string getränk, Typ spieltyp, int rundenzeit)
        {
            InitializeComponent();
            LblGetränk.Text = getränk;
            _spieltyp = spieltyp;
            
            if(spieltyp == Typ.Team)
                DgvRangliste.Columns[1].HeaderText = "Team";

            _log = new Logger();
            _log.ErstelleAutosave(getränk, spieltyp);
        }

        /// <summary>
        /// Spieler in Dgv eintragen und nach Reihenfolge sortieren
        /// </summary>
        /// <param name="liste"></param>
        /// <param name="bestenliste"></param>
        public void UpdateList(Spieler[] liste, string[] bestenliste)
        {
            _bestenliste = bestenliste;
            DgvRangliste.Rows.Clear();

            foreach (Spieler sp in liste)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell platz = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell name = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell anzahl = new DataGridViewTextBoxCell();
                DataGridViewImageCell trend = new DataGridViewImageCell();

                platz.Value = sp.Platzierung;
                name.Value = sp.Name;
                anzahl.Value = sp.Anzahl;
                trend.Value = null;

                if (sp.LetztePlatzierung < sp.Platzierung)
                {
                    trend.Value = Properties.Resources.Pfeil_rot;
                }
                if (sp.LetztePlatzierung > sp.Platzierung)
                {
                    trend.Value = Properties.Resources.Pfeil_grün;
                }
                if (sp.LetztePlatzierung == sp.Platzierung || sp.LetztePlatzierung == 0)
                {
                    trend.Value = Properties.Resources.Pfeillinks;
                }

                row.Cells.AddRange(platz, name, anzahl, trend);
                DgvRangliste.Rows.Add(row);

                DgvRangliste.Update();
                this.Update();
                Application.DoEvents();

                row = null;
            }

            if (this.WindowState != FormWindowState.Maximized)
            {
                this.Width = DgvRangliste.Columns[0].Width + DgvRangliste.Columns[1].Width + DgvRangliste.Columns[2].Width + DgvRangliste.Columns[3].Width + 40;
                this.Height = DgvRangliste.Height + DgvRangliste.ColumnHeadersHeight + DgvRangliste.Location.Y + LblBestenliste.Height;
            }
            
            DgvRangliste.ClearSelection(); 
            //UpdateBestenliste();   
        }        
        
        /// <summary>
        /// Timer für die Restzeit ändern
        /// </summary>
        /// <param name="restzeit"></param>
        public void updateTimer(string restzeit)
        {
        	LblTimer.Text = restzeit;
        	LblTimer.Refresh();
        }
        

        /// <summary>
        /// Method to start the application on the secondary screen
        /// </summary>
        private void ShowOnSecondaryScreen()
        {
            Screen secondary = null;

            // check if there is a secondary screen
            if (Screen.AllScreens.GetUpperBound(0) > 0)
            {
                // get the secondary screen
                secondary = Screen.AllScreens[1];
            }

            if (secondary != null)
            {
                // set the screen location as form location
                this.Location = secondary.Bounds.Location;

                // maximize the window
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        /// <summary>
        /// Hauptanzeige wenn möglich auf zweiten Bildschirm anzeigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ansicht_Load(object sender, EventArgs e)
        {
            ShowOnSecondaryScreen();
        }

        /// <summary>
        /// Ersten 3 der Bestenliste anzeigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerBestenliste_Tick(object sender, EventArgs e)
        {
            LblBestenliste.Text = "Hall of Fame " + _bestenliste[_bestenlisteAktuell];

            if (_bestenlisteAktuell == 2)
            {
                _bestenlisteAktuell = 0;
            }
            else
            {
            	_bestenlisteAktuell++;
            }
            UpdateLog(false);            
        }

       /// <summary>
       /// Erstellt eine aktuelle String Tabelle und schreibt Log
       /// </summary>
       /// <param name="ende">Wenn true: Endergebnis als Überschrift</param>
        private void UpdateLog(bool ende)
        {
            //Tuple erzeugen aller Zeilen
            Tuple<string, string, string>[] cases = new Tuple<string, string, string>[DgvRangliste.Rows.Count];

            //Alle Tuple mit den Werten aus dem DGV füllen
            for (int i = 0; i < DgvRangliste.Rows.Count; i++)
            {
                cases[i] = Tuple.Create((i + 1).ToString(), DgvRangliste.Rows[i].Cells[2].Value.ToString(),
                        DgvRangliste.Rows[i].Cells[1].Value.ToString());
            }
            //Tuple zu Enumarable machen
            IEnumerable<Tuple<string, string, string>> Icases = cases;

            //Ausgabe String füllen
            string tabelle = (Icases.ToStringTable(new[] { "Platz", "Anzahl", "Name" },
                                    a => a.Item1, a => a.Item2, a => a.Item3));

            if (ende)
            {                
                _log.UpdateAutosave("Endergebnis:" + Environment.NewLine + tabelle);
            }
            else
            {
                _log.UpdateAutosave(tabelle);
            }
        
        }

        /// <summary>
        /// Beim Beenden der Runde Logger löschen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ansicht_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateLog(true);
            _log = null;
        }


        //private void UpdateBestenliste()
        //{
        //    string text = "Hall of Fame: ";

        //    for(int i = 0; i < 3; i++)
        //    {
        //        text += _bestenliste[i] + "   ";
        //    }

        //    marqueeLabelBestenliste.Text = text;
        //    int test = TextRenderer.MeasureText(text, marqueeLabelBestenliste.Font).Width;
        //    if (test > marqueeLabelBestenliste.Width)
        //    {
        //        marqueeLabelBestenliste.Width = test;
        //    }
        //}
      

    }
}
