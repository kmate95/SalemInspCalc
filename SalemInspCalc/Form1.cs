
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalemInspCalc
{
   
    public partial class FormMain : Form
    {
        public FormInsp FrmInsp;
        public FormImportInsp FrmImportInsp;
        public FormProf FrmProf;
        public FormDiffs FrmDiff;
        public wikiDataSet ds;
        public SalemDatadabase db;
        public int ProfCount = 15; 
        public Dictionary<string, int> ProfList;
        public List<Tinsp> Allinsp;
        public string[] difftypes;

        public FormMain()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wikiDataSet1.inspirational' table. You can move, or remove it, as needed.
            
            db=new SalemDatadabase("E:\\_Projects\\salem\\wiki");
            CheckConnection();
            
            
            db.Fill();
            ProfList = new Dictionary<string, int>();
            foreach (SalemInspCalc.wikiDataSet.profRow row in db.Tables["prof"].Rows)
            {
                //int a = Convert.ToInt32( row[0].ToString());
                int a = row.id;
                ProfList.Add(row["name"].ToString(), a);
            }
            InitForms();
        }

        private void InitForms()
        {
            
            
            
            FrmDiff = new FormDiffs(this);

        }

        private void importInspFromJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmImportInsp = new FormImportInsp(this);
            FrmImportInsp.ShowDialog();
            FrmImportInsp.owner = this;
            
        }

        public void RefreshDifftypes()
        {
            
            difftypes = new string[db.Tables["difftypes"].Rows.Count];
            foreach (wikiDataSet.difftypesRow row in db.Tables["difftypes"].Rows)
            {
                difftypes[row.id] = row.name;
            }
        }



        private void viewInspToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmInsp = new FormInsp(this);
            FrmInsp.Show();
        }

        private void viewProfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProf = new FormProf(this);
            FrmProf.Show();
        }

        public bool CheckConnection()
        {
            if (db.conn.State != ConnectionState.Open)
            {
                try
                {
                    db.conn.Open();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                    throw;

                }
            }
            return true;
        }
    }
}
