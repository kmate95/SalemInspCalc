namespace SalemInspCalc
{
    partial class FormMain
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importInspFromJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInspToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importInspFromJSONToolStripMenuItem,
            this.viewInspToolStripMenuItem,
            this.viewProfToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // importInspFromJSONToolStripMenuItem
            // 
            this.importInspFromJSONToolStripMenuItem.Name = "importInspFromJSONToolStripMenuItem";
            this.importInspFromJSONToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.importInspFromJSONToolStripMenuItem.Text = "Import insp from JSON";
            this.importInspFromJSONToolStripMenuItem.Click += new System.EventHandler(this.importInspFromJSONToolStripMenuItem_Click);
            // 
            // viewInspToolStripMenuItem
            // 
            this.viewInspToolStripMenuItem.Name = "viewInspToolStripMenuItem";
            this.viewInspToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.viewInspToolStripMenuItem.Text = "View insp";
            this.viewInspToolStripMenuItem.Click += new System.EventHandler(this.viewInspToolStripMenuItem_Click);
            // 
            // viewProfToolStripMenuItem
            // 
            this.viewProfToolStripMenuItem.Name = "viewProfToolStripMenuItem";
            this.viewProfToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.viewProfToolStripMenuItem.Text = "View Prof";
            this.viewProfToolStripMenuItem.Click += new System.EventHandler(this.viewProfToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 350);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private wikiDataSet wikiDataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importInspFromJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInspToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfToolStripMenuItem;
    }
}

