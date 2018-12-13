namespace AlphaMon
{
    partial class GameForm
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
            this.lblHPBar = new System.Windows.Forms.Label();
            this.lblOwnName = new System.Windows.Forms.Label();
            this.lblOpponentStatus = new System.Windows.Forms.Label();
            this.lblOpponentHPBar = new System.Windows.Forms.Label();
            this.btnSwapAlphamon = new System.Windows.Forms.Button();
            this.lbxMoves = new System.Windows.Forms.ListBox();
            this.lblOwnStatus = new System.Windows.Forms.Label();
            this.lblOpponentName = new System.Windows.Forms.Label();
            this.lblTurnState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHPBar
            // 
            this.lblHPBar.AutoSize = true;
            this.lblHPBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHPBar.Location = new System.Drawing.Point(12, 28);
            this.lblHPBar.Name = "lblHPBar";
            this.lblHPBar.Size = new System.Drawing.Size(94, 55);
            this.lblHPBar.TabIndex = 0;
            this.lblHPBar.Text = "5/7";
            // 
            // lblOwnName
            // 
            this.lblOwnName.AutoSize = true;
            this.lblOwnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnName.Location = new System.Drawing.Point(231, 28);
            this.lblOwnName.Name = "lblOwnName";
            this.lblOwnName.Size = new System.Drawing.Size(114, 39);
            this.lblOwnName.TabIndex = 1;
            this.lblOwnName.Text = "Naam";
            // 
            // lblOpponentStatus
            // 
            this.lblOpponentStatus.AutoSize = true;
            this.lblOpponentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentStatus.Location = new System.Drawing.Point(672, 67);
            this.lblOpponentStatus.Name = "lblOpponentStatus";
            this.lblOpponentStatus.Size = new System.Drawing.Size(159, 39);
            this.lblOpponentStatus.TabIndex = 3;
            this.lblOpponentStatus.Text = "STATUS";
            // 
            // lblOpponentHPBar
            // 
            this.lblOpponentHPBar.AutoSize = true;
            this.lblOpponentHPBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentHPBar.Location = new System.Drawing.Point(490, 28);
            this.lblOpponentHPBar.Name = "lblOpponentHPBar";
            this.lblOpponentHPBar.Size = new System.Drawing.Size(94, 55);
            this.lblOpponentHPBar.TabIndex = 2;
            this.lblOpponentHPBar.Text = "5/7";
            // 
            // btnSwapAlphamon
            // 
            this.btnSwapAlphamon.Location = new System.Drawing.Point(577, 144);
            this.btnSwapAlphamon.Name = "btnSwapAlphamon";
            this.btnSwapAlphamon.Size = new System.Drawing.Size(175, 84);
            this.btnSwapAlphamon.TabIndex = 4;
            this.btnSwapAlphamon.Text = "Swap Alphamon";
            this.btnSwapAlphamon.UseVisualStyleBackColor = true;
            this.btnSwapAlphamon.Click += new System.EventHandler(this.btnSwapAlphamon_Click);
            // 
            // lbxMoves
            // 
            this.lbxMoves.BackColor = System.Drawing.SystemColors.Control;
            this.lbxMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMoves.FormattingEnabled = true;
            this.lbxMoves.ItemHeight = 73;
            this.lbxMoves.Items.AddRange(new object[] {
            "Move 1",
            "Move 2",
            "Move 3",
            "Move 4"});
            this.lbxMoves.Location = new System.Drawing.Point(79, 109);
            this.lbxMoves.Name = "lbxMoves";
            this.lbxMoves.Size = new System.Drawing.Size(492, 296);
            this.lbxMoves.TabIndex = 5;
            this.lbxMoves.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxMoves_MouseClick);
            // 
            // lblOwnStatus
            // 
            this.lblOwnStatus.AutoSize = true;
            this.lblOwnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnStatus.Location = new System.Drawing.Point(231, 67);
            this.lblOwnStatus.Name = "lblOwnStatus";
            this.lblOwnStatus.Size = new System.Drawing.Size(159, 39);
            this.lblOwnStatus.TabIndex = 6;
            this.lblOwnStatus.Text = "STATUS";
            // 
            // lblOpponentName
            // 
            this.lblOpponentName.AutoSize = true;
            this.lblOpponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentName.Location = new System.Drawing.Point(674, 28);
            this.lblOpponentName.Name = "lblOpponentName";
            this.lblOpponentName.Size = new System.Drawing.Size(114, 39);
            this.lblOpponentName.TabIndex = 7;
            this.lblOpponentName.Text = "Naam";
            // 
            // lblTurnState
            // 
            this.lblTurnState.AutoSize = true;
            this.lblTurnState.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnState.Location = new System.Drawing.Point(31, 459);
            this.lblTurnState.Name = "lblTurnState";
            this.lblTurnState.Size = new System.Drawing.Size(368, 37);
            this.lblTurnState.TabIndex = 8;
            this.lblTurnState.Text = "Please choose a move!";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 530);
            this.Controls.Add(this.lblTurnState);
            this.Controls.Add(this.lblOpponentName);
            this.Controls.Add(this.lblOwnStatus);
            this.Controls.Add(this.lbxMoves);
            this.Controls.Add(this.btnSwapAlphamon);
            this.Controls.Add(this.lblOpponentStatus);
            this.Controls.Add(this.lblOpponentHPBar);
            this.Controls.Add(this.lblOwnName);
            this.Controls.Add(this.lblHPBar);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHPBar;
        private System.Windows.Forms.Label lblOwnName;
        private System.Windows.Forms.Label lblOpponentStatus;
        private System.Windows.Forms.Label lblOpponentHPBar;
        private System.Windows.Forms.Button btnSwapAlphamon;
        private System.Windows.Forms.ListBox lbxMoves;
        private System.Windows.Forms.Label lblOwnStatus;
        private System.Windows.Forms.Label lblOpponentName;
        private System.Windows.Forms.Label lblTurnState;
    }
}