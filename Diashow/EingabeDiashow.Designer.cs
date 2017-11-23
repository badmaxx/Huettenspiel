namespace Hüttensammlung.Diashow
{
    partial class EingabeDiashow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EingabeDiashow));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LblAnzahlBilder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPfad = new System.Windows.Forms.TextBox();
            this.BtnDurchsuchen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NudAnzeigezeit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAnzeigen = new System.Windows.Forms.Button();
            this.TimerAnzeige = new System.Windows.Forms.Timer(this.components);
            this.PbBild = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDiashow = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnzeigezeit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBild)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox4.Controls.Add(this.LblAnzahlBilder);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.TxtPfad);
            this.groupBox4.Controls.Add(this.BtnDurchsuchen);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.NudAnzeigezeit);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.BtnAnzeigen);
            this.groupBox4.Location = new System.Drawing.Point(8, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(448, 123);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Diashow";
            // 
            // LblAnzahlBilder
            // 
            this.LblAnzahlBilder.AutoSize = true;
            this.LblAnzahlBilder.Location = new System.Drawing.Point(6, 61);
            this.LblAnzahlBilder.Name = "LblAnzahlBilder";
            this.LblAnzahlBilder.Size = new System.Drawing.Size(93, 13);
            this.LblAnzahlBilder.TabIndex = 21;
            this.LblAnzahlBilder.Text = "0 Bilder gefunden!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pfad zu Bilderordner";
            // 
            // TxtPfad
            // 
            this.TxtPfad.Location = new System.Drawing.Point(9, 38);
            this.TxtPfad.Name = "TxtPfad";
            this.TxtPfad.Size = new System.Drawing.Size(331, 20);
            this.TxtPfad.TabIndex = 19;
            // 
            // BtnDurchsuchen
            // 
            this.BtnDurchsuchen.Location = new System.Drawing.Point(348, 38);
            this.BtnDurchsuchen.Name = "BtnDurchsuchen";
            this.BtnDurchsuchen.Size = new System.Drawing.Size(94, 22);
            this.BtnDurchsuchen.TabIndex = 18;
            this.BtnDurchsuchen.Text = "Durchsuchen";
            this.BtnDurchsuchen.UseVisualStyleBackColor = true;
            this.BtnDurchsuchen.Click += new System.EventHandler(this.BtnDurchsuchen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sekunden";
            // 
            // NudAnzeigezeit
            // 
            this.NudAnzeigezeit.Location = new System.Drawing.Point(111, 90);
            this.NudAnzeigezeit.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NudAnzeigezeit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAnzeigezeit.Name = "NudAnzeigezeit";
            this.NudAnzeigezeit.Size = new System.Drawing.Size(46, 20);
            this.NudAnzeigezeit.TabIndex = 16;
            this.NudAnzeigezeit.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Anzeigezeit pro Bild";
            // 
            // BtnAnzeigen
            // 
            this.BtnAnzeigen.Location = new System.Drawing.Point(348, 81);
            this.BtnAnzeigen.Name = "BtnAnzeigen";
            this.BtnAnzeigen.Size = new System.Drawing.Size(94, 24);
            this.BtnAnzeigen.TabIndex = 11;
            this.BtnAnzeigen.Text = "Starten";
            this.BtnAnzeigen.UseVisualStyleBackColor = true;
            this.BtnAnzeigen.Click += new System.EventHandler(this.BtnAnzeigen_Click);
            // 
            // TimerAnzeige
            // 
            this.TimerAnzeige.Tick += new System.EventHandler(this.TimerAnzeige_Tick);
            // 
            // PbBild
            // 
            this.PbBild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbBild.Location = new System.Drawing.Point(8, 12);
            this.PbBild.Name = "PbBild";
            this.PbBild.Size = new System.Drawing.Size(448, 158);
            this.PbBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbBild.TabIndex = 15;
            this.PbBild.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDiashow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(468, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblDiashow
            // 
            this.lblDiashow.Name = "lblDiashow";
            this.lblDiashow.Size = new System.Drawing.Size(12, 17);
            this.lblDiashow.Text = "-";
            // 
            // EingabeDiashow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 324);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PbBild);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(484, 363);
            this.Name = "EingabeDiashow";
            this.Text = "Diashow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EingabeDiashow_FormClosing);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnzeigezeit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBild)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnAnzeigen;
        private System.Windows.Forms.NumericUpDown NudAnzeigezeit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TimerAnzeige;
        private System.Windows.Forms.PictureBox PbBild;
        private System.Windows.Forms.Button BtnDurchsuchen;
        private System.Windows.Forms.TextBox TxtPfad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblAnzahlBilder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDiashow;
    }
}