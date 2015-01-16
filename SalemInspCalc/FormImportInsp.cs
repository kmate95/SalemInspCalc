using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalemInspCalc
{
    public partial class FormImportInsp : Form
    {
        public List<string> list;
        public FormMain owner;

        public FormImportInsp(FormMain main)
        {
            InitializeComponent();
            owner = main;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        list = new List<string>();
                        string str;
                        while (!sr.EndOfStream)
                        {

                            str = "";
                            String line = sr.ReadLine();
                            while (!line.Contains("{") && !sr.EndOfStream)
                            {
                                line = sr.ReadLine();

                            }
                            str += "\n" + line.Trim();
                            while (!line.Contains("}") && !sr.EndOfStream)
                            {
                                line = sr.ReadLine();
                                str += "\n" + line.Trim();
                            }
                            list.Add(str.Trim(','));

                        }
                        sr.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                if (list.Count > 0)
                {
                    label1.ForeColor = Color.Green;
                    label1.Text = "File loaded, row count: " + list.Count;
                    progressBar1.Maximum = list.Count;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TinspImporter insp = new TinspImporter();
            if (owner.db.conn == null)
                return;
            owner.CheckConnection();
            if (checkBox1.Checked)
            {
                System.Data.SQLite.SQLiteCommand com = owner.db.conn.CreateCommand();
                com.CommandText = "Delete FROM inspirational WHERE 1=1";
                com.ExecuteNonQuery();
                com.CommandText = "Delete FROM insp_values WHERE 1=1";
                com.ExecuteNonQuery();
            }

            progressBar1.Value = 0;
            progressBar1.Visible = true;
            Tinsp a;
            foreach (string json in list)
            {
                a = new Tinsp(owner);
                insp = insp.ConvertJsonInsp(json, owner);
                a.FromImport(insp);
                a.ToDb();
                //insp.UploadInsp(wikiDataSet1.inspirational);
                //inspirationalTableAdapter1.Update(wikiDataSet1.inspirational);
                
                progressBar1.Increment(1);
            }
            progressBar1.Value = 0;
        }

       

        
    }
}
