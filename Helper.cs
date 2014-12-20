using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hüttenspiel
{
    /// <summary>
    /// Getränke die ausgewählt werden können
    /// </summary>
    enum Getraenke
    {
        Bier,
        Despo,
        Glühwein,
        Wein,
        Weinschorle,
        Löschzwerg,
        Met,
        Hugo,
        Goaß,
        Sekt,
        Flaschengetränk,
    }

    static class Helper
	{
        /// <summary>
        /// Method to start the application on the secondary screen
        /// </summary>
        public static void ShowOnSecondaryScreen(Form form)
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
                form.Location = secondary.Bounds.Location;

                // maximize the window
                form.WindowState = FormWindowState.Maximized;
                // Style entfernen
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            else
            {
                //Falls kein zweiter Monitor da auf dem ersten anzeigen
                form.Location = Screen.AllScreens[0].Bounds.Location;
            }
        }
    }
}





