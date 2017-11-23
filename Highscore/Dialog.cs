using System;
using System.Windows.Forms;

namespace Hüttensammlung.Highscore
{
    /// <summary>
    /// Dialog zur Eingabe von Spielern
    /// </summary>
    public partial class Dialog : Form
    {
        private Spieltyp _spieltyp;

        /// <summary>
        /// Dialog
        /// </summary>
        /// <param name="spieltyp"></param>
        public Dialog(Spieltyp spieltyp)
        {
            InitializeComponent();

            _spieltyp = spieltyp;

            if (spieltyp == Spieltyp.Team)
            {
                TxtNachname.Enabled = false;
                LblVorname.Text = "Teamname";                
            }
        }

        /// <summary>
        /// Vorname
        /// </summary>
        public string Vorname { get; private set; }

        /// <summary>
        /// Nachname
        /// </summary>
        public string Nachname { get; private set; }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (_spieltyp == Spieltyp.Team)
            {
                if (string.IsNullOrEmpty(TxtVorname.Text))
                {
                    MessageBox.Show("Teamname eingeben");
                }
                else
                {
                    Vorname = TxtVorname.Text;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {

                if (string.IsNullOrEmpty(TxtVorname.Text) || string.IsNullOrEmpty(TxtNachname.Text))
                {
                    MessageBox.Show("Beide Felder ausfüllen!");
                }
                else
                {
                    Vorname = TxtVorname.Text;
                    Nachname = TxtNachname.Text;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void BtnAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void TxtNachname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BtnOk.PerformClick();
            }
        }
    }
}
