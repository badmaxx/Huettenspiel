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

        private void TxtNachname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BtnOk.PerformClick();
            }
        }
        
        void BtnDelTextClick(object sender, EventArgs e)
        {
        	rtbText.Text = "";
        }
    }
}
