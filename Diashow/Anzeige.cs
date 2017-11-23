using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Hüttensammlung.Diashow
{
    /// <summary>
    /// Ansicht für Diashow
    /// </summary>
    public partial class Anzeige : Form
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public Anzeige()
        {
            InitializeComponent(); 
        }

        /// <summary>
        /// Zeigt das Bild an
        /// </summary>
        /// <param name="bild"></param>
        public void SetBild(Image bild)
        {
            pictureBox1.Image = bild;
        }

        /// <summary>
        /// Auf zweiten Monitor schieben
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Diashow_Load(object sender, EventArgs e)
        {
            Helper.ShowOnSecondaryScreen(this);
        }
    }
}
