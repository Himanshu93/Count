namespace Count.Forms
{
    partial class C1_1_SelectCompany
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
            this.pnlSelectCompany = new System.Windows.Forms.Panel();
            this.btnCompanyInfo = new System.Windows.Forms.Button();
            this.btnDataEntry = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.pnlSelectCompany.SuspendLayout();
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
            // pnlSelectCompany
            // 
            this.pnlSelectCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectCompany.Controls.Add(this.btnDisplay);
            this.pnlSelectCompany.Controls.Add(this.btnDataEntry);
            this.pnlSelectCompany.Controls.Add(this.btnCompanyInfo);
            this.pnlSelectCompany.Location = new System.Drawing.Point(467, 207);
            this.pnlSelectCompany.Name = "pnlSelectCompany";
            this.pnlSelectCompany.Size = new System.Drawing.Size(347, 326);
            this.pnlSelectCompany.TabIndex = 1;
            // 
            // btnCompanyInfo
            // 
            this.btnCompanyInfo.Location = new System.Drawing.Point(73, 91);
            this.btnCompanyInfo.Name = "btnCompanyInfo";
            this.btnCompanyInfo.Size = new System.Drawing.Size(187, 28);
            this.btnCompanyInfo.TabIndex = 0;
            this.btnCompanyInfo.Text = "Company Information";
            this.btnCompanyInfo.UseVisualStyleBackColor = true;
            // 
            // btnDataEntry
            // 
            this.btnDataEntry.Location = new System.Drawing.Point(73, 166);
            this.btnDataEntry.Name = "btnDataEntry";
            this.btnDataEntry.Size = new System.Drawing.Size(187, 28);
            this.btnDataEntry.TabIndex = 1;
            this.btnDataEntry.Text = "Data Entry";
            this.btnDataEntry.UseVisualStyleBackColor = true;
            this.btnDataEntry.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(73, 231);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(187, 28);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // C1_1_SelectCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.pnlSelectCompany);
            this.Controls.Add(this.ucTemplate1);
            this.Name = "C1_1_SelectCompany";
            this.Text = "C1_1_SelectCompany";
            this.pnlSelectCompany.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCTemplate ucTemplate1;
        private System.Windows.Forms.Panel pnlSelectCompany;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnDataEntry;
        private System.Windows.Forms.Button btnCompanyInfo;
    }
}