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
            Eingabe highscore = new Eingabe();
            Hide();
            highscore.ShowDialog();
            Show();
        }

        private void BtnDiashow_Click(object sender, EventArgs e)
        {
            EingabeDiashow diashow = new EingabeDiashow();
            Hide();
            diashow.ShowDialog();
            Show();
        }
    }
}
