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
            this.pnlCreateCompany = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblCreateCompany = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.MaskedTextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ucTemplate1 = new Count.UCTemplate();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.pnlCreateCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCreateCompany
            // 
            this.pnlCreateCompany.BackColor = System.Drawing.Color.Transparent;
            this.pnlCreateCompany.Controls.Add(this.dtpStartDate);
            this.pnlCreateCompany.Controls.Add(this.dtpEndDate);
            this.pnlCreateCompany.Controls.Add(this.btnSubmit);
            this.pnlCreateCompany.Controls.Add(this.tbUserName);
            this.pnlCreateCompany.Controls.Add(this.tbUserID);
            this.pnlCreateCompany.Controls.Add(this.lblEndDate);
            this.pnlCreateCompany.Controls.Add(this.lblStartDate);
            this.pnlCreateCompany.Controls.Add(this.lblUserName);
            this.pnlCreateCompany.Controls.Add(this.lblUserID);
            this.pnlCreateCompany.Controls.Add(this.lblCreateCompany);
            this.pnlCreateCompany.Location = new System.Drawing.Point(402, 198);
            this.pnlCreateCompany.Name = "pnlCreateCompany";
            this.pnlCreateCompany.Size = new System.Drawing.Size(506, 292);
            this.pnlCreateCompany.TabIndex = 1;
            this.pnlCreateCompany.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCreateCompany_Paint);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(31, 81);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(43, 13);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "User ID";
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
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(31, 120);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(31, 158);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(31, 194);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End Date";
            // 
            // tbUserID
            // 
            this.tbUserID.Enabled = false;
            this.tbUserID.Location = new System.Drawing.Point(109, 78);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(168, 20);
            this.tbUserID.TabIndex = 5;
            this.tbUserID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(109, 117);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(353, 20);
            this.tbUserName.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(217, 242);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
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
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(109, 188);
            this.dtpEndDate.MinDate = new System.DateTime(2000, 4, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(109, 152);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 11;
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
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblCreateCompany;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.MaskedTextBox tbUserID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}