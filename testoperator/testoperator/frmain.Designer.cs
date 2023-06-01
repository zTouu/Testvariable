namespace testoperator
{
    partial class frmain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operatorToolStripMenuItem
            // 
            this.operatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comparisionToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.operatorToolStripMenuItem.Name = "operatorToolStripMenuItem";
            this.operatorToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operatorToolStripMenuItem.Text = "Operator";
            // 
            // comparisionToolStripMenuItem
            // 
            this.comparisionToolStripMenuItem.Name = "comparisionToolStripMenuItem";
            this.comparisionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.comparisionToolStripMenuItem.Text = "Assignment Operators";
            this.comparisionToolStripMenuItem.Click += new System.EventHandler(this.comparisionToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.studentToolStripMenuItem.Text = "Comparision Operator";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // frmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
    }
}