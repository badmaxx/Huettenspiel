namespace Hüttenspiel
{
    partial class Dialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.LblVorname = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.TxtVorname = new System.Windows.Forms.TextBox();
        	this.TxtNachname = new System.Windows.Forms.TextBox();
        	this.BtnOk = new System.Windows.Forms.Button();
        	this.BtnAbbrechen = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// LblVorname
        	// 
        	this.LblVorname.AutoSize = true;
        	this.LblVorname.Location = new System.Drawing.Point(12, 9);
        	this.LblVorname.Name = "LblVorname";
        	this.LblVorname.Size = new System.Drawing.Size(49, 13);
        	this.LblVorname.TabIndex = 0;
        	this.LblVorname.Text = "Vorname";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(12, 40);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(59, 13);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "Nachname";
        	// 
        	// TxtVorname
        	// 
        	this.TxtVorname.Location = new System.Drawing.Point(87, 6);
        	this.TxtVorname.Name = "TxtVorname";
        	this.TxtVorname.Size = new System.Drawing.Size(241, 20);
        	this.TxtVorname.TabIndex = 2;
        	// 
        	// TxtNachname
        	// 
        	this.TxtNachname.Location = new System.Drawing.Point(87, 37);
        	this.TxtNachname.Name = "TxtNachname";
        	this.TxtNachname.Size = new System.Drawing.Size(241, 20);
        	this.TxtNachname.TabIndex = 3;
        	this.TxtNachname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNachname_KeyDown);
        	// 
        	// BtnOk
        	// 
        	this.BtnOk.Location = new System.Drawing.Point(253, 77);
        	this.BtnOk.Name = "BtnOk";
        	this.BtnOk.Size = new System.Drawing.Size(75, 23);
        	this.BtnOk.TabIndex = 4;
        	this.BtnOk.Text = "OK";
        	this.BtnOk.UseVisualStyleBackColor = true;
        	this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
        	// 
        	// BtnAbbrechen
        	// 
        	this.BtnAbbrechen.Location = new System.Drawing.Point(15, 77);
        	this.BtnAbbrechen.Name = "BtnAbbrechen";
        	this.BtnAbbrechen.Size = new System.Drawing.Size(75, 23);
        	this.BtnAbbrechen.TabIndex = 5;
        	this.BtnAbbrechen.Text = "Abbrechen";
        	this.BtnAbbrechen.UseVisualStyleBackColor = true;
        	this.BtnAbbrechen.Click += new System.EventHandler(this.BtnAbbrechen_Click);
        	// 
        	// Dialog
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(343, 112);
        	this.Controls.Add(this.BtnAbbrechen);
        	this.Controls.Add(this.BtnOk);
        	this.Controls.Add(this.TxtNachname);
        	this.Controls.Add(this.TxtVorname);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.LblVorname);
        	this.Name = "Dialog";
        	this.Text = "Hinzufügen";
        	this.Load += new System.EventHandler(this.DialogLoad);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label LblVorname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtVorname;
        private System.Windows.Forms.TextBox TxtNachname;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnAbbrechen;
    }
}