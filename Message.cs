using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hüttenspiel
{
	/// <summary>
	/// Dialog um Nachrichten anzuzeigen
	/// </summary>
	public partial class Mitteilung : Form
	{
		public Mitteilung()
		{
			InitializeComponent();
		}

        /// <summary>
        /// Nachricht die angezeigt wird
        /// </summary>
        public string Nachricht
        {
            get
            {
                return RtbMitteilung.Text;
            }
            set
            {
                RtbMitteilung.Text = value;               
            }
        }
             

	/// <summary>
    /// Method to start the application on the secondary screen
    /// </summary>
	    private void ShowOnSecondaryScreen()
	    {
	        Screen secondary = null;
	
	        // check if there is a secondary screen
	        if (Screen.AllScreens.GetUpperBound(0) > 0)
	        {
	            // get the secondary screen
	            secondary = Screen.AllScreens[1];
	        }
	
	        if (secondary != null)
	        {
	            // set the screen location as form location
	            this.Location = secondary.Bounds.Location;
	
	            // maximize the window
	            this.WindowState = FormWindowState.Maximized;
	            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
	        }
	    }
		
	    /// <summary>
	    /// Form auf zweitem Bildschirm ausgeben
	    /// </summary>
	    /// <param name="sender"></param>
	    /// <param name="e"></param>
		void MitteilungLoad(object sender, EventArgs e)
		{
			ShowOnSecondaryScreen();
		}
	}
}
