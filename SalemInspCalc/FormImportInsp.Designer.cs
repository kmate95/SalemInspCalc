namespace SalemInspCalc
{
    partial class FormImportInsp
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
            this.sqliteSelectCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.sqliteInsertCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.sqliteUpdateCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.sqliteDeleteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.wikiDataSet1 = new SalemInspCalc.wikiDataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.insp_valuesTableAdapter1 = new SalemInspCalc.wikiDataSetTableAdapters.insp_valuesTableAdapter();
            this.inspirationalTableAdapter1 = new SalemInspCalc.wikiDataSetTableAdapters.inspirationalTableAdapter();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.wikiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqliteSelectCommand1
            // 
            this.sqliteSelectCommand1.CommandText = null;
            // 
            // sqliteInsertCommand1
            // 
            this.sqliteInsertCommand1.CommandText = null;
            // 
            // sqliteUpdateCommand1
            // 
            this.sqliteUpdateCommand1.CommandText = null;
            // 
            // sqliteDeleteCommand1
            // 
            this.sqliteDeleteCommand1.CommandText = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(147, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Overwrite existing";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // wikiDataSet1
            // 
            this.wikiDataSet1.DataSetName = "wikiDataSet";
            this.wikiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Select file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Not selected";
            // 
            // insp_valuesTableAdapter1
            // 
            this.insp_valuesTableAdapter1.ClearBeforeFill = true;
            // 
            // inspirationalTableAdapter1
            // 
            this.inspirationalTableAdapter1.ClearBeforeFill = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(12, 137);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(268, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // FormImportInsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormImportInsp";
            this.Text = "FormImportInsp";
            ((System.ComponentModel.ISupportInitialize)(this.wikiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SQLite.SQLiteCommand sqliteSelectCommand1;
        private System.Data.SQLite.SQLiteCommand sqliteInsertCommand1;
        private System.Data.SQLite.SQLiteCommand sqliteUpdateCommand1;
        private System.Data.SQLite.SQLiteCommand sqliteDeleteCommand1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private wikiDataSet wikiDataSet1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private wikiDataSetTableAdapters.insp_valuesTableAdapter insp_valuesTableAdapter1;
        private wikiDataSetTableAdapters.inspirationalTableAdapter inspirationalTableAdapter1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}