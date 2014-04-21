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
    public partial class MessageDialog : Form
    {
        public MessageDialog(string text)
        {
            InitializeComponent();
			
            rtbText.Text = text;      
            this.ActiveControl = rtbText;
        }

        public string MessageText { get; private set; }


        /// <summary>
        /// Bestätigung des Textes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
        	if(rtbText.Text == "")
        	{
        		if(MessageBox.Show("Leere Nachricht anzeigen?", "Bestätigung", MessageBoxButtons.YesNo) == DialogResult.Yes)
        		{
        			MessageText = rtbText.Text;
		        	DialogResult = DialogResult.OK;
		            this.Close();
        		}
        	}
        	else
        	{
        		MessageText = rtbText.Text;
	        	DialogResult = DialogResult.OK;
	            this.Close();
        	}
        }

        /// <summary>
        /// Texteingabe abbrechen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }
<<<<<<< HEAD

        /// <summary>
        /// Tastenkombi abfragen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
=======
        
		/// <summary>
		/// Steuerung über Tastatur
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
>>>>>>> c0d4553cfea335938686911156cbbd425f822759
        private void rtbText_KeyDown(object sender, KeyEventArgs e)
        {
        	//Prüfen ob Strg+Enter gedrückt wrude 
        	if (e.KeyData == (Keys.Enter | Keys.Control))
            {
                BtnOk.PerformClick();			//Form mit ok schließen
            }
        	//Prüfen ob Esc gedrückt wurde
            else if(e.KeyData == Keys.Escape)
            {
            	BtnAbbrechen.PerformClick();	//Form mit Abbrechen schließen
            }
        }
        
        /// <summary>
<<<<<<< HEAD
        /// Text löschen
=======
        /// Kompletten Text über Button löschen
>>>>>>> c0d4553cfea335938686911156cbbd425f822759
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BtnDelTextClick(object sender, EventArgs e)
        {
        	rtbText.Text = "";
        }
    }
}
