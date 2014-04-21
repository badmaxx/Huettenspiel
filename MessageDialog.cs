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

        private void BtnAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }

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
        
        void BtnDelTextClick(object sender, EventArgs e)
        {
        	rtbText.Text = "";
        }
    }
}
