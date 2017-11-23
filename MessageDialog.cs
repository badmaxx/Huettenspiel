using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hüttensammlung
{
    /// <summary>
    /// Erstellen einer Nachricht
    /// </summary>
    public partial class MessageDialog : Form
    {
        private Font _schrift;
        private const string _pfadregeln = "Regeln.txt";

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="text"></param>
        /// <param name="schrift"></param>
        /// <param name="ausrichtung"></param>
        public MessageDialog(string text, Font schrift, HorizontalAlignment ausrichtung = HorizontalAlignment.Center)
        {
            InitializeComponent();
            _schrift = schrift;           

            rtbText.SelectionAlignment = Ausrichtung = ausrichtung;
            rtbText.Text = text;

            switch (Ausrichtung)
            {
                case HorizontalAlignment.Center:
                    BtnAusrichtung.Text = "Zentriert";
                    break;
                case HorizontalAlignment.Left:
                    BtnAusrichtung.Text = "Links";
                    break;
                case HorizontalAlignment.Right:
                    BtnAusrichtung.Text = "Rechts";
                    break;
                default:
                    break;
            }

            this.ActiveControl = rtbText;
        }

        /// <summary>
        /// Text der Nachricht
        /// </summary>
        public string MessageText { get; private set; }

        /// <summary>
        /// Ausrichtung der Nachtricht
        /// </summary>
        public HorizontalAlignment Ausrichtung { get; set; }

        /// <summary>
        /// Text Font der Nachricht
        /// </summary>
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

        /// <summary>
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
            rtbText.Font = new Font(_schrift.FontFamily, 12f);
            
        }

        /// <summary>
        /// Ausrichtung ändern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAusrichtung_Click(object sender, EventArgs e)
        {
            switch (Ausrichtung)
            {
                case HorizontalAlignment.Center:
                    BtnAusrichtung.Text = "Links";
                    Ausrichtung = HorizontalAlignment.Left;
                    break;
                case HorizontalAlignment.Left:
                    BtnAusrichtung.Text = "Rechts";
                    Ausrichtung = HorizontalAlignment.Right;
                    break;
                case HorizontalAlignment.Right:
                    BtnAusrichtung.Text = "Zentriert";
                    Ausrichtung = HorizontalAlignment.Center;
                    break;
                default:
                    break;
            }
            //Ausrichtung des gesamten Textes
            TextNeuAusrichten();
        }

        private void TextNeuAusrichten()
        {
            rtbText.SelectAll();
            rtbText.SelectionAlignment = Ausrichtung;
            rtbText.DeselectAll();
            this.ActiveControl = rtbText;
        }

        private void BtnRegeln_Click(object sender, EventArgs e)
        {
            if (!File.Exists(_pfadregeln))
            {
                File.Create(_pfadregeln);                
            }

            rtbText.Text = File.ReadAllText(_pfadregeln);
            Ausrichtung = HorizontalAlignment.Left;
            BtnAusrichtung.Text = "Links";
            TextNeuAusrichten();
        }
    }
}
