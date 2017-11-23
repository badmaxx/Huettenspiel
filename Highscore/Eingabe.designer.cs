using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Hüttensammlung.Highscore
{
    /// <summary>
    /// Eingabe der Spieldaten
    /// </summary>
    partial class Eingabe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eingabe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbSpieler = new System.Windows.Forms.ListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnNeuerSpieler = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbAktuelleSpieler = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnLöschen = new System.Windows.Forms.Button();
            this.BtnHinzu = new System.Windows.Forms.Button();
            this.GbAktualisieren = new System.Windows.Forms.GroupBox();
            this.BtnBestätigen = new System.Windows.Forms.Button();
            this.NudAnzahl = new System.Windows.Forms.NumericUpDown();
            this.LblSpieler = new System.Windows.Forms.Label();
            this.LblAuswahl = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnBeenden = new System.Windows.Forms.Button();
            this.LblGetraenk = new System.Windows.Forms.Label();
            this.GbRunde = new System.Windows.Forms.GroupBox();
            this.cbSonstiges = new System.Windows.Forms.CheckBox();
            this.cbRundendauer = new System.Windows.Forms.ComboBox();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.LblRundenzeit = new System.Windows.Forms.Label();
            this.RbTeams = new System.Windows.Forms.RadioButton();
            this.RbSpieler = new System.Windows.Forms.RadioButton();
            this.CbGetränk = new System.Windows.Forms.ComboBox();
            this.BtnSchließen = new System.Windows.Forms.Button();
            this.TimerRundenzeit = new System.Windows.Forms.Timer(this.components);
            this.BtnShowMessage = new System.Windows.Forms.Button();
            this.BtnCloseMessage = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.BtnLogs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GbAktualisieren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnzahl)).BeginInit();
            this.GbRunde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbSpieler);
            this.groupBox1.Location = new System.Drawing.Point(29, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spieler";
            // 
            // LbSpieler
            // 
            this.LbSpieler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbSpieler.FormattingEnabled = true;
            this.LbSpieler.Location = new System.Drawing.Point(3, 16);
            this.LbSpieler.Name = "LbSpieler";
            this.LbSpieler.Size = new System.Drawing.Size(182, 303);
            this.LbSpieler.Sorted = true;
            this.LbSpieler.TabIndex = 0;
            this.LbSpieler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbSpielerMouseDoubleClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(238, 256);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 37);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Lösche Spieler";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnNeuerSpieler
            // 
            this.BtnNeuerSpieler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNeuerSpieler.Location = new System.Drawing.Point(238, 213);
            this.BtnNeuerSpieler.Name = "BtnNeuerSpieler";
            this.BtnNeuerSpieler.Size = new System.Drawing.Size(75, 37);
            this.BtnNeuerSpieler.TabIndex = 5;
            this.BtnNeuerSpieler.Text = "Neuer Spieler";
            this.BtnNeuerSpieler.UseVisualStyleBackColor = true;
            this.BtnNeuerSpieler.Click += new System.EventHandler(this.BtnNeuerSpieler_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LbAktuelleSpieler);
            this.groupBox2.Location = new System.Drawing.Point(335, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktuelle Mitspieler";
            // 
            // LbAktuelleSpieler
            // 
            this.LbAktuelleSpieler.FormattingEnabled = true;
            this.LbAktuelleSpieler.Location = new System.Drawing.Point(3, 16);
            this.LbAktuelleSpieler.Name = "LbAktuelleSpieler";
            this.LbAktuelleSpieler.Size = new System.Drawing.Size(182, 303);
            this.LbAktuelleSpieler.TabIndex = 1;
            this.LbAktuelleSpieler.SelectedIndexChanged += new System.EventHandler(this.LbAktuelleSpieler_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.BtnDelete);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.BtnLöschen);
            this.groupBox3.Controls.Add(this.BtnNeuerSpieler);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.BtnHinzu);
            this.groupBox3.Location = new System.Drawing.Point(19, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 347);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auswahl Spieler";
            // 
            // BtnLöschen
            // 
            this.BtnLöschen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLöschen.Image = global::Hüttensammlung.Properties.Resources.Pfeillinks;
            this.BtnLöschen.Location = new System.Drawing.Point(238, 117);
            this.BtnLöschen.Name = "BtnLöschen";
            this.BtnLöschen.Size = new System.Drawing.Size(75, 52);
            this.BtnLöschen.TabIndex = 3;
            this.BtnLöschen.UseVisualStyleBackColor = true;
            this.BtnLöschen.Click += new System.EventHandler(this.BtnLöschen_Click);
            // 
            // BtnHinzu
            // 
            this.BtnHinzu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnHinzu.Image = global::Hüttensammlung.Properties.Resources.Pfeilrechts;
            this.BtnHinzu.Location = new System.Drawing.Point(238, 35);
            this.BtnHinzu.Name = "BtnHinzu";
            this.BtnHinzu.Size = new System.Drawing.Size(75, 52);
            this.BtnHinzu.TabIndex = 2;
            this.BtnHinzu.UseVisualStyleBackColor = true;
            this.BtnHinzu.Click += new System.EventHandler(this.BtnHinzu_Click);
            // 
            // GbAktualisieren
            // 
            this.GbAktualisieren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GbAktualisieren.Controls.Add(this.BtnBestätigen);
            this.GbAktualisieren.Controls.Add(this.NudAnzahl);
            this.GbAktualisieren.Controls.Add(this.LblSpieler);
            this.GbAktualisieren.Controls.Add(this.LblAuswahl);
            this.GbAktualisieren.Enabled = false;
            this.GbAktualisieren.Location = new System.Drawing.Point(295, 378);
            this.GbAktualisieren.Name = "GbAktualisieren";
            this.GbAktualisieren.Size = new System.Drawing.Size(264, 96);
            this.GbAktualisieren.TabIndex = 5;
            this.GbAktualisieren.TabStop = false;
            this.GbAktualisieren.Text = "Aktuelle HIGHSCORE";
            // 
            // BtnBestätigen
            // 
            this.BtnBestätigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBestätigen.Location = new System.Drawing.Point(125, 51);
            this.BtnBestätigen.Name = "BtnBestätigen";
            this.BtnBestätigen.Size = new System.Drawing.Size(98, 29);
            this.BtnBestätigen.TabIndex = 5;
            this.BtnBestätigen.Text = "Aktualisieren";
            this.BtnBestätigen.UseVisualStyleBackColor = true;
            this.BtnBestätigen.Click += new System.EventHandler(this.BtnBestätigen_Click);
            // 
            // NudAnzahl
            // 
            this.NudAnzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudAnzahl.Location = new System.Drawing.Point(21, 51);
            this.NudAnzahl.Name = "NudAnzahl";
            this.NudAnzahl.Size = new System.Drawing.Size(68, 26);
            this.NudAnzahl.TabIndex = 4;
            this.NudAnzahl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NudAnzahl_KeyDown);
            // 
            // LblSpieler
            // 
            this.LblSpieler.AutoSize = true;
            this.LblSpieler.Location = new System.Drawing.Point(133, 24);
            this.LblSpieler.Name = "LblSpieler";
            this.LblSpieler.Size = new System.Drawing.Size(10, 13);
            this.LblSpieler.TabIndex = 3;
            this.LblSpieler.Text = "-";
            // 
            // LblAuswahl
            // 
            this.LblAuswahl.AutoSize = true;
            this.LblAuswahl.Location = new System.Drawing.Point(18, 24);
            this.LblAuswahl.Name = "LblAuswahl";
            this.LblAuswahl.Size = new System.Drawing.Size(109, 13);
            this.LblAuswahl.TabIndex = 2;
            this.LblAuswahl.Text = "Ausgewählter Spieler:";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(6, 20);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(89, 29);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Starten";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnBeenden
            // 
            this.BtnBeenden.Enabled = false;
            this.BtnBeenden.Location = new System.Drawing.Point(105, 20);
            this.BtnBeenden.Name = "BtnBeenden";
            this.BtnBeenden.Size = new System.Drawing.Size(89, 29);
            this.BtnBeenden.TabIndex = 1;
            this.BtnBeenden.Text = "Beenden";
            this.BtnBeenden.UseVisualStyleBackColor = true;
            this.BtnBeenden.Click += new System.EventHandler(this.BtnBeenden_Click);
            // 
            // LblGetraenk
            // 
            this.LblGetraenk.AutoSize = true;
            this.LblGetraenk.Location = new System.Drawing.Point(6, 63);
            this.LblGetraenk.Name = "LblGetraenk";
            this.LblGetraenk.Size = new System.Drawing.Size(48, 13);
            this.LblGetraenk.TabIndex = 6;
            this.LblGetraenk.Text = "Getränk:";
            // 
            // GbRunde
            // 
            this.GbRunde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GbRunde.Controls.Add(this.cbSonstiges);
            this.GbRunde.Controls.Add(this.cbRundendauer);
            this.GbRunde.Controls.Add(this.numericUpDownTime);
            this.GbRunde.Controls.Add(this.LblRundenzeit);
            this.GbRunde.Controls.Add(this.RbTeams);
            this.GbRunde.Controls.Add(this.RbSpieler);
            this.GbRunde.Controls.Add(this.CbGetränk);
            this.GbRunde.Controls.Add(this.BtnStart);
            this.GbRunde.Controls.Add(this.LblGetraenk);
            this.GbRunde.Controls.Add(this.BtnBeenden);
            this.GbRunde.Location = new System.Drawing.Point(25, 378);
            this.GbRunde.Name = "GbRunde";
            this.GbRunde.Size = new System.Drawing.Size(217, 202);
            this.GbRunde.TabIndex = 7;
            this.GbRunde.TabStop = false;
            this.GbRunde.Text = "Runde";
            // 
            // cbSonstiges
            // 
            this.cbSonstiges.AutoSize = true;
            this.cbSonstiges.Location = new System.Drawing.Point(12, 179);
            this.cbSonstiges.Name = "cbSonstiges";
            this.cbSonstiges.Size = new System.Drawing.Size(113, 17);
            this.cbSonstiges.TabIndex = 14;
            this.cbSonstiges.Text = "Sonstige Zeit (min)";
            this.ttInfo.SetToolTip(this.cbSonstiges, "Keine Rangliste für Sonstige Zeiten verfügbar!");
            this.cbSonstiges.UseVisualStyleBackColor = true;
            this.cbSonstiges.CheckedChanged += new System.EventHandler(this.cbSonstiges_CheckedChanged);
            // 
            // cbRundendauer
            // 
            this.cbRundendauer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRundendauer.FormattingEnabled = true;
            this.cbRundendauer.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120"});
            this.cbRundendauer.Location = new System.Drawing.Point(12, 149);
            this.cbRundendauer.Name = "cbRundendauer";
            this.cbRundendauer.Size = new System.Drawing.Size(182, 21);
            this.cbRundendauer.TabIndex = 14;
            this.cbRundendauer.SelectedIndexChanged += new System.EventHandler(this.cbRundendauer_SelectedIndexChanged);
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Enabled = false;
            this.numericUpDownTime.Location = new System.Drawing.Point(146, 176);
            this.numericUpDownTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownTime.TabIndex = 12;
            this.numericUpDownTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownTime.ValueChanged += new System.EventHandler(this.NumericUpDownTimeValueChanged);
            // 
            // LblRundenzeit
            // 
            this.LblRundenzeit.Location = new System.Drawing.Point(9, 126);
            this.LblRundenzeit.Name = "LblRundenzeit";
            this.LblRundenzeit.Size = new System.Drawing.Size(131, 20);
            this.LblRundenzeit.TabIndex = 11;
            this.LblRundenzeit.Text = "Rundendauer:";
            this.LblRundenzeit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RbTeams
            // 
            this.RbTeams.AutoSize = true;
            this.RbTeams.Location = new System.Drawing.Point(124, 106);
            this.RbTeams.Name = "RbTeams";
            this.RbTeams.Size = new System.Drawing.Size(57, 17);
            this.RbTeams.TabIndex = 9;
            this.RbTeams.Text = "Teams";
            this.RbTeams.UseVisualStyleBackColor = true;
            // 
            // RbSpieler
            // 
            this.RbSpieler.AutoSize = true;
            this.RbSpieler.Checked = true;
            this.RbSpieler.Location = new System.Drawing.Point(9, 106);
            this.RbSpieler.Name = "RbSpieler";
            this.RbSpieler.Size = new System.Drawing.Size(57, 17);
            this.RbSpieler.TabIndex = 9;
            this.RbSpieler.TabStop = true;
            this.RbSpieler.Text = "Spieler";
            this.RbSpieler.UseVisualStyleBackColor = true;
            this.RbSpieler.CheckedChanged += new System.EventHandler(this.RbSpieler_CheckedChanged);
            // 
            // CbGetränk
            // 
            this.CbGetränk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGetränk.FormattingEnabled = true;
            this.CbGetränk.Location = new System.Drawing.Point(9, 79);
            this.CbGetränk.Name = "CbGetränk";
            this.CbGetränk.Size = new System.Drawing.Size(185, 21);
            this.CbGetränk.TabIndex = 8;
            // 
            // BtnSchließen
            // 
            this.BtnSchließen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSchließen.Location = new System.Drawing.Point(470, 592);
            this.BtnSchließen.Name = "BtnSchließen";
            this.BtnSchließen.Size = new System.Drawing.Size(104, 36);
            this.BtnSchließen.TabIndex = 8;
            this.BtnSchließen.Text = "Highscore beenden";
            this.BtnSchließen.UseVisualStyleBackColor = true;
            this.BtnSchließen.Click += new System.EventHandler(this.BtnSchließen_Click);
            // 
            // TimerRundenzeit
            // 
            this.TimerRundenzeit.Tick += new System.EventHandler(this.TimerRundenzeitTick);
            // 
            // BtnShowMessage
            // 
            this.BtnShowMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnShowMessage.Location = new System.Drawing.Point(316, 490);
            this.BtnShowMessage.Name = "BtnShowMessage";
            this.BtnShowMessage.Size = new System.Drawing.Size(94, 34);
            this.BtnShowMessage.TabIndex = 9;
            this.BtnShowMessage.Text = "Nachricht anzeigen";
            this.BtnShowMessage.UseVisualStyleBackColor = true;
            this.BtnShowMessage.Click += new System.EventHandler(this.BtnMitteilungClick);
            // 
            // BtnCloseMessage
            // 
            this.BtnCloseMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCloseMessage.Enabled = false;
            this.BtnCloseMessage.Location = new System.Drawing.Point(445, 490);
            this.BtnCloseMessage.Name = "BtnCloseMessage";
            this.BtnCloseMessage.Size = new System.Drawing.Size(94, 34);
            this.BtnCloseMessage.TabIndex = 10;
            this.BtnCloseMessage.Text = "Nachricht ausblenden";
            this.BtnCloseMessage.UseVisualStyleBackColor = true;
            this.BtnCloseMessage.Click += new System.EventHandler(this.BtnCloseMessageClick);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(22, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "Version";
            // 
            // ttInfo
            // 
            this.ttInfo.AutomaticDelay = 100;
            this.ttInfo.AutoPopDelay = 10000;
            this.ttInfo.InitialDelay = 100;
            this.ttInfo.ReshowDelay = 20;
            this.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.ttInfo.ToolTipTitle = "Achtung";
            // 
            // BtnLogs
            // 
            this.BtnLogs.Location = new System.Drawing.Point(316, 592);
            this.BtnLogs.Name = "BtnLogs";
            this.BtnLogs.Size = new System.Drawing.Size(94, 34);
            this.BtnLogs.TabIndex = 15;
            this.BtnLogs.Text = "Öffne Ranglisten";
            this.BtnLogs.UseVisualStyleBackColor = true;
            this.BtnLogs.Click += new System.EventHandler(this.BtnLogs_Click);
            // 
            // Eingabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 640);
            this.Controls.Add(this.BtnLogs);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.BtnCloseMessage);
            this.Controls.Add(this.BtnShowMessage);
            this.Controls.Add(this.BtnSchließen);
            this.Controls.Add(this.GbRunde);
            this.Controls.Add(this.GbAktualisieren);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(602, 598);
            this.Name = "Eingabe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eingabe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Eingabe_FormClosing);
            this.Load += new System.EventHandler(this.Eingabe_Load);
            this.DoubleClick += new System.EventHandler(this.Eingabe_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.GbAktualisieren.ResumeLayout(false);
            this.GbAktualisieren.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnzahl)).EndInit();
            this.GbRunde.ResumeLayout(false);
            this.GbRunde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button BtnCloseMessage;
        private System.Windows.Forms.Button BtnShowMessage;
        private System.Windows.Forms.Timer TimerRundenzeit;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.Label LblRundenzeit;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LbSpieler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LbAktuelleSpieler;
        private System.Windows.Forms.Button BtnHinzu;
        private System.Windows.Forms.Button BtnLöschen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnNeuerSpieler;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.GroupBox GbAktualisieren;
        private System.Windows.Forms.Button BtnBestätigen;
        private System.Windows.Forms.NumericUpDown NudAnzahl;
        private System.Windows.Forms.Label LblSpieler;
        private System.Windows.Forms.Label LblAuswahl;
        private System.Windows.Forms.Button BtnBeenden;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblGetraenk;
        private System.Windows.Forms.GroupBox GbRunde;
        private System.Windows.Forms.ComboBox CbGetränk;
        private System.Windows.Forms.Button BtnSchließen;
        private System.Windows.Forms.RadioButton RbTeams;
        private System.Windows.Forms.RadioButton RbSpieler;
        
        
        //Variable ändern wenn Rundenzeit geändert wird
        void NumericUpDownTimeValueChanged(object sender, System.EventArgs e)
        {
        	_rundenzeit = Convert.ToInt32(numericUpDownTime.Value);
        }
        private ComboBox cbRundendauer;
        private CheckBox cbSonstiges;
        private Label lblVersion;
        private ToolTip ttInfo;
        private Button BtnLogs;
    }
}