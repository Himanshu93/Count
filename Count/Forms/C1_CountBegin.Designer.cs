namespace Count.Forms
{
    partial class C1_CountBegin
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ucTemplate1 = new Count.UCTemplate();
            this.btnSelectAccount = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnCreateAccount);
            this.pnlMenu.Controls.Add(this.btnSelectAccount);
            this.pnlMenu.Location = new System.Drawing.Point(552, 176);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(248, 310);
            this.pnlMenu.TabIndex = 1;
            // 
            // ucTemplate1
            // 
            this.ucTemplate1.AutoSize = true;
            this.ucTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTemplate1.Location = new System.Drawing.Point(0, 0);
            this.ucTemplate1.Name = "ucTemplate1";
            this.ucTemplate1.Size = new System.Drawing.Size(1384, 711);
            this.ucTemplate1.TabIndex = 0;
            // 
            // btnSelectAccount
            // 
            this.btnSelectAccount.Location = new System.Drawing.Point(50, 78);
            this.btnSelectAccount.Name = "btnSelectAccount";
            this.btnSelectAccount.Size = new System.Drawing.Size(144, 23);
            this.btnSelectAccount.TabIndex = 0;
            this.btnSelectAccount.Text = "Select Account";
            this.btnSelectAccount.UseVisualStyleBackColor = true;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(50, 145);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(144, 23);
            this.btnCreateAccount.TabIndex = 1;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(50, 208);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // C1_CountBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.ucTemplate1);
            this.Name = "C1_CountBegin";
            this.Text = "C1_CountBegin";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCTemplate ucTemplate1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnSelectAccount;
    }
}