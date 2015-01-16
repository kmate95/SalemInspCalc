namespace SalemInspCalc
{
    partial class FormInsp
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.wikiDataSet = new SalemInspCalc.wikiDataSet();
            this.inspirationalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspirationalTableAdapter = new SalemInspCalc.wikiDataSetTableAdapters.inspirationalTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspirationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wikiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspirationalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.usesDataGridViewTextBoxColumn,
            this.inspirationDataGridViewTextBoxColumn,
            this.diffDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.inspirationalBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(555, 265);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowLeave);
            // 
            // wikiDataSet
            // 
            this.wikiDataSet.DataSetName = "wikiDataSet";
            this.wikiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inspirationalBindingSource
            // 
            this.inspirationalBindingSource.DataMember = "inspirational";
            this.inspirationalBindingSource.DataSource = this.wikiDataSet;
            // 
            // inspirationalTableAdapter
            // 
            this.inspirationalTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // usesDataGridViewTextBoxColumn
            // 
            this.usesDataGridViewTextBoxColumn.DataPropertyName = "uses";
            this.usesDataGridViewTextBoxColumn.HeaderText = "Uses";
            this.usesDataGridViewTextBoxColumn.Name = "usesDataGridViewTextBoxColumn";
            // 
            // inspirationDataGridViewTextBoxColumn
            // 
            this.inspirationDataGridViewTextBoxColumn.DataPropertyName = "inspiration";
            this.inspirationDataGridViewTextBoxColumn.HeaderText = "Inspiration";
            this.inspirationDataGridViewTextBoxColumn.Name = "inspirationDataGridViewTextBoxColumn";
            // 
            // diffDataGridViewTextBoxColumn
            // 
            this.diffDataGridViewTextBoxColumn.DataPropertyName = "diff";
            this.diffDataGridViewTextBoxColumn.HeaderText = "Dufficulty";
            this.diffDataGridViewTextBoxColumn.Name = "diffDataGridViewTextBoxColumn";
            // 
            // FormInsp
            // 
            this.ClientSize = new System.Drawing.Size(555, 265);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormInsp";
            this.Load += new System.EventHandler(this.FormInsp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wikiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspirationalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn uses;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspiration;
        private System.Windows.Forms.DataGridViewTextBoxColumn diff;
        private System.Windows.Forms.DataGridView dataGridView2;
        private wikiDataSet wikiDataSet;
        private System.Windows.Forms.BindingSource inspirationalBindingSource;
        private wikiDataSetTableAdapters.inspirationalTableAdapter inspirationalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspirationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diffDataGridViewTextBoxColumn;
    }
}