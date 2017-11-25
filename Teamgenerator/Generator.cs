using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Hüttensammlung.Teamgenerator
{
    /// <summary>
    /// Teamgenerator
    /// </summary>
    public partial class Generator : Form
    {
        private List<string> _spieler = new List<string>();

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Generator()
        {
            InitializeComponent();
            LblVersion.Text = "Version: " + Properties.Settings.Default.VersionGenerator;
        }

        private void BtnAddSpieler_Click(object sender, EventArgs e)
        {
            Highscore.Dialog dialog = new Highscore.Dialog(Highscore.Spieltyp.Spieler);

            dialog.ShowDialog();

            LbSpieler.Items.Add(dialog.Vorname + " " + dialog.Nachname);
            _spieler.Add(dialog.Vorname + " " + dialog.Nachname);
        }

        private void LbSpieler_DoubleClick(object sender, EventArgs e)
        {
            if (LbSpieler.SelectedItem != null)
            {
                LbSpieler.Items.RemoveAt(LbSpieler.SelectedIndex);
                _spieler.RemoveAt(LbSpieler.SelectedIndex);
            }
        }

        private void LbSpieler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (LbSpieler.SelectedItems.Count > 0)
                {
                    LbSpieler.Items.RemoveAt(LbSpieler.SelectedIndex);
                    _spieler.RemoveAt(LbSpieler.SelectedIndex);
                }                
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LbSpieler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Zu löschenden Spieler auswählen");
            }
            else
            {
                LbSpieler.Items.RemoveAt(LbSpieler.SelectedIndex);
            }
        }
        

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int anzahlTeams = Convert.ToInt16(NudAnzahlTeams.Value);
            int spielerProTeam = 0, moduloSpieler = 0;
            int jetzigesTeam = 1;
            int temp;
            List<string> mitspieler = new List<string>();
            string ausgabe = "";
            
            if(LbSpieler.Items.Count < NudAnzahlTeams.Value)
            {
                MessageBox.Show("Zu wenig Spieler für " + NudAnzahlTeams.Value.ToString() + " Teams!!", "Depp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mitspieler.AddRange(_spieler);
                Helper.Shuffle<string>(mitspieler);

                spielerProTeam = mitspieler.Count / anzahlTeams;
                moduloSpieler = mitspieler.Count % anzahlTeams;

                if(moduloSpieler > 1)
                {
                    spielerProTeam++;
                    ausgabe += "Ungünstiges Spieler zu Team Verhältnis! Teamanzahl wird sinnvoller gesetzt. Sollte " +
                        "dies nicht gewünscht sein letztes Team trennen!" + Environment.NewLine + Environment.NewLine;
                }

                temp = spielerProTeam;

                for (int i = 0; i < mitspieler.Count; i++)
                {
                    ausgabe += ("Team " + jetzigesTeam.ToString() + ": " + mitspieler[i] + Environment.NewLine);

                    if (temp == i+1 && jetzigesTeam < anzahlTeams)
                    {
                        ausgabe += Environment.NewLine;
                        jetzigesTeam++;
                        temp += spielerProTeam;
                    }
                }

                MessageBox.Show(ausgabe, "Ergebnis");
            }
        }

        private string ListenPfad()
        {
            return Path.Combine("Teamgenerator", "Spielerliste.xml");
        }

        private void Generator_Shown(object sender, EventArgs e)
        {
            if(Directory.Exists("Teamgenerator"))
            {
                if(File.Exists(ListenPfad()))
                {
                    _spieler = XML.Load<List<string>>(ListenPfad());

                    foreach (string spieler in _spieler)
                    {
                        LbSpieler.Items.Add(spieler);
                    }
                }
            }
            else
            {
                Directory.CreateDirectory("Teamgenerator");
            }
        }

        private void Generator_FormClosing(object sender, FormClosingEventArgs e)
        {
            XML.Save<List<string>>(_spieler, ListenPfad());
        }
    }
}
