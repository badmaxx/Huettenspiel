using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Hüttensammlung
{           
    static class Helper
	{
      

        /// <summary>
        /// Info über angeschlossene Monitore als string
        /// </summary>
        /// <param name="monitornummer">Nummer (Achtung Array deklaration)</param>
        /// <returns>Nummer, Name, Auflösung und primärer Monitor</returns>
        public static string Monitorinfo(int monitornummer)
        {
            if (System.Windows.Forms.SystemInformation.MonitorCount > monitornummer)
            {
                return "Monitornummer: " + (monitornummer + 1)
                    + "\nMonitorname: " + Screen.AllScreens[monitornummer].DeviceName.ToString()
                    + "\nMonitorauflösung: " + Screen.AllScreens[monitornummer].Bounds.Size.ToString()
                    + "\nPrimärer Monitor: " + Screen.AllScreens[monitornummer].Primary.ToString()
                    + Environment.NewLine + Environment.NewLine;

            }

            else
            {
                return "Kein " + (monitornummer + 1) + ". Monitor vorhanden";
            }

        }

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
                //Falls kein zweiter Monitor, dann auf dem ersten anzeigen
                form.Location = Screen.AllScreens[0].Bounds.Location;
            }
        }

    }
}





