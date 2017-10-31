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
        Getränk_0_5,
        Getränk_0_33,
        Irgendwas,
    }
           
    static class Helper
	{
        /// <summary>
        /// Erstellt eine Liste mit Rundenzeiten
        /// </summary>
        /// <returns></returns>
        public static List<Rundendauer> ErstelleRundenzeiten()
        {
            List<Rundendauer> listeDauer = new List<Rundendauer>();

            Rundendauer halbeStund = new Rundendauer("Halbe Stunde", 30);
            Rundendauer Stund = new Rundendauer("Eine Stunde", 60);
            Rundendauer eineinhalbStund = new Rundendauer("Eineinhalb Stunden", 90);
            Rundendauer zweiStund = new Rundendauer("Zwei Stunden", 120);

            listeDauer.Add(halbeStund);
            listeDauer.Add(Stund);
            listeDauer.Add(eineinhalbStund);
            listeDauer.Add(zweiStund);

            halbeStund = null;
            Stund = null;
            eineinhalbStund = null;
            zweiStund = null;

            return listeDauer;
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





