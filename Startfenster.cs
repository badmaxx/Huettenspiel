using System;
using System.Windows.Forms;

using Hüttensammlung.Highscore;
using Hüttensammlung.Diashow;

namespace Hüttensammlung
{
    /// <summary>
    /// Startfenster für Programme
    /// </summary>
    public partial class Startfenster : Form
    {
        /// <summary>
        /// Startfenster für Programme
        /// </summary>
        public Startfenster()
        {
            InitializeComponent();
        }

        private void BtnPicolo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnHighscore_Click(object sender, EventArgs e)
        {
            if (CheckLizenz())
            {
                Eingabe highscore = new Eingabe();
                Hide();
                highscore.ShowDialog();
                Show();
            }
        }

        private void BtnDiashow_Click(object sender, EventArgs e)
        {
            if (CheckLizenz())
            {
                EingabeDiashow diashow = new EingabeDiashow();
                Hide();
                diashow.ShowDialog();
                Show();
            }
        }

        private bool CheckLizenz()
        {
            bool debugmodus = false;
            bool retval = false;
#if DEBUG
            debugmodus = true;
#endif
            if (Hüttensammlung.Helper.CheckMotherboardID() || debugmodus)
            {
                retval = true;
            }
            else
            {
                MessageBox.Show("Programm ist nicht lizensiert und kann nicht gestartet werden!", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retval;
        }

        private void BtnTeamgenerator_Click(object sender, EventArgs e)
        {
            if (CheckLizenz())
            {
                Teamgenerator.Generator generator = new Teamgenerator.Generator();
                Hide();
                generator.ShowDialog();
                Show();
            }
        }
    }
}
