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
    public partial class Diashow : Form
    {
        private string _ordnerpfad;
        private List<string> bilder = new List<string>();
        private int bildnummer = 1;
        public Diashow()
        {
            InitializeComponent(); 
        }

       
        /// <summary>
        /// Initialisieren und Bilderpfad auswählen
        /// </summary>
        public void init()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.Description = "Ordner mit Bildern auswählen. Es werden alle Bilder darin angezeigt!";
            dialog.ShowDialog();
            _ordnerpfad = dialog.SelectedPath;           
        }

        /// <summary>
        /// Anzeigen der Diashow
        /// </summary>
        /// <returns>Öffnen erfolgreich?</returns>
        public bool Anzeigen()
        {
            if (Directory.Exists(_ordnerpfad))
            {
                string[] files = Directory.GetFiles(_ordnerpfad);

                foreach (string file in files)
                {        
                    try
                    {
                        Image.FromFile(file);
                        bilder.Add(file);   
                    }
                    catch
                    { }                                     
                }

               if (bilder.Count == 0)
               {
                   MessageBox.Show("Kein Bild in diesem Ordner!");
                   return false;
               }
               try
               {
                   pictureBox1.Image = Image.FromFile(bilder[0]);
               }
               catch (Exception)
               {
                   
               }
               
               TimerAnzeige.Start();
               this.Show();
               return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// Bild weiterschalten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerAnzeige_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(bilder[bildnummer]);
            }
            catch
            {
                pictureBox1.Image = Image.FromFile(bilder[bildnummer-1]);
            }

            if (bildnummer < bilder.Count-1)
            {
                bildnummer++;
            }
            else
            {
                bildnummer = 0;
            }
        }

        /// <summary>
        /// Auf zweiten Monitor schieben
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Diashow_Load(object sender, EventArgs e)
        {
            Helper.ShowOnSecondaryScreen(this);
        }
    }
}
