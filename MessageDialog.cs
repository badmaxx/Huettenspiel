﻿using System;
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
        Font _schrift;

        public MessageDialog(string text, Font schrift)
        {
            InitializeComponent();
            _schrift = schrift;
            rtbText.Text = text;      
            this.ActiveControl = rtbText;
        }

        public string MessageText { get; private set; }

        public Font Schrift { get; private set; }

        /// <summary>
        /// Bestätigung des Textes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            Schrift = _schrift;

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

    
		/// <summary>
		/// Steuerung über Tastatur
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
        
        /// Kompletten Text über Button löschen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BtnDelTextClick(object sender, EventArgs e)
        {
        	rtbText.Text = "";
        }


        /// <summary>
        /// Schriftart vom Nachrichtenfenster einstellen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSchrift_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.Font = _schrift;
            font.ShowDialog();

            _schrift = font.Font;
        }
    }
}
