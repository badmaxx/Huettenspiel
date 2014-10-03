using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hüttenspiel
{
	/// <summary>
	/// Dialog um Nachrichten anzuzeigen
	/// </summary>
	public partial class Mitteilung : Form
	{
        public Font Schrift { get; set; }

        public HorizontalAlignment Ausrichtung { get; set; }

		public Mitteilung()
		{
			InitializeComponent();
		}

        /// <summary>
        /// Nachricht die angezeigt wird
        /// </summary>
        public string Nachricht
        {
            get
            {
                return RtbMitteilung.Text;
            }
            set
            {
                ErstelleText(value, Schrift);               
            }
        }

        /// <summary>
        /// Text und Schrift auf Rtb einrichten
        /// </summary>
        /// <param name="text">Angezeigter Text</param>
        /// <param name="schrift">Schriftart des Textes</param>
        private void ErstelleText(string text, Font schrift)
        {
            //Text vom oberen Rand weg
            if (!text.StartsWith("\n"))
            {
                text = Environment.NewLine + text;
            }
            RtbMitteilung.Text = text;
            RtbMitteilung.Font = schrift;

            //Text ausrichten
            RtbMitteilung.SelectAll();
            RtbMitteilung.SelectionAlignment = Ausrichtung;
            RtbMitteilung.DeselectAll();

            this.ActiveControl = label1;
        }

        /// <summary>
        /// Method to start the application on the secondary screen
        /// </summary>
        private void ShowOnSecondaryScreen()
        {
            Screen secondary = null;

            if (System.Windows.Forms.SystemInformation.MonitorCount > 1)
            {
                // Zweiten Monitor ermitteln
                secondary = Screen.AllScreens[1];

                //Sollte dummerweise der zweite der Hauptmonitor sein
                //dann den ersten Monitor als Anzeige nehmen
                if (secondary.Primary)
                {
                    secondary = Screen.AllScreens[0];
                }
            }

            if (secondary != null)
            {
                // set the screen location as form location
                this.Location = secondary.Bounds.Location;

                // maximize the window
                this.WindowState = FormWindowState.Maximized;
                // Style entfernen
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            else
            {
                //Falls kein zweiter Monitor da auf dem ersten anzeigen
                this.Location = Screen.AllScreens[0].Bounds.Location;
            }
        }
    

	    /// <summary>
	    /// Form auf zweitem Bildschirm ausgeben
	    /// </summary>
	    /// <param name="sender"></param>
	    /// <param name="e"></param>
		void MitteilungLoad(object sender, EventArgs e)
		{
		    ShowOnSecondaryScreen();
		}
	}
}
