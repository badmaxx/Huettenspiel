using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hüttensammlung.Diashow
{
    /// <summary>
    /// Eingabe für die Diashow
    /// </summary>
    public partial class EingabeDiashow : Form
    {
        private bool _diashowGestartet = false;
        private Anzeige _diashow;        
        private int _bildnummer = 1;
        private List<string> _bilder;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public EingabeDiashow()
        {
            InitializeComponent();
        }

        private void SetBild(Image bild)
        {
            _diashow.SetBild(bild);
            PbBild.Image = bild;
        }
        

        /// <summary>
        /// Starten der Diashow
        /// </summary>
        private void DiashowStart()
        {
            _bilder = SucheBilder(TxtPfad.Text);

            if (_bilder != null && _bilder.Count > 0)
            {
                _diashow = new Anzeige();
                _diashowGestartet = true;
                TimerAnzeige.Start();
                _diashow.Show();
                NudAnzeigezeit.Enabled = false;
                lblDiashow.Text = "Diashow läuft...";
            }
            else
            {
                DiashowEnde();
                lblDiashow.Text = "Anzeigen nicht möglich!";
            }
        }

        /// <summary>
        /// Beenden der Diashow
        /// </summary>
        private void DiashowEnde()
        {
            BtnAnzeigen.Text = "Starten";
            _diashow.Close();
            _diashowGestartet = false;
            lblDiashow.Text = "Diashow beendet";
            NudAnzeigezeit.Enabled = true;
            TimerAnzeige.Stop();            
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
                SetBild(Image.FromFile(_bilder[_bildnummer]));
            }
            catch
            {
                SetBild(Image.FromFile(_bilder[_bildnummer - 1]));
            }

            if (_bildnummer < _bilder.Count - 1)
            {
                _bildnummer++;
            }
            else
            {
                _bildnummer = 0;
            }
        }

        private void BtnDurchsuchen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = false,
                Description = "Ordner mit Bildern auswählen. Es werden alle Bilder darin angezeigt!"
            };
            dialog.ShowDialog();
            if (SucheBilder(dialog.SelectedPath).Count != 0)
            {
                TxtPfad.Text = dialog.SelectedPath;
            }
        }

        private List<string> SucheBilder(string pfad)
        {
            List<string> bilder = new List<string>();

            if (Directory.Exists(pfad))
            {
                string[] files = Directory.GetFiles(pfad);

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
                    MessageBox.Show("Kein Bild in diesem Ordner!", "Fehler");
                }                
            }
            else
            {
                MessageBox.Show("Pfad existiert nicht!", "Fehler");
            }
            return bilder;
        }

        /// <summary>
        /// Diashow starten oder beenden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnzeigen_Click(object sender, EventArgs e)
        {
            if (_diashowGestartet)
            {
                DiashowEnde();
                _diashow.Dispose();
            }
            else
            {
                BtnAnzeigen.Text = "Beenden";
                TimerAnzeige.Interval = Convert.ToInt32(NudAnzeigezeit.Value * 1000);
                DiashowStart();
            }
        }
    }
}
