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
        private HorizontalAlignment _ausrichtung;

        public Font Schrift { get; set; }

        public HorizontalAlignment Ausrichtung { 
            get
            {
                return _ausrichtung;
            }

            set
            {
                _ausrichtung = value;
                TextNeuAusrichten(); 
            }
        }

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
                ErstelleText(value, Schrift);               
            }
        }

        /// <summary>
        /// Text und Schrift auf Rtb einrichten
        /// </summary>
        /// <param name="text">Angezeigter Text</param>
        /// <param name="schrift">Schriftart des Textes</param>
        private void ErstelleText(string text, Font schrift)
        {
            //Text vom oberen Rand weg
            if (!text.StartsWith("\n"))
            {
                text = Environment.NewLine + text;
            }
            RtbMitteilung.Text = text;
            RtbMitteilung.Font = schrift;
            TextNeuAusrichten();          
        }


        private void TextNeuAusrichten()
        {
            RtbMitteilung.SelectAll();
            RtbMitteilung.SelectionAlignment = _ausrichtung;
            RtbMitteilung.DeselectAll();

            this.ActiveControl = label1;
        }
   
	    /// <summary>
	    /// Form auf zweitem Bildschirm ausgeben
	    /// </summary>
	    /// <param name="sender"></param>
	    /// <param name="e"></param>
		void MitteilungLoad(object sender, EventArgs e)
		{
            Helper.ShowOnSecondaryScreen(this);
		}
	}
}
