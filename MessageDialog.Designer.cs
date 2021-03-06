﻿namespace Hüttensammlung
{
    partial class MessageDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageDialog));
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnAbbrechen = new System.Windows.Forms.Button();
            this.LblText = new System.Windows.Forms.Label();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.BtnDelText = new System.Windows.Forms.Button();
            this.btnSchrift = new System.Windows.Forms.Button();
            this.BtnAusrichtung = new System.Windows.Forms.Button();
            this.BtnRegeln = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.Location = new System.Drawing.Point(413, 271);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "Anzeigen";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnAbbrechen
            // 
            this.BtnAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAbbrechen.Location = new System.Drawing.Point(15, 271);
            this.BtnAbbrechen.Name = "BtnAbbrechen";
            this.BtnAbbrechen.Size = new System.Drawing.Size(64, 23);
            this.BtnAbbrechen.TabIndex = 5;
            this.BtnAbbrechen.Text = "Zurück";
            this.BtnAbbrechen.UseVisualStyleBackColor = true;
            this.BtnAbbrechen.Click += new System.EventHandler(this.BtnAbbrechen_Click);
            // 
            // LblText
            // 
            this.LblText.Location = new System.Drawing.Point(15, 9);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(35, 20);
            this.LblText.TabIndex = 6;
            this.LblText.Text = "Text:";
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbText
            // 
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.Location = new System.Drawing.Point(15, 32);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(473, 226);
            this.rtbText.TabIndex = 7;
            this.rtbText.Text = "";
            this.rtbText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbText_KeyDown);
            // 
            // BtnDelText
            // 
            this.BtnDelText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelText.Location = new System.Drawing.Point(85, 271);
            this.BtnDelText.Name = "BtnDelText";
            this.BtnDelText.Size = new System.Drawing.Size(76, 23);
            this.BtnDelText.TabIndex = 8;
            this.BtnDelText.Text = "Text löschen";
            this.BtnDelText.UseVisualStyleBackColor = true;
            this.BtnDelText.Click += new System.EventHandler(this.BtnDelTextClick);
            // 
            // btnSchrift
            // 
            this.btnSchrift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchrift.Location = new System.Drawing.Point(333, 271);
            this.btnSchrift.Name = "btnSchrift";
            this.btnSchrift.Size = new System.Drawing.Size(75, 23);
            this.btnSchrift.TabIndex = 9;
            this.btnSchrift.Text = "Schriftart";
            this.btnSchrift.UseVisualStyleBackColor = true;
            this.btnSchrift.Click += new System.EventHandler(this.btnSchrift_Click);
            // 
            // BtnAusrichtung
            // 
            this.BtnAusrichtung.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAusrichtung.Location = new System.Drawing.Point(171, 271);
            this.BtnAusrichtung.Name = "BtnAusrichtung";
            this.BtnAusrichtung.Size = new System.Drawing.Size(75, 23);
            this.BtnAusrichtung.TabIndex = 10;
            this.BtnAusrichtung.Text = "Zentriert";
            this.BtnAusrichtung.UseVisualStyleBackColor = true;
            this.BtnAusrichtung.Click += new System.EventHandler(this.BtnAusrichtung_Click);
            // 
            // BtnRegeln
            // 
            this.BtnRegeln.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnRegeln.Location = new System.Drawing.Point(252, 271);
            this.BtnRegeln.Name = "BtnRegeln";
            this.BtnRegeln.Size = new System.Drawing.Size(75, 23);
            this.BtnRegeln.TabIndex = 11;
            this.BtnRegeln.Text = "Regeln";
            this.BtnRegeln.UseVisualStyleBackColor = true;
            this.BtnRegeln.Click += new System.EventHandler(this.BtnRegeln_Click);
            // 
            // MessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 306);
            this.Controls.Add(this.BtnRegeln);
            this.Controls.Add(this.BtnAusrichtung);
            this.Controls.Add(this.btnSchrift);
            this.Controls.Add(this.BtnDelText);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.BtnAbbrechen);
            this.Controls.Add(this.BtnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(359, 175);
            this.Name = "MessageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nachricht anzeigen";
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button BtnDelText;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Label LblText;

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnAbbrechen;
        private System.Windows.Forms.Button btnSchrift;
        private System.Windows.Forms.Button BtnAusrichtung;
        private System.Windows.Forms.Button BtnRegeln;
    }
}