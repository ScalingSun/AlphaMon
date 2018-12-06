namespace AlphaMon
{
    partial class frmRegister
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
            this.lblRegisterTitle = new System.Windows.Forms.Label();
            this.txtUsernameRegister = new System.Windows.Forms.TextBox();
            this.txtPasswordRegister = new System.Windows.Forms.TextBox();
            this.lblUsernameRegister = new System.Windows.Forms.Label();
            this.lblPasswordRegister = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegisterTitle
            // 
            this.lblRegisterTitle.AutoSize = true;
            this.lblRegisterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterTitle.Location = new System.Drawing.Point(95, 24);
            this.lblRegisterTitle.Name = "lblRegisterTitle";
            this.lblRegisterTitle.Size = new System.Drawing.Size(132, 37);
            this.lblRegisterTitle.TabIndex = 0;
            this.lblRegisterTitle.Text = "Sign-Up";
            // 
            // txtUsernameRegister
            // 
            this.txtUsernameRegister.Location = new System.Drawing.Point(139, 76);
            this.txtUsernameRegister.Name = "txtUsernameRegister";
            this.txtUsernameRegister.Size = new System.Drawing.Size(100, 20);
            this.txtUsernameRegister.TabIndex = 1;
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.Location = new System.Drawing.Point(139, 110);
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordRegister.TabIndex = 2;
            // 
            // lblUsernameRegister
            // 
            this.lblUsernameRegister.AutoSize = true;
            this.lblUsernameRegister.Location = new System.Drawing.Point(82, 79);
            this.lblUsernameRegister.Name = "lblUsernameRegister";
            this.lblUsernameRegister.Size = new System.Drawing.Size(55, 13);
            this.lblUsernameRegister.TabIndex = 3;
            this.lblUsernameRegister.Text = "Username";
            // 
            // lblPasswordRegister
            // 
            this.lblPasswordRegister.AutoSize = true;
            this.lblPasswordRegister.Location = new System.Drawing.Point(84, 113);
            this.lblPasswordRegister.Name = "lblPasswordRegister";
            this.lblPasswordRegister.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordRegister.TabIndex = 4;
            this.lblPasswordRegister.Text = "Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(122, 156);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 228);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPasswordRegister);
            this.Controls.Add(this.lblUsernameRegister);
            this.Controls.Add(this.txtPasswordRegister);
            this.Controls.Add(this.txtUsernameRegister);
            this.Controls.Add(this.lblRegisterTitle);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisterTitle;
        private System.Windows.Forms.TextBox txtUsernameRegister;
        private System.Windows.Forms.TextBox txtPasswordRegister;
        private System.Windows.Forms.Label lblUsernameRegister;
        private System.Windows.Forms.Label lblPasswordRegister;
        private System.Windows.Forms.Button btnRegister;
    }
}