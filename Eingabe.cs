using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace Hüttenspiel
{
    public partial class Eingabe : Form
    {
        private SicherungSpieler _sicherungSpieler;

        private string _speichernameSpieler = Path.Combine("Data", "Spieler.xml");
        private string _getränk;
        private Ansicht _runde;
        private bool _rundeLäuft = false;
        private Spieltyp _spieltyp = Spieltyp.Spieler;
        private int _rundenzeit = 60;		//Standardwert für Runde auf eine Stunde setzen
        private Rundendauer _rundendauer;
        private DateTime endzeit;
        private TimeSpan restzeit;
        private Mitteilung _mitteilung;
        private bool _mitteilungAngezeigt = false, _diashowGestartet = false;
        private Diashow _diashow;

        /// <summary>
        /// Konstruktor Eingabe
        /// </summary>
        public Eingabe()
        {
            InitializeComponent();
            CbGetränk.DataSource = Enum.GetValues(typeof(Getraenke));
            cbRundendauer.DataSource = Helper.ErstelleRundenzeiten();
            lblVersion.Text = "Version: " + Properties.Settings.Default.Version;
        }

        /// <summary>
        /// Anlegen eines neuen Spielers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (MessageBox.Show("Anzahl ändern?", "Bestätigung", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ((Spieler)LbAktuelleSpieler.SelectedItem).HallOfFame = !cbSonstiges.Checked;
                    ((Spieler)LbAktuelleSpieler.SelectedItem).AktuellesGetränk = _getränk;
                    ((Spieler)LbAktuelleSpieler.SelectedItem).DauerRunde = _rundenzeit;
                    ((Spieler)LbAktuelleSpieler.SelectedItem).Anzahl = Convert.ToInt32(NudAnzahl.Value);
                    

                    Spieler[] tempList = LbAktuelleSpieler.Items.Cast<Spieler>().ToArray();
                    Array.Sort(tempList);
                    
                    //Spieler Sortieren
                    for (int i = 0; i < tempList.Length; i++)
                    {
                    	if(i > 0 && tempList[i-1].Anzahl == tempList[i].Anzahl)
                    	{
                    		tempList[i].Platzierung = tempList[i-1].Platzierung;
                    	}
                    	else if (i == 0)
                    	{
                    		tempList[i].Platzierung = 1;
                    	}
                    	else
                    	{
                    		tempList[i].Platzierung = tempList[i-1].Platzierung +1;
                    	}
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
            List<HallOfFame> sortedList;
            string[] rückgabe = new string[3];

            for (int i = 0; i < 3; i++)
            {
                rückgabe[i] = "Keine Bestenliste vorhanden";
            }

            if (!cbSonstiges.Checked)
            {
                sortedList = HallOfFame.Create(_sicherungSpieler.Spielerliste, _rundendauer.Dauer, _getränk);

                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        rückgabe[i] = "Platz " + (i + 1) + " : " + sortedList[i].Name + " " + sortedList[i].Beste.Anzahl +
                        " am " + sortedList[i].Beste.Datum.ToShortDateString();
                    }                    
                }
                catch
                {
                   
                }
            }
            return rückgabe;
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
        /// Motherboard ID abfragen
        /// </summary>
        /// <returns>true passt sonst false</returns>
        private bool CheckMotherboardID()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            string serial = "";
            string pfad = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "hs.id");
            string ausgeleseneID = "";
            foreach (ManagementObject mo in moc)
            {
                serial = (string)mo["SerialNumber"];
            }

            if(File.Exists(pfad))
            {
                StreamReader id = new StreamReader(pfad);
                ausgeleseneID = id.ReadLine();
                id.Close();
            }
            else
            {
                StreamWriter leer = new StreamWriter(pfad);
                leer.Close();
            }

            if (ausgeleseneID == serial)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Fehler beim ausführen des Programmes. Fehlercode:\n" + serial, "Programmfehler", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Startet eine neue Runde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            bool debugmodus = false;
#if DEBUG
            debugmodus = true;
#endif
            if (CheckMotherboardID() || debugmodus)
            {
                //Schließen des Nachrichtenfensters wenn neue Runde gestartet wurde
                if (_mitteilungAngezeigt)
                {
                    CloseMessage();
                }

                if (_diashowGestartet)
                    DiashowEnde();

                if (LbAktuelleSpieler.Items.Count > 1)
                {
                    GbDiashow.Enabled = false;
                    BtnShowMessage.Enabled = false;

                    _rundeLäuft = true;
                    _getränk = CbGetränk.Text;
                    if (cbSonstiges.Checked)
                    {
                        _rundenzeit = Convert.ToInt32(numericUpDownTime.Value);
                        _rundendauer = new Rundendauer("Sonstiges", _rundenzeit);
                    }
                    else
                    {
                        _rundendauer = (Rundendauer)cbRundendauer.SelectedItem;
                        _rundenzeit = _rundendauer.Dauer;
                    }


                    _runde = new Ansicht(CbGetränk.Text, _spieltyp, _rundendauer);
                    _runde.UpdateList(LbAktuelleSpieler.Items.Cast<Spieler>().ToArray(), ErzeugeBesten());
                    _runde.Show();

                    //Endzeit setzen und Timer starten
                    endzeit = DateTime.Now.AddMinutes(_rundenzeit);
                    TimerRundenzeit.Start();

                    foreach (Control ctl in GbRunde.Controls)
                    {
                        ctl.Enabled = false;
                    }

                    BtnBeenden.Enabled = true;

                    this.Text = "Eingabe - Aktuell ist ein Spiel am laufen";
                }
                else
                {
                    MessageBox.Show("Mindestens 2 Mitspieler müssen vorhanden sein!");
                }
            }
            else
            {
                MessageBox.Show("Programm ist nicht lizensiert und kann nicht gestartet werden!", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Beendet diese Runde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBeenden_Click(object sender, EventArgs e)
        {
                if (DialogResult.Yes == MessageBox.Show("Soll diese Runde beendet werden?", "Beenden", MessageBoxButtons.YesNo))
                {                    
                    BeendeRunde();
                }
        }

        /// <summary>
        /// Beendet die aktuelle Runde und aktualisiert die Bestenliste
        /// </summary>
        private void BeendeRunde()
        {
        	TimerRundenzeit.Stop();			//Wenn die Zeit abgelaufen ist, Timer stoppen
        	TimerRundenzeit.Dispose();		//Timer freigeben
            _runde.Close();
            _rundeLäuft = false;
            this.Text = "Eingabe";
            LbSpieler.Items.AddRange(LbAktuelleSpieler.Items);
            LbAktuelleSpieler.Items.Clear();

            foreach (Control ctl in GbRunde.Controls)
            {
                ctl.Enabled = true;
            }

            BtnBeenden.Enabled = false;
            BtnShowMessage.Enabled = true;
            GbDiashow.Enabled = true;

            if (cbSonstiges.Checked == false)
            {
                BestenlisteErsteller ersteller = new BestenlisteErsteller(_sicherungSpieler,
                    _getränk, _spieltyp, _rundendauer);
            }       
        }

        /// <summary>
        /// Prüft ob Programm beendet werden kann
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
                _spieltyp = Spieltyp.Spieler;
                BtnNeuerSpieler.Text = "Neuer Spieler";
                BtnDelete.Text = "Lösche Spieler";
                LblAuswahl.Text = "Ausgewählter Spieler:";

            }
            else
            {
                _spieltyp = Spieltyp.Team;
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
        
        /// <summary>
        /// Spieler per Doppelklick hinzufügen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        /// <summary>
        /// Timer für die Rundenzeit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		void TimerRundenzeitTick(object sender, EventArgs e)
        {
        	restzeit = endzeit.Subtract(DateTime.Now);		//Restzeit berechnen
        	
        	if(restzeit.TotalSeconds < 0)
        	{                
        		//String Tabelle mit Endergebnis erstellen und gleich eine Mitteilung hierfür erzeugen
                _mitteilung = _runde.ErstelleEndergebnis();
               
                _mitteilungAngezeigt = true;
                _mitteilung.Show();										//Fenster anzeigen
                BtnShowMessage.Text = "Nachricht ändern";				//Buttontext ändern
                BtnCloseMessage.Enabled = true;							//Button zum schließen aktivieren
               
                //Runde beenden wenn Mitteilung angezeigt wird
                BeendeRunde();                
        	}
        	else
        	{        		
        		_runde.UpdateTimer(restzeit.Hours.ToString("00")+":"+restzeit.Minutes.ToString("00")+":"+restzeit.Seconds.ToString("00"));       //Genaue Restzeit in Ansicht setzen
				this.numericUpDownTime.Text = restzeit.Minutes.ToString("00");		//Ungefähre Restzeit in Eingabefeld setzen
        	}
        }

        /// <summary>
        /// Erstellt neues Mittelungsfenster
        /// </summary>
        /// <param name="mitteilungstext">Text der Angezeigt werden soll</param>
        /// <param name="font">Schriftart des Textes</param>
        /// <param name="ausrichtung">Ausrichtung des Textes</param>
        private void MitteilungErstellen(string mitteilungstext, Font font, HorizontalAlignment ausrichtung)
        {
            _mitteilung = new Mitteilung();							//neues Fenster erstellen
            _mitteilungAngezeigt = true;							//Merker setzen

            _mitteilung.Schrift = font;                             //Schrift von Fenster setzen
            _mitteilung.Ausrichtung = ausrichtung;                  //Ausrichtung vom Text
            _mitteilung.Nachricht = mitteilungstext;	            //Text für neues Fenster setzen            
            _mitteilung.Show();										//Fenster anzeigen
            BtnShowMessage.Text = "Nachricht ändern";				//Buttontext ändern
            BtnCloseMessage.Enabled = true;							//Button zum schließen aktivieren
        }

        /// <summary>
        /// Text für die Mitteilung abfragen und in neuem Fenster anzeigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		void BtnMitteilungClick(object sender, EventArgs e)
        {
            if (_diashowGestartet)
            {
                DiashowEnde();
            }

        	if(_mitteilungAngezeigt == false)
        	{
	        	MessageDialog mitteilungDialog = new MessageDialog("", new Font(FontFamily.GenericSansSerif,
                20.0F, FontStyle.Regular)); //Eingabedialog aufrufen
	        	
	        	if(DialogResult.OK == mitteilungDialog.ShowDialog())	//Wenn Dialog mit OK bestätigt wurde Text anzeigen
	        	{
                    MitteilungErstellen(mitteilungDialog.MessageText, mitteilungDialog.Schrift, mitteilungDialog.Ausrichtung);	        	
        		}

                mitteilungDialog.Dispose();
        	}
        	else
        	{
        		MessageDialog mitteilungDialog = new MessageDialog(_mitteilung.Nachricht, _mitteilung.Schrift, _mitteilung.Ausrichtung);
        		        		
	        	if(DialogResult.OK == mitteilungDialog.ShowDialog())
	        	{
                    _mitteilung.Ausrichtung = mitteilungDialog.Ausrichtung;
                    _mitteilung.Schrift = mitteilungDialog.Schrift;             //Schrift ändern
                    _mitteilung.Nachricht = mitteilungDialog.MessageText;		//Text ändern                    
        		}

                mitteilungDialog.Dispose();
        	}
        }
        
		/// <summary>
		/// Mitteilung schließen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        void BtnCloseMessageClick(object sender, EventArgs e)
        {
        	if(DialogResult.Yes == MessageBox.Show("Nachricht ausblenden?", "Bestätigung", MessageBoxButtons.YesNo))
        	{
                CloseMessage();
        	}
        }

        /// <summary>
        /// Schließt das Nachrichtenfenster
        /// </summary>
        private void CloseMessage()
        {
            _mitteilung.Close();										//Fenster schließen
            _mitteilungAngezeigt = false;								//Merker zurücksetzen
            BtnShowMessage.Text = "Nachricht anzeigen";					//Buttontext ändern
            BtnCloseMessage.Enabled = false;							//Button zum schließen deaktivieren    
            _mitteilung.Dispose();
        }

        /// <summary>
        /// Bei Doppelklick MsgBox öffnen mit den ersten 2 Monitoren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Eingabe_DoubleClick(object sender, EventArgs e)
        {
            string info = "";
            for (int i = 0; i < 2; i++)
            {
                info = info + Monitorinfo(i);
            }
            MessageBox.Show(info, "Monitorinfo");
        }

        /// <summary>
        /// Info über angeschlossene Monitore als string
        /// </summary>
        /// <param name="monitornummer">Nummer (Achtung Array deklaration)</param>
        /// <returns>Nummer, Name, Auflösung und primärer Monitor</returns>
        private string Monitorinfo(int monitornummer)
        {
            if (System.Windows.Forms.SystemInformation.MonitorCount > monitornummer)
            {
                return "Monitornummer: " + (monitornummer+1)
                    + "\nMonitorname: " + Screen.AllScreens[monitornummer].DeviceName.ToString() 
                    + "\nMonitorauflösung: " + Screen.AllScreens[monitornummer].Bounds.Size.ToString()
                    + "\nPrimärer Monitor: " + Screen.AllScreens[monitornummer].Primary.ToString() 
                    + Environment.NewLine + Environment.NewLine;

            }

            else
            {
                return "Kein " + (monitornummer+1) + ". Monitor vorhanden";
            }
        
        }

      /// <summary>
      /// Diashow starten oder beenden
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void BtnDiashow_Click(object sender, EventArgs e)
        {
            if (_mitteilungAngezeigt)
            {
                CloseMessage();
            }

            if (_diashowGestartet)
            {
                DiashowEnde();
                _diashow.Dispose();
            }
            else
            {
                GbDiashow.Text = "Beenden";
                _diashow = new Diashow();
                _diashow.Init();
                _diashowGestartet = true;
                if (!_diashow.Anzeigen())
                {
                    DiashowEnde();
                    lblDiashow.Text = "Anzeigen nicht möglich!";
                }
                else
                {
                    lblDiashow.Text = "Diashow läuft...";
                }
            }           
        }

        private void cbSonstiges_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSonstiges.Checked)
            {
                numericUpDownTime.Enabled = true;
                cbRundendauer.Enabled = false;
            }
            else
            {
                numericUpDownTime.Value = ((Rundendauer)cbRundendauer.SelectedItem).Dauer;
                numericUpDownTime.Enabled = false;
                cbRundendauer.Enabled = true;                
            }
        }

        private void cbRundendauer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRundendauer.SelectedItem != null)
            {
                numericUpDownTime.Value = ((Rundendauer)cbRundendauer.SelectedItem).Dauer;
            }
        }

        private void NudAnzahl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                BtnBestätigen.PerformClick();
            }
        }

        /// <summary>
        /// Beenden der Diashow
        /// </summary>
        private void DiashowEnde()
        {
            GbDiashow.Text = "Starten";
            _diashow.Close();
            _diashowGestartet = false;
            lblDiashow.Text = "Diashow beendet";
        }

    }
}
