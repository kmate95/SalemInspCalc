using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalemInspCalc
{
    public partial class FormInsp : Form
    {
        FormMain owner;
        BindingSource binds;
        public FormInsp(FormMain main)
        {
            owner = main;
            InitializeComponent();
        }

        private void FormInsp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wikiDataSet.inspirational' table. You can move, or remove it, as needed.
            binds = new BindingSource();
            binds.DataSource = owner.db.Tables["inspirational"];
            dataGridView2.DataSource = binds;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormInsp_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wikiDataSet.inspirational' table. You can move, or remove it, as needed.
            this.inspirationalTableAdapter.Fill(this.wikiDataSet.inspirational);

        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // owner.db.Tables["inspirational"].AcceptChanges();

        }

        private void dataGridView2_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //owner.db.Tables["inspirational"] 
            owner.db.daInsp.Update(owner.db.Tables["inspirational"] );
            //owner.db.Fill();
        }




    }
}
