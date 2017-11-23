namespace Hüttensammlung
{
    partial class Startfenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startfenster));
            this.BtnHighscore = new System.Windows.Forms.Button();
            this.BtnPicolo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TTFenster = new System.Windows.Forms.ToolTip(this.components);
            this.BtnDiashow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHighscore
            // 
            this.BtnHighscore.BackColor = System.Drawing.Color.Transparent;
            this.BtnHighscore.BackgroundImage = global::Hüttensammlung.Properties.Resources.Logo_Huette;
            this.BtnHighscore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnHighscore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHighscore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnHighscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHighscore.Location = new System.Drawing.Point(12, 12);
            this.BtnHighscore.Name = "BtnHighscore";
            this.BtnHighscore.Size = new System.Drawing.Size(117, 84);
            this.BtnHighscore.TabIndex = 0;
            this.TTFenster.SetToolTip(this.BtnHighscore, "Highscore");
            this.BtnHighscore.UseVisualStyleBackColor = false;
            this.BtnHighscore.Click += new System.EventHandler(this.BtnHighscore_Click);
            // 
            // BtnPicolo
            // 
            this.BtnPicolo.BackColor = System.Drawing.Color.White;
            this.BtnPicolo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPicolo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnPicolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPicolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPicolo.Image = global::Hüttensammlung.Properties.Resources.picoloIcon;
            this.BtnPicolo.Location = new System.Drawing.Point(12, 128);
            this.BtnPicolo.Name = "BtnPicolo";
            this.BtnPicolo.Size = new System.Drawing.Size(117, 84);
            this.BtnPicolo.TabIndex = 2;
            this.TTFenster.SetToolTip(this.BtnPicolo, "Picolo Trinkspiel");
            this.BtnPicolo.UseVisualStyleBackColor = false;
            this.BtnPicolo.Click += new System.EventHandler(this.BtnPicolo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(149, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 84);
            this.button1.TabIndex = 3;
            this.button1.Text = "demo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // TTFenster
            // 
            this.TTFenster.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TTFenster.ToolTipTitle = "Info";
            // 
            // BtnDiashow
            // 
            this.BtnDiashow.BackColor = System.Drawing.Color.Transparent;
            this.BtnDiashow.BackgroundImage = global::Hüttensammlung.Properties.Resources.Diashow;
            this.BtnDiashow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDiashow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDiashow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnDiashow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiashow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiashow.Location = new System.Drawing.Point(149, 12);
            this.BtnDiashow.Name = "BtnDiashow";
            this.BtnDiashow.Size = new System.Drawing.Size(117, 84);
            this.BtnDiashow.TabIndex = 7;
            this.TTFenster.SetToolTip(this.BtnDiashow, "Diashow");
            this.BtnDiashow.UseVisualStyleBackColor = false;
            this.BtnDiashow.Click += new System.EventHandler(this.BtnDiashow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Highscore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Picolo Trinkspiel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Diashow";
            // 
            // Startfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(294, 253);
            this.Controls.Add(this.BtnDiashow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnPicolo);
            this.Controls.Add(this.BtnHighscore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Startfenster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vudlalm Programme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHighscore;
        private System.Windows.Forms.Button BtnPicolo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip TTFenster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDiashow;
    }
}