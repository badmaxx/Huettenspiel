﻿using System;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Collections.Generic;

namespace Hüttensammlung
{           
    static class Helper
	{
        private static Random random = new Random();
        /// <summary>
        /// Vertauscht die Einträge der Liste 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ilist"></param>
        public static void Shuffle<T>(IList<T> ilist)
        {
            int iIndex;
            T tTmp;
            for (int i = 1; i < ilist.Count; ++i)
            {
                iIndex = random.Next(i + 1);
                tTmp = ilist[i];
                ilist[i] = ilist[iIndex];
                ilist[iIndex] = tTmp;
            }
        }


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



        /// <summary>
        /// Motherboard ID abfragen
        /// </summary>
        /// <returns>true passt sonst false</returns>
        public static bool CheckMotherboardID()
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

            if (File.Exists(pfad))
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
    }
}





