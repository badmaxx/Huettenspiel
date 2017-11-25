namespace Hüttensammlung.Teamgenerator
{
    partial class Generator
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.NudAnzahlTeams = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddSpieler = new System.Windows.Forms.Button();
            this.LbSpieler = new System.Windows.Forms.ListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnzahlTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(86, 274);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Starten";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // NudAnzahlTeams
            // 
            this.NudAnzahlTeams.Location = new System.Drawing.Point(126, 248);
            this.NudAnzahlTeams.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NudAnzahlTeams.Name = "NudAnzahlTeams";
            this.NudAnzahlTeams.Size = new System.Drawing.Size(51, 20);
            this.NudAnzahlTeams.TabIndex = 1;
            this.NudAnzahlTeams.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anzahl Teams";
            // 
            // BtnAddSpieler
            // 
            this.BtnAddSpieler.Location = new System.Drawing.Point(8, 210);
            this.BtnAddSpieler.Name = "BtnAddSpieler";
            this.BtnAddSpieler.Size = new System.Drawing.Size(112, 23);
            this.BtnAddSpieler.TabIndex = 3;
            this.BtnAddSpieler.Text = "Spieler hinzufügen";
            this.BtnAddSpieler.UseVisualStyleBackColor = true;
            this.BtnAddSpieler.Click += new System.EventHandler(this.BtnAddSpieler_Click);
            // 
            // LbSpieler
            // 
            this.LbSpieler.FormattingEnabled = true;
            this.LbSpieler.Location = new System.Drawing.Point(8, 44);
            this.LbSpieler.Name = "LbSpieler";
            this.LbSpieler.Size = new System.Drawing.Size(226, 160);
            this.LbSpieler.TabIndex = 4;
            this.LbSpieler.DoubleClick += new System.EventHandler(this.LbSpieler_DoubleClick);
            this.LbSpieler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LbSpieler_KeyDown);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(130, 210);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(108, 23);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Spieler löschen";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Teilnehmende Spieler";
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Location = new System.Drawing.Point(4, 2);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(35, 13);
            this.LblVersion.TabIndex = 7;
            this.LblVersion.Text = "label3";
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 309);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LbSpieler);
            this.Controls.Add(this.BtnAddSpieler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NudAnzahlTeams);
            this.Controls.Add(this.BtnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Generator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teamgenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Generator_FormClosing);
            this.Shown += new System.EventHandler(this.Generator_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.NudAnzahlTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.NumericUpDown NudAnzahlTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddSpieler;
        private System.Windows.Forms.ListBox LbSpieler;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblVersion;
    }
}