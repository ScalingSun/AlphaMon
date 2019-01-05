namespace Alphamon
{
    partial class Menu
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
            this.lblP1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblP1Elo = new System.Windows.Forms.Label();
            this.lblP1Wins = new System.Windows.Forms.Label();
            this.lblP1Losses = new System.Windows.Forms.Label();
            this.lblP2losses = new System.Windows.Forms.Label();
            this.lblP2wins = new System.Windows.Forms.Label();
            this.lblP2elo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(27, 28);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(118, 13);
            this.lblP1.TabIndex = 1;
            this.lblP1.Text = "Speler1 : <playername>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speler2: <playername>";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(30, 352);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(194, 67);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "start game (1 vs 1)";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "start game (1 vs Bot)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblP1Elo
            // 
            this.lblP1Elo.AutoSize = true;
            this.lblP1Elo.Location = new System.Drawing.Point(27, 59);
            this.lblP1Elo.Name = "lblP1Elo";
            this.lblP1Elo.Size = new System.Drawing.Size(0, 13);
            this.lblP1Elo.TabIndex = 5;
            // 
            // lblP1Wins
            // 
            this.lblP1Wins.AutoSize = true;
            this.lblP1Wins.Location = new System.Drawing.Point(27, 90);
            this.lblP1Wins.Name = "lblP1Wins";
            this.lblP1Wins.Size = new System.Drawing.Size(0, 13);
            this.lblP1Wins.TabIndex = 6;
            // 
            // lblP1Losses
            // 
            this.lblP1Losses.AutoSize = true;
            this.lblP1Losses.Location = new System.Drawing.Point(27, 116);
            this.lblP1Losses.Name = "lblP1Losses";
            this.lblP1Losses.Size = new System.Drawing.Size(0, 13);
            this.lblP1Losses.TabIndex = 7;
            // 
            // lblP2losses
            // 
            this.lblP2losses.AutoSize = true;
            this.lblP2losses.Location = new System.Drawing.Point(570, 125);
            this.lblP2losses.Name = "lblP2losses";
            this.lblP2losses.Size = new System.Drawing.Size(0, 13);
            this.lblP2losses.TabIndex = 10;
            // 
            // lblP2wins
            // 
            this.lblP2wins.AutoSize = true;
            this.lblP2wins.Location = new System.Drawing.Point(570, 99);
            this.lblP2wins.Name = "lblP2wins";
            this.lblP2wins.Size = new System.Drawing.Size(0, 13);
            this.lblP2wins.TabIndex = 9;
            // 
            // lblP2elo
            // 
            this.lblP2elo.AutoSize = true;
            this.lblP2elo.Location = new System.Drawing.Point(570, 69);
            this.lblP2elo.Name = "lblP2elo";
            this.lblP2elo.Size = new System.Drawing.Size(0, 13);
            this.lblP2elo.TabIndex = 8;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblP2losses);
            this.Controls.Add(this.lblP2wins);
            this.Controls.Add(this.lblP2elo);
            this.Controls.Add(this.lblP1Losses);
            this.Controls.Add(this.lblP1Wins);
            this.Controls.Add(this.lblP1Elo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.btnStartGame);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblP1Elo;
        private System.Windows.Forms.Label lblP1Wins;
        private System.Windows.Forms.Label lblP1Losses;
        private System.Windows.Forms.Label lblP2losses;
        private System.Windows.Forms.Label lblP2wins;
        private System.Windows.Forms.Label lblP2elo;
    }
}