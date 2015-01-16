using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemInspCalc
{
    public class TinspImporter
    {
        public string name;
        public int id;
        public int diff =0;
        public int uses;
        public int insp;
        public int arts;
        public int cloak;
        public int faith;
        public int flora;
        public int hammer;
        public int herbs;
        public int hunting;
        public int law;
        public int mines;
        public int sparks;
        public int stocks;
        public int sugar;
        public int thread;
        public int natural;
        public int perennial;
        public IList<string> req;
        FormMain parent;

        public TinspImporter ConvertJsonInsp(string json, FormMain owner)
        {
            json = json.Trim();
            json = json.Trim(',');
            TinspImporter newinsp = JsonConvert.DeserializeObject<TinspImporter>(json);
            newinsp.parent = owner;
            return newinsp;
        }

        public int UploadInsp(TinspImporter data, DataTable insptable, DataTable valuetable)
        {
            int id = -1;


            DataRow row = insptable.NewRow();
            row["name"] = data.name;
            row["inspiration"] = data.insp;
            row["uses"] = data.uses;

            insptable.Rows.Add(row);
            insptable.DataSet.AcceptChanges();

            DataRow[] res = insptable.Select("name='" + name + "'");
            id = res[0].Field<int>("id");

            row = valuetable.NewRow();
            row["arts"] = data.arts;
            row["cloak"] = data.cloak;
            row["faith"] = data.faith;
            row["flora"] = data.flora;
            row["hammer"] = data.hammer;
            row["herbs"] = data.herbs;
            row["hunting"] = data.hunting;
            row["law"] = data.law;
            row["mines"] = data.mines;
            row["sparks"] = data.sparks;
            row["stocks"] = data.stocks;
            row["sugar"] = data.sugar;
            row["thread"] = data.thread;
            row["natural"] = data.natural;
            row["perennial"] = data.perennial;

            valuetable.Rows.Add(row);
            valuetable.DataSet.AcceptChanges();

            return id;
        }

        public int UploadInsp(DataTable insptable)
        {
            int id = -1;
            

            DataRow row = insptable.NewRow();
            row["name"] = name;
            row["inspiration"] = insp;
            row["uses"] = uses;

            insptable.Rows.Add(row);
            insptable.AcceptChanges();
            insptable.DataSet.AcceptChanges();
            return 1;
         }
        public int UploadInspValue(int id, DataTable valuetable)
        {

            DataRow row; 
            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["arts"];
            row["insp_id"] = id;
            row["value"] = arts;
            valuetable.Rows.Add(row);

            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["cloak"];
            row["insp_id"] = id;
            row["value"] = cloak;
            valuetable.Rows.Add(row);

            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["faith"];
            row["insp_id"] = id;
            row["value"] = faith;
            valuetable.Rows.Add(row);

            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["flora"];
            row["insp_id"] = id;
            row["value"] = flora;
            valuetable.Rows.Add(row);

            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["hammer"];
            row["insp_id"] = id;
            row["value"] = hammer;
            valuetable.Rows.Add(row);

             row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["herbs"];
            row["insp_id"] = id;
            row["value"] = herbs;
            valuetable.Rows.Add(row);

            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["hunting"];
            row["insp_id"] = id;
            row["value"] = hunting;
            valuetable.Rows.Add(row);

            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["law"];
            row["insp_id"] = id;
            row["value"] = law;
            valuetable.Rows.Add(row);

             row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["mines"];
            row["insp_id"] = id;
            row["value"] = mines;
            valuetable.Rows.Add(row);

            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["sparks"];
            row["insp_id"] = id;
            row["value"] = sparks;
            valuetable.Rows.Add(row);

            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["stocks"];
            row["insp_id"] = id;
            row["value"] = stocks;
            valuetable.Rows.Add(row);

            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["spice"];
            row["insp_id"] = id;
            row["value"] = sugar;
            valuetable.Rows.Add(row);

            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["thread"];
            row["insp_id"] = id;
            row["value"] = thread;
            valuetable.Rows.Add(row);

            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["natural"];
            row["insp_id"] = id;
            row["value"] = natural;
            valuetable.Rows.Add(row);

            row = valuetable.NewRow();
            row["prof_id"] = parent.ProfList["perennial"];
            row["insp_id"] = id;
            row["value"] = perennial;
            valuetable.Rows.Add(row);

            
            valuetable.DataSet.AcceptChanges();

            return id;
        }
    }

    public class Tinsp
    {
        public int[] profs;
        public double[] profratio;
        public FormMain owner;
        public int uses;
        public int insp;
        public string name;
        public int id =  -1;
        public int diff;



        public void FromImport (TinspImporter from)
        {
            profs[owner.ProfList["arts"]] = from.arts;
            profs[owner.ProfList["cloak"]] = from.cloak;
            profs[owner.ProfList["faith"]] = from.faith;
            profs[owner.ProfList["flora"]] = from.flora;
            profs[owner.ProfList["hammer"]] = from.hammer;
            profs[owner.ProfList["herbs"]] = from.herbs;
            profs[owner.ProfList["hunting"]] = from.hunting;
            profs[owner.ProfList["law"]] = from.law;
            profs[owner.ProfList["mines"]] = from.mines;
            profs[owner.ProfList["natural"]] = from.natural;
            profs[owner.ProfList["perennial"]] = from.perennial;
            profs[owner.ProfList["sparks"]] = from.sparks;
            profs[owner.ProfList["sugar"]] = from.sugar;
            profs[owner.ProfList["stocks"]] = from.stocks;
            profs[owner.ProfList["thread"]] = from.thread;
            name = from.name;
            id = from.id;
            uses = from.uses;
            insp = from.insp;
            diff = from.diff;

        }

        public Tinsp( FormMain main)
        {
            owner = main;
            profs = new int[main.ProfCount];
            profratio = new double[main.ProfCount];
            uses = 0;
            insp = 0;
            diff = 0;
         
        }

        public void FromDb(int Iid)
        {
            id = Iid;
            //SalemInspCalc.wikiDataSet.inspirationalRow[] 
           DataRow[] rows = owner.db.Tables["inspirational"].Select("id="+Iid);
           //SalemInspCalc.wikiDataSet.inspirationalRow row = (SalemInspCalc.wikiDataSet.inspirationalRow)rows[0];
           foreach (SalemInspCalc.wikiDataSet.inspirationalRow row in rows)
           {
                uses = row.uses;
                name = row.name;
                insp = row.inspiration;
                diff = row.diff;

           }
           
           rows = owner.db.Tables["insp_val"].Select("insp_id=" + Iid);
           //SalemInspCalc.wikiDataSet.insp_valuesRow vaalrow = (SalemInspCalc.wikiDataSet.insp_valuesRow)rows[0];
           foreach (SalemInspCalc.wikiDataSet.insp_valuesRow row in rows)
           {
               profs[row.prof_id] = row.value;
               profratio[row.prof_id] = (double)insp / row.value;
           }

        }

        public void FromRow(DataRow prow)
        {
            SalemInspCalc.wikiDataSet.inspirationalRow row = (SalemInspCalc.wikiDataSet.inspirationalRow)prow;
            id = row.id;
            uses = row.uses;
            name = row.name;
            insp = row.inspiration;
            diff = row.diff;

            DataRow[] rows = owner.db.Tables["insp_val"].Select("insp_id=" + id);
            //SalemInspCalc.wikiDataSet.insp_valuesRow vaalrow = (SalemInspCalc.wikiDataSet.insp_valuesRow)rows[0];
            foreach (SalemInspCalc.wikiDataSet.insp_valuesRow valrow in rows)
            {
                profs[valrow.prof_id] = valrow.value;
                profratio[valrow.prof_id] = (double)insp / valrow.value;
            }
        }

        public void ToDb()
        {
            if (id < 1)
            {
                DataRow row = owner.db.Tables["inspirational"].NewRow();
                SalemInspCalc.wikiDataSet.inspirationalRow newrow = (SalemInspCalc.wikiDataSet.inspirationalRow)row;
                newrow.inspiration = insp;
                newrow.name = name;
                newrow.uses = uses;
                newrow.diff = diff;
                
                owner.db.Tables["inspirational"].Rows.Add(newrow);
                newrow.EndEdit();
                owner.db.daInsp.Update(owner.db.ds);
                owner.db.Fill();
                id = newrow.id; 
            }
            DataRow[] rows = owner.db.Tables["insp_values"].Select("insp_id=" + id);
            foreach (DataRow item in rows)
            {
                item.Delete();
            }
            for (int i = 0; i < owner.ProfCount; i++)
            {
                DataRow newrow = owner.db.Tables["insp_values"].NewRow();
                SalemInspCalc.wikiDataSet.insp_valuesRow row = (SalemInspCalc.wikiDataSet.insp_valuesRow)newrow;
                row.insp_id = id;
                row.prof_id = i;
                row.value = profs[i];
                row.part = profratio[i];
                owner.db.Tables["insp_values"].Rows.Add(row);
            }
            owner.db.daInsp.Update(owner.db.ds);
            owner.db.Fill();
        }
    }
}
