namespace Hüttenspiel
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnAbbrechen = new System.Windows.Forms.Button();
            this.LblText = new System.Windows.Forms.Label();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.BtnDelText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.Location = new System.Drawing.Point(253, 101);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnAbbrechen
            // 
            this.BtnAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAbbrechen.Location = new System.Drawing.Point(15, 101);
            this.BtnAbbrechen.Name = "BtnAbbrechen";
            this.BtnAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.BtnAbbrechen.TabIndex = 5;
            this.BtnAbbrechen.Text = "Abbrechen";
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
            this.rtbText.Location = new System.Drawing.Point(15, 32);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(313, 56);
            this.rtbText.TabIndex = 7;
            this.rtbText.Text = "";
            this.rtbText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbText_KeyDown);
            // 
            // BtnDelText
            // 
            this.BtnDelText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnDelText.Location = new System.Drawing.Point(133, 101);
            this.BtnDelText.Name = "BtnDelText";
            this.BtnDelText.Size = new System.Drawing.Size(84, 23);
            this.BtnDelText.TabIndex = 8;
            this.BtnDelText.Text = "Text löschen";
            this.BtnDelText.UseVisualStyleBackColor = true;
            this.BtnDelText.Click += new System.EventHandler(this.BtnDelTextClick);
            // 
            // MessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 136);
            this.Controls.Add(this.BtnDelText);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.BtnAbbrechen);
            this.Controls.Add(this.BtnOk);
            this.MinimumSize = new System.Drawing.Size(359, 175);
            this.Name = "MessageDialog";
            this.Text = "Nachricht anzeigen";
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button BtnDelText;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Label LblText;

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnAbbrechen;
    }
}