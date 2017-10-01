namespace Count.Forms
{
    partial class C1_2_CreateCompany
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
            this.ucTemplate1 = new Count.UCTemplate();
            this.pnlCreateCompany = new System.Windows.Forms.Panel();
            this.lblCreateCompany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCreateCompany.SuspendLayout();
            this.SuspendLayout();
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
            // pnlCreateCompany
            // 
            this.pnlCreateCompany.BackColor = System.Drawing.Color.Transparent;
            this.pnlCreateCompany.Controls.Add(this.label1);
            this.pnlCreateCompany.Controls.Add(this.lblCreateCompany);
            this.pnlCreateCompany.Location = new System.Drawing.Point(41, 52);
            this.pnlCreateCompany.Name = "pnlCreateCompany";
            this.pnlCreateCompany.Size = new System.Drawing.Size(1282, 584);
            this.pnlCreateCompany.TabIndex = 1;
            // 
            // lblCreateCompany
            // 
            this.lblCreateCompany.AutoSize = true;
            this.lblCreateCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateCompany.Location = new System.Drawing.Point(26, 19);
            this.lblCreateCompany.Name = "lblCreateCompany";
            this.lblCreateCompany.Size = new System.Drawing.Size(234, 26);
            this.lblCreateCompany.TabIndex = 0;
            this.lblCreateCompany.Text = "CREATE COMPANY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // C1_2_CreateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.pnlCreateCompany);
            this.Controls.Add(this.ucTemplate1);
            this.Name = "C1_2_CreateCompany";
            this.Text = "C1_2_CreateCompany";
            this.pnlCreateCompany.ResumeLayout(false);
            this.pnlCreateCompany.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCTemplate ucTemplate1;
        private System.Windows.Forms.Panel pnlCreateCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreateCompany;
    }
}