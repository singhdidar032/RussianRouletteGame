namespace RussianRoulette
{
    partial class Form1
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
            this.BtnStartRound = new System.Windows.Forms.Button();
            this.LblWins = new System.Windows.Forms.Label();
            this.LblLoses = new System.Windows.Forms.Label();
            this.Balloon5 = new System.Windows.Forms.PictureBox();
            this.Balloon4 = new System.Windows.Forms.PictureBox();
            this.Balloon3 = new System.Windows.Forms.PictureBox();
            this.Balloon2 = new System.Windows.Forms.PictureBox();
            this.Balloon1 = new System.Windows.Forms.PictureBox();
            this.Balloon0 = new System.Windows.Forms.PictureBox();
            this.LblRoundWin = new System.Windows.Forms.Label();
            this.LblRoundLoss = new System.Windows.Forms.Label();
            this.LblRules = new System.Windows.Forms.Label();
            this.LblDialog1 = new System.Windows.Forms.Label();
            this.LblDialog2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Balloon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balloon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balloon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balloon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balloon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balloon0)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStartRound
            // 
            this.BtnStartRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnStartRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartRound.Location = new System.Drawing.Point(385, 453);
            this.BtnStartRound.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStartRound.Name = "BtnStartRound";
            this.BtnStartRound.Size = new System.Drawing.Size(349, 75);
            this.BtnStartRound.TabIndex = 6;
            this.BtnStartRound.Text = "START ROUND";
            this.BtnStartRound.UseVisualStyleBackColor = false;
            this.BtnStartRound.Click += new System.EventHandler(this.BtnStartRound_Click);
            // 
            // LblWins
            // 
            this.LblWins.AutoSize = true;
            this.LblWins.Location = new System.Drawing.Point(28, 260);
            this.LblWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblWins.Name = "LblWins";
            this.LblWins.Size = new System.Drawing.Size(55, 17);
            this.LblWins.TabIndex = 7;
            this.LblWins.Text = "Wins: 0";
            // 
            // LblLoses
            // 
            this.LblLoses.AutoSize = true;
            this.LblLoses.Location = new System.Drawing.Point(28, 276);
            this.LblLoses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLoses.Name = "LblLoses";
            this.LblLoses.Size = new System.Drawing.Size(62, 17);
            this.LblLoses.TabIndex = 8;
            this.LblLoses.Text = "Loses: 0";
            // 
            // Balloon5
            // 
            this.Balloon5.Enabled = false;
            this.Balloon5.Image = global::RussianRoulette.Properties.Resources.BalloonYellow;
            this.Balloon5.Location = new System.Drawing.Point(921, 15);
            this.Balloon5.Margin = new System.Windows.Forms.Padding(4);
            this.Balloon5.Name = "Balloon5";
            this.Balloon5.Size = new System.Drawing.Size(171, 236);
            this.Balloon5.TabIndex = 5;
            this.Balloon5.TabStop = false;
            this.Balloon5.Tag = "";
            this.Balloon5.Click += new System.EventHandler(this.Balloon_Click);
            // 
            // Balloon4
            // 
            this.Balloon4.Enabled = false;
            this.Balloon4.Image = global::RussianRoulette.Properties.Resources.BalloonRed;
            this.Balloon4.Location = new System.Drawing.Point(743, 15);
            this.Balloon4.Margin = new System.Windows.Forms.Padding(4);
            this.Balloon4.Name = "Balloon4";
            this.Balloon4.Size = new System.Drawing.Size(171, 236);
            this.Balloon4.TabIndex = 4;
            this.Balloon4.TabStop = false;
            this.Balloon4.Tag = "";
            this.Balloon4.Click += new System.EventHandler(this.Balloon_Click);
            // 
            // Balloon3
            // 
            this.Balloon3.Enabled = false;
            this.Balloon3.Image = global::RussianRoulette.Properties.Resources.BalloonPurple;
            this.Balloon3.Location = new System.Drawing.Point(564, 15);
            this.Balloon3.Margin = new System.Windows.Forms.Padding(4);
            this.Balloon3.Name = "Balloon3";
            this.Balloon3.Size = new System.Drawing.Size(171, 236);
            this.Balloon3.TabIndex = 3;
            this.Balloon3.TabStop = false;
            this.Balloon3.Tag = "";
            this.Balloon3.Click += new System.EventHandler(this.Balloon_Click);
            // 
            // Balloon2
            // 
            this.Balloon2.Enabled = false;
            this.Balloon2.Image = global::RussianRoulette.Properties.Resources.BalloonGreen;
            this.Balloon2.Location = new System.Drawing.Point(385, 15);
            this.Balloon2.Margin = new System.Windows.Forms.Padding(4);
            this.Balloon2.Name = "Balloon2";
            this.Balloon2.Size = new System.Drawing.Size(171, 236);
            this.Balloon2.TabIndex = 2;
            this.Balloon2.TabStop = false;
            this.Balloon2.Tag = "";
            this.Balloon2.Click += new System.EventHandler(this.Balloon_Click);
            // 
            // Balloon1
            // 
            this.Balloon1.Enabled = false;
            this.Balloon1.Image = global::RussianRoulette.Properties.Resources.BalloonBlue;
            this.Balloon1.Location = new System.Drawing.Point(207, 15);
            this.Balloon1.Margin = new System.Windows.Forms.Padding(4);
            this.Balloon1.Name = "Balloon1";
            this.Balloon1.Size = new System.Drawing.Size(171, 236);
            this.Balloon1.TabIndex = 1;
            this.Balloon1.TabStop = false;
            this.Balloon1.Tag = "";
            this.Balloon1.Click += new System.EventHandler(this.Balloon_Click);
            // 
            // Balloon0
            // 
            this.Balloon0.Enabled = false;
            this.Balloon0.Image = global::RussianRoulette.Properties.Resources.BalloonBlack;
            this.Balloon0.Location = new System.Drawing.Point(28, 15);
            this.Balloon0.Margin = new System.Windows.Forms.Padding(4);
            this.Balloon0.Name = "Balloon0";
            this.Balloon0.Size = new System.Drawing.Size(171, 236);
            this.Balloon0.TabIndex = 0;
            this.Balloon0.TabStop = false;
            this.Balloon0.Click += new System.EventHandler(this.Balloon_Click);
            // 
            // LblRoundWin
            // 
            this.LblRoundWin.AutoSize = true;
            this.LblRoundWin.Enabled = false;
            this.LblRoundWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Bold);
            this.LblRoundWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblRoundWin.Location = new System.Drawing.Point(64, 268);
            this.LblRoundWin.Margin = new System.Windows.Forms.Padding(0);
            this.LblRoundWin.Name = "LblRoundWin";
            this.LblRoundWin.Size = new System.Drawing.Size(1028, 181);
            this.LblRoundWin.TabIndex = 9;
            this.LblRoundWin.Text = "ROUND WIN";
            this.LblRoundWin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblRoundWin.Visible = false;
            // 
            // LblRoundLoss
            // 
            this.LblRoundLoss.AutoSize = true;
            this.LblRoundLoss.Enabled = false;
            this.LblRoundLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Bold);
            this.LblRoundLoss.ForeColor = System.Drawing.Color.Red;
            this.LblRoundLoss.Location = new System.Drawing.Point(48, 268);
            this.LblRoundLoss.Margin = new System.Windows.Forms.Padding(0);
            this.LblRoundLoss.Name = "LblRoundLoss";
            this.LblRoundLoss.Size = new System.Drawing.Size(1145, 181);
            this.LblRoundLoss.TabIndex = 10;
            this.LblRoundLoss.Text = "ROUND LOSS";
            this.LblRoundLoss.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblRoundLoss.Visible = false;
            // 
            // LblRules
            // 
            this.LblRules.AutoSize = true;
            this.LblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRules.Location = new System.Drawing.Point(32, 308);
            this.LblRules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRules.Name = "LblRules";
            this.LblRules.Size = new System.Drawing.Size(0, 36);
            this.LblRules.TabIndex = 11;
            // 
            // LblDialog1
            // 
            this.LblDialog1.AutoSize = true;
            this.LblDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDialog1.Location = new System.Drawing.Point(91, 316);
            this.LblDialog1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDialog1.Name = "LblDialog1";
            this.LblDialog1.Size = new System.Drawing.Size(756, 31);
            this.LblDialog1.TabIndex = 12;
            this.LblDialog1.Text = "Unfortunately, one of these balloons is rigged with explosives.";
            // 
            // LblDialog2
            // 
            this.LblDialog2.AutoSize = true;
            this.LblDialog2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDialog2.Location = new System.Drawing.Point(23, 364);
            this.LblDialog2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDialog2.Name = "LblDialog2";
            this.LblDialog2.Size = new System.Drawing.Size(877, 31);
            this.LblDialog2.TabIndex = 13;
            this.LblDialog2.Text = "Your goal is to safely pop any 4 of these balloons without any exploding.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 601);
            this.Controls.Add(this.LblDialog2);
            this.Controls.Add(this.LblDialog1);
            this.Controls.Add(this.LblRules);
            this.Controls.Add(this.LblRoundLoss);
            this.Controls.Add(this.LblRoundWin);
            this.Controls.Add(this.LblLoses);
            this.Controls.Add(this.LblWins);
            this.Controls.Add(this.BtnStartRound);
            this.Controls.Add(this.Balloon5);
            this.Controls.Add(this.Balloon4);
            this.Controls.Add(this.Balloon3);
            this.Controls.Add(this.Balloon2);
            this.Controls.Add(this.Balloon1);
            this.Controls.Add(this.Balloon0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pop The Balloons!";
            ((System.ComponentModel.ISupportInitialize)(this.Balloon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balloon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balloon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balloon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balloon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balloon0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Balloon0;
        private System.Windows.Forms.PictureBox Balloon1;
        private System.Windows.Forms.PictureBox Balloon2;
        private System.Windows.Forms.PictureBox Balloon3;
        private System.Windows.Forms.PictureBox Balloon4;
        private System.Windows.Forms.PictureBox Balloon5;
        private System.Windows.Forms.Button BtnStartRound;
        private System.Windows.Forms.Label LblWins;
        private System.Windows.Forms.Label LblLoses;
        private System.Windows.Forms.Label LblRoundWin;
        private System.Windows.Forms.Label LblRoundLoss;
        private System.Windows.Forms.Label LblRules;
        private System.Windows.Forms.Label LblDialog1;
        private System.Windows.Forms.Label LblDialog2;
    }
}

