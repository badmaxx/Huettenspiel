/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Maxx
 * Datum: 20.04.2014
 * Zeit: 23:25
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace Hüttenspiel
{
	partial class Mitteilung
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.RtbMitteilung = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RtbMitteilung
            // 
            this.RtbMitteilung.BackColor = System.Drawing.Color.White;
            this.RtbMitteilung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RtbMitteilung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbMitteilung.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbMitteilung.Location = new System.Drawing.Point(0, 0);
            this.RtbMitteilung.Name = "RtbMitteilung";
            this.RtbMitteilung.ReadOnly = true;
            this.RtbMitteilung.Size = new System.Drawing.Size(619, 531);
            this.RtbMitteilung.TabIndex = 0;
            this.RtbMitteilung.Text = "";
            // 
            // Mitteilung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(619, 531);
            this.Controls.Add(this.RtbMitteilung);
            this.Name = "Mitteilung";
            this.ShowInTaskbar = false;
            this.Text = "Mitteilung";
            this.Load += new System.EventHandler(this.MitteilungLoad);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.RichTextBox RtbMitteilung;
	}
}
