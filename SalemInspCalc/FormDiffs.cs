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
    public partial class FormDiffs : Form
    {
        public FormMain owner;
        public FormDiffs(FormMain main)
        {
            InitializeComponent();
            owner = main;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDiffs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = owner.db.Tables["difftype"];
        }

        private void FormDiffs_FormClosed(object sender, FormClosedEventArgs e)
        {
            owner.db.daDiff.Update(owner.db.ds);
            owner.db.Fill();
            owner.RefreshDifftypes();
        }
    }
}
