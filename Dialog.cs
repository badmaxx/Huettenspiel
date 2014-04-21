using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hüttenspiel
{
    public partial class Dialog : Form
    {
        private Typ _spieltyp;

        public Dialog(Typ spieltyp)
        {
            InitializeComponent();

            _spieltyp = spieltyp;

            if (spieltyp == Typ.Team)
            {
                TxtNachname.Enabled = false;
                LblVorname.Text = "Teamname";                
            }
        }

        public string Vorname { get; private set; }

        public string Nachname { get; private set; }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (_spieltyp == Typ.Team)
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
