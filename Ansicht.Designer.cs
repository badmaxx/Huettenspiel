﻿namespace Hüttenspiel
{
    partial class Ansicht
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblGetränk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvRangliste = new System.Windows.Forms.DataGridView();
            this.Rang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spieler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bild = new System.Windows.Forms.DataGridViewImageColumn();
            this.LblBestenliste = new System.Windows.Forms.Label();
            this.TimerBestenliste = new System.Windows.Forms.Timer(this.components);
            this.PbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRangliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblGetränk
            // 
            this.LblGetränk.AutoSize = true;
            this.LblGetränk.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGetränk.Location = new System.Drawing.Point(333, 9);
            this.LblGetränk.Name = "LblGetränk";
            this.LblGetränk.Size = new System.Drawing.Size(0, 55);
            this.LblGetränk.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "HIGHSCORE";
            // 
            // DgvRangliste
            // 
            this.DgvRangliste.AllowUserToAddRows = false;
            this.DgvRangliste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvRangliste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvRangliste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvRangliste.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvRangliste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRangliste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvRangliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRangliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rang,
            this.Spieler,
            this.Anzahl,
            this.Bild});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRangliste.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvRangliste.Location = new System.Drawing.Point(12, 66);
            this.DgvRangliste.Name = "DgvRangliste";
            this.DgvRangliste.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvRangliste.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvRangliste.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvRangliste.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DgvRangliste.ShowCellErrors = false;
            this.DgvRangliste.ShowRowErrors = false;
            this.DgvRangliste.Size = new System.Drawing.Size(908, 314);
            this.DgvRangliste.TabIndex = 9;
            // 
            // Rang
            // 
            this.Rang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Rang.DefaultCellStyle = dataGridViewCellStyle2;
            this.Rang.FillWeight = 37.81512F;
            this.Rang.HeaderText = "Platz";
            this.Rang.Name = "Rang";
            this.Rang.Width = 200;
            // 
            // Spieler
            // 
            this.Spieler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Spieler.DefaultCellStyle = dataGridViewCellStyle3;
            this.Spieler.HeaderText = "Name";
            this.Spieler.Name = "Spieler";
            this.Spieler.Width = 228;
            // 
            // Anzahl
            // 
            this.Anzahl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Anzahl.DefaultCellStyle = dataGridViewCellStyle4;
            this.Anzahl.HeaderText = "Anzahl";
            this.Anzahl.Name = "Anzahl";
            this.Anzahl.Width = 254;
            // 
            // Bild
            // 
            this.Bild.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Bild.FillWeight = 15.31315F;
            this.Bild.HeaderText = "";
            this.Bild.Name = "Bild";
            this.Bild.Width = 5;
            // 
            // LblBestenliste
            // 
            this.LblBestenliste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LblBestenliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBestenliste.Location = new System.Drawing.Point(9, 383);
            this.LblBestenliste.Name = "LblBestenliste";
            this.LblBestenliste.Size = new System.Drawing.Size(911, 49);
            this.LblBestenliste.TabIndex = 10;
            this.LblBestenliste.Text = "-";
            // 
            // TimerBestenliste
            // 
            this.TimerBestenliste.Enabled = true;
            this.TimerBestenliste.Interval = 10000;
            this.TimerBestenliste.Tick += new System.EventHandler(this.TimerBestenliste_Tick);
            // 
            // PbLogo
            // 
            this.PbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbLogo.Image = global::Hüttenspiel.Properties.Resources.Logo_Huette;
            this.PbLogo.InitialImage = null;
            this.PbLogo.Location = new System.Drawing.Point(821, -9);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(99, 73);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 11;
            this.PbLogo.TabStop = false;
            // 
            // Ansicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(932, 447);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.LblBestenliste);
            this.Controls.Add(this.DgvRangliste);
            this.Controls.Add(this.LblGetränk);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ansicht";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "HIGHSCORE";
            this.Load += new System.EventHandler(this.Ansicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRangliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGetränk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvRangliste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spieler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anzahl;
        private System.Windows.Forms.DataGridViewImageColumn Bild;
        private System.Windows.Forms.Label LblBestenliste;
        private System.Windows.Forms.Timer TimerBestenliste;
        private System.Windows.Forms.PictureBox PbLogo;
    }
}