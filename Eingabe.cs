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
    public partial class Eingabe : Form
    {
        private SicherungSpieler _sicherungSpieler;

        private string _speichernameSpieler = Path.Combine("Data", "Spieler.xml");
        private string _getränk;
        private Ansicht _runde;
        private bool _rundeLäuft = false;
        private Typ _spieltyp = Typ.Spieler;
        private int _rundenzeit = 60;		//Standardwert für Runde auf eine Stunde setzen


        public Eingabe()
        {
            InitializeComponent();
            CbGetränk.DataSource = Enum.GetValues(typeof(Getränke));            
        }

        private void BtnNeuerSpieler_Click(object sender, EventArgs e)
        {
            Dialog neuerSpieler = new Dialog(_spieltyp);

            if (DialogResult.OK == neuerSpieler.ShowDialog())
            {
                Spieler neu = new Spieler(neuerSpieler.Vorname, neuerSpieler.Nachname);
                neu.Eintragstyp = _spieltyp;
                neu.ID = _sicherungSpieler.Spielerliste.Count;
                LbSpieler.Items.Add(neu);
                _sicherungSpieler.Spielerliste.Add(neu);
            }
        }

        /// <summary>
        /// Löscht diesen Spieler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LbSpieler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Zu löschende Spieler links auswählen");
            }

            else
            {
                _sicherungSpieler.Spielerliste.RemoveAll(sp => sp == ((Spieler)LbSpieler.SelectedItem));
                LbSpieler.Items.RemoveAt(LbSpieler.SelectedIndex);
            }
        }

        /// <summary>
        /// Fügt einen neuen Spieler zu Runde hinzu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHinzu_Click(object sender, EventArgs e)
        {
            if (LbSpieler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Einen Spieler links auswählen");
            }

            else
            {
                ((Spieler)LbSpieler.SelectedItem).Anzahl = 0;
                LbAktuelleSpieler.Items.Add(LbSpieler.SelectedItem);
                LbSpieler.Items.RemoveAt(LbSpieler.SelectedIndex);
                _sicherungSpieler.Spielerliste.RemoveAll(sp => sp == (Spieler)LbSpieler.SelectedItem);
            }
        }

        /// <summary>
        /// Löscht Spieler aus der Runde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLöschen_Click(object sender, EventArgs e)
        {
            if (LbAktuelleSpieler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Einen Spieler rechts auswählen");
            }

            else
            {
              
                    ((Spieler)LbAktuelleSpieler.SelectedItem).Anzahl = 0;
                    LbSpieler.Items.Add(LbAktuelleSpieler.SelectedItem);
                    LbAktuelleSpieler.Items.RemoveAt(LbAktuelleSpieler.SelectedIndex);
                
            }
        }


        /// <summary>
        /// Event wenn rechte lb der Index geändert wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbAktuelleSpieler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbAktuelleSpieler.SelectedItem != null)
            {
                Spieler ausgewählt = (Spieler)LbAktuelleSpieler.SelectedItem;
                LblSpieler.Text = ausgewählt.Name;
                NudAnzahl.Value = ausgewählt.Anzahl;
                if (_rundeLäuft)
                {
                    GbAktualisieren.Enabled = true;
                }
            }
            else
            {
                LblSpieler.Text = "-";
                GbAktualisieren.Enabled = false;
            }
        }

        /// <summary>
        /// Bestätigt Änderung und aktualisiert ansicht
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBestätigen_Click(object sender, EventArgs e)
        {
            if (LbAktuelleSpieler.SelectedItem != null)
            {
                if (MessageBox.Show("Anzahl ändern?", "Bestätigung", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ((Spieler)LbAktuelleSpieler.SelectedItem).AktuellesGetränk = _getränk;
                    ((Spieler)LbAktuelleSpieler.SelectedItem).Anzahl = (int)NudAnzahl.Value;

                    Spieler[] tempList = LbAktuelleSpieler.Items.Cast<Spieler>().ToArray();
                    Array.Sort(tempList);

                    for (int i = 0; i < tempList.Length; i++)
                    {
                        tempList[i].Platzierung = i + 1;
                    }
                    
                    if (_runde != null)
                    {
                        //Neueste Spielstände updaten
                        int index =
                        _sicherungSpieler.Spielerliste.FindIndex(sp => sp.ID == ((Spieler)LbAktuelleSpieler.SelectedItem).ID);
                        _sicherungSpieler.Spielerliste[index] = ((Spieler)LbAktuelleSpieler.SelectedItem);
                        _runde.UpdateList(tempList,ErzeugeBesten());
                    }

                    LbAktuelleSpieler.Items.Clear();
                    LbAktuelleSpieler.Items.AddRange(tempList);

                    tempList = null;
                }
                else
                {
                    MessageBox.Show("Kein Eintrag rechts ausgewählt");
                }
            }            
            GbAktualisieren.Enabled = false;
            LblSpieler.Text = "-";
        }

        /// <summary>
        /// Bestenliste erzeugen
        /// </summary>
        /// <returns> Platz 1 - 3 als verwertbaren String</returns>
        private string[] ErzeugeBesten()
        {
            List<Spieler> temp = new List<Spieler>();
            string[] rückgabe = new string[3];       

            foreach (Spieler sp in _sicherungSpieler.Spielerliste)
            {
                if (sp.Bestleistungen.Find(lst => lst.Getränk == _getränk) != null && sp.Eintragstyp == _spieltyp)
                {                    
                    temp.Add(sp);
                }            
            }

            temp = temp.OrderByDescending(sp => sp.Bestleistungen[sp.Bestleistungen.FindIndex(lst => lst.Getränk == _getränk)].Anzahl).ToList();

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    rückgabe[i] = "Platz " + (i + 1) + " : " + temp[i].Name + " " + temp[i].Bestleistungen[temp[i].Bestleistungen.FindIndex(lst => lst.Getränk == _getränk)].Anzahl +
                    " am " + temp[i].Bestleistungen[temp[i].Bestleistungen.FindIndex(lst => lst.Getränk == _getränk)].Datum.ToShortDateString();
                }
                return rückgabe;
            }
            catch
            {

                for (int i = 0; i < 3; i++)
                {
                    rückgabe[i] = "Keine Bestenliste vorhanden";
                }
                return rückgabe;
            }
            
        }


        /// <summary>
        /// Liste laden beim öffnen der Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Eingabe_Load(object sender, EventArgs e)
        {
            LadeListe();
        }


        /// <summary>
        /// Lädt links die Liste der vorhandenen Mitglieder
        /// </summary>
        private void LadeListe()
        {
            LbSpieler.Items.Clear();
            _sicherungSpieler = XML.Load<SicherungSpieler>(_speichernameSpieler);

            if (_sicherungSpieler == null)
            {
                _sicherungSpieler = new SicherungSpieler();
                _sicherungSpieler.Spielerliste = new List<Spieler>();
            }
            else
            {
                LbSpieler.Items.Clear();
                foreach (Spieler sp in _sicherungSpieler.Spielerliste)
                {
                    if(sp.Eintragstyp == _spieltyp)
                        LbSpieler.Items.Add(sp);
                }
            }        
        }

        /// <summary>
        /// Schließt das Programm und speichert die Spieler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSchließen_Click(object sender, EventArgs e)
        {
            if (BeendeProgramm())
                Application.Exit();
        }

        /// <summary>
        /// Startet eine neue Runde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (LbAktuelleSpieler.Items.Count > 1)
            {
                _rundeLäuft = true;
                _getränk = CbGetränk.Text;

                _runde = new Ansicht(CbGetränk.Text, _spieltyp, _rundenzeit);
                _runde.UpdateList(LbAktuelleSpieler.Items.Cast<Spieler>().ToArray(), ErzeugeBesten());
                _runde.Show();

                foreach (Control ctl in GbRunde.Controls)
                {
                    if (ctl.Name != BtnBeenden.Name)
                    {
                        ctl.Enabled = false;
                    }
                
                }
                this.Text = "Eingabe - Aktuell ist ein Spiel am laufen";
            }
            else
            {
                MessageBox.Show("Mindestens 2 Mitspieler müssen vorhanden sein!");            
            }            
        }

        /// <summary>
        /// Beendet diese Runde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBeenden_Click(object sender, EventArgs e)
        {
            if (_rundeLäuft)
            {
                if (DialogResult.Yes == MessageBox.Show("Soll diese Runde beendet werden?", "Beenden", MessageBoxButtons.YesNo))
                {
                    _runde.Close();
                    _rundeLäuft = false;
                    this.Text = "Eingabe";
                    LbSpieler.Items.AddRange(LbAktuelleSpieler.Items);
                    LbAktuelleSpieler.Items.Clear();

                    foreach (Control ctl in GbRunde.Controls)
                    {
                        ctl.Enabled = true;
                    }

                    BestenlisteErsteller ersteller = new BestenlisteErsteller(_sicherungSpieler, _getränk, _spieltyp);
                }
            }
            else
            {
                MessageBox.Show("Es gibt kein Spiel das beendet werden kann!");
            }
        }

        /// <summary>
        /// Prüft ob Programm beendet werden aknn
        /// </summary>
        /// <returns>true kann beendet werden, false nicht</returns>
        private bool BeendeProgramm()
        {
            if (_rundeLäuft)
            {
                MessageBox.Show("Zuerst das aktuelle Spiel beenden!");
                return false;
            }
            foreach (Spieler sp in _sicherungSpieler.Spielerliste)
            {
                sp.Anzahl = 0;
                sp.Platzierung = 0;
            }
            _sicherungSpieler.Save(_speichernameSpieler);
            return true;
        
        }


        /// <summary>
        /// Auswahl zwischen Team und Spieler Spiel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbSpieler_CheckedChanged(object sender, EventArgs e)
        {
            LbAktuelleSpieler.Items.Clear();
            _sicherungSpieler.Save(_speichernameSpieler);
            if (RbSpieler.Checked)
            {
                _spieltyp = Typ.Spieler;
                BtnNeuerSpieler.Text = "Neuer Spieler";
                BtnDelete.Text = "Lösche Spieler";
                LblAuswahl.Text = "Ausgewählter Spieler:";

            }
            else
            {
                _spieltyp = Typ.Team;
                BtnNeuerSpieler.Text = "Neues Team";
                BtnDelete.Text = "Lösche Team";
                LblAuswahl.Text = "Ausgewähltes Team:";            
            }

            LadeListe();
        }

        /// <summary>
        /// Fängt schließen ab falls Runde läuft
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Eingabe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BeendeProgramm())
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
        
        
        void LbSpielerMouseDoubleClick(object sender, MouseEventArgs e)
        {
        	if(LbSpieler.SelectedItem != null)
        	{
                ((Spieler)LbSpieler.SelectedItem).Anzahl = 0;
                LbAktuelleSpieler.Items.Add(LbSpieler.SelectedItem);
                LbSpieler.Items.RemoveAt(LbSpieler.SelectedIndex);
                _sicherungSpieler.Spielerliste.RemoveAll(sp => sp == (Spieler)LbSpieler.SelectedItem);
        	}
        }
    }
}
