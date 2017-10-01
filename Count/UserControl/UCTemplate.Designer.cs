namespace Count
{
    partial class UCTemplate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tspContent = new System.Windows.Forms.ToolStripContainer();
            this.tlsContent = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.musContent = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspContent.BottomToolStripPanel.SuspendLayout();
            this.tspContent.TopToolStripPanel.SuspendLayout();
            this.tspContent.SuspendLayout();
            this.tlsContent.SuspendLayout();
            this.musContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspContent
            // 
            // 
            // tspContent.BottomToolStripPanel
            // 
            this.tspContent.BottomToolStripPanel.Controls.Add(this.tlsContent);
            // 
            // tspContent.ContentPanel
            // 
            this.tspContent.ContentPanel.BackColor = System.Drawing.Color.LightCyan;
            this.tspContent.ContentPanel.Size = new System.Drawing.Size(1021, 665);
            this.tspContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tspContent.Location = new System.Drawing.Point(0, 0);
            this.tspContent.Name = "tspContent";
            this.tspContent.Size = new System.Drawing.Size(1021, 714);
            this.tspContent.TabIndex = 0;
            this.tspContent.Text = "toolStripContainer1";
            // 
            // tspContent.TopToolStripPanel
            // 
            this.tspContent.TopToolStripPanel.Controls.Add(this.musContent);
            // 
            // tlsContent
            // 
            this.tlsContent.Dock = System.Windows.Forms.DockStyle.None;
            this.tlsContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.tlsContent.Location = new System.Drawing.Point(3, 0);
            this.tlsContent.Name = "tlsContent";
            this.tlsContent.Size = new System.Drawing.Size(114, 25);
            this.tlsContent.TabIndex = 0;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // musContent
            // 
            this.musContent.Dock = System.Windows.Forms.DockStyle.None;
            this.musContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.musContent.Location = new System.Drawing.Point(0, 0);
            this.musContent.Name = "musContent";
            this.musContent.Size = new System.Drawing.Size(1021, 24);
            this.musContent.TabIndex = 0;
            this.musContent.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // UCTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tspContent);
            this.Name = "UCTemplate";
            this.Size = new System.Drawing.Size(1021, 714);
            this.tspContent.BottomToolStripPanel.ResumeLayout(false);
            this.tspContent.BottomToolStripPanel.PerformLayout();
            this.tspContent.TopToolStripPanel.ResumeLayout(false);
            this.tspContent.TopToolStripPanel.PerformLayout();
            this.tspContent.ResumeLayout(false);
            this.tspContent.PerformLayout();
            this.tlsContent.ResumeLayout(false);
            this.tlsContent.PerformLayout();
            this.musContent.ResumeLayout(false);
            this.musContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tspContent;
        private System.Windows.Forms.ToolStrip tlsContent;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.MenuStrip musContent;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}
