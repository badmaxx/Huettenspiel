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
            this.LblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblText
            // 
            this.LblText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText.Location = new System.Drawing.Point(12, 9);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(595, 513);
            this.LblText.TabIndex = 0;
            // 
            // Mitteilung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(619, 531);
            this.Controls.Add(this.LblText);
            this.Name = "Mitteilung";
            this.Text = "Mitteilung";
            this.Load += new System.EventHandler(this.MitteilungLoad);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label LblText;
	}
}
