using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;


namespace SalemInspCalc
{
    public class SalemDatadabase
    {
        public SQLiteConnection conn;
        public SQLiteDataAdapter daInsp;
        public SQLiteDataAdapter daIsnp_val;
        public SQLiteDataAdapter daSkill;
        public SQLiteDataAdapter daProf;
        public SQLiteDataAdapter daSkill_req;
        public SQLiteDataAdapter daProf_req;
        public SQLiteDataAdapter daDiff;
        public DataSet ds;
        public DataTableCollection Tables;

        public SalemDatadabase(string path)
        {
            try
            {
                conn = new SQLiteConnection("Data Source="+path+";Version=3;");
                conn.Open();
                ds = new DataSet();
                init();
                Tables = ds.Tables;

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());

            }
        }

        public void Fill()
        {
            try
            {
            daInsp.Fill(ds.Tables["inspirational"]);
            daProf.Fill(ds.Tables["prof"]);
            daIsnp_val.Fill(ds.Tables["insp_values"]);
            daProf_req.Fill(ds.Tables["prof_req"]);
            daSkill.Fill(ds.Tables["skill"]);
            daSkill_req.Fill(ds.Tables["skill_req"]);
            }
            catch (Exception)
            {
                
                throw new Exception("I fucked up fill()");
            }

        }


        int init()
        {
            try
            {
                initds();
                initInsp_values();
                InitInspta();
                initProf();
                initProf_req();
                initSkill();
                initSkill_req();
                return 1;
            }
            catch (Exception e)
            {
                return 0;
                throw;
            }
        }

        void initds()
        {

            SalemInspCalc.wikiDataSet.insp_valuesDataTable tableinsp_values = new SalemInspCalc.wikiDataSet.insp_valuesDataTable();
            ds.Tables.Add(tableinsp_values);
            SalemInspCalc.wikiDataSet.inspirationalDataTable tableinspirational = new SalemInspCalc.wikiDataSet.inspirationalDataTable();
            ds.Tables.Add(tableinspirational);
            SalemInspCalc.wikiDataSet.profDataTable tableprof = new SalemInspCalc.wikiDataSet.profDataTable();
            ds.Tables.Add(tableprof);
            SalemInspCalc.wikiDataSet.prof_reqDataTable tableprof_req = new SalemInspCalc.wikiDataSet.prof_reqDataTable();
            ds.Tables.Add(tableprof_req);
            SalemInspCalc.wikiDataSet.skillDataTable tableskill = new SalemInspCalc.wikiDataSet.skillDataTable();
            ds.Tables.Add(tableskill);
            SalemInspCalc.wikiDataSet.skill_reqDataTable tableskill_req = new SalemInspCalc.wikiDataSet.skill_reqDataTable();
            ds.Tables.Add(tableskill_req);
            SalemInspCalc.wikiDataSet.difftypesDataTable tablediff = new SalemInspCalc.wikiDataSet.difftypesDataTable();
            ds.Tables.Add(tablediff);



        }

        void initInsp_values(){
            daIsnp_val = new SQLiteDataAdapter("SELECT [id], [insp_id], [prof_id], [value], [part] FROM [insp_values]",conn);
            daIsnp_val.DeleteCommand = new global::System.Data.SQLite.SQLiteCommand(conn);
            daIsnp_val.DeleteCommand.CommandText = "DELETE FROM [main].[sqlite_default_schema].[insp_values] WHERE (([id] = @Original" +
                "_id) AND ([insp_id] = @Original_insp_id) AND ([prof_id] = @Original_prof_id) AND" +
                " ([value] = @Original_value) AND ([part] = @Original_part))";
            daIsnp_val.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            global::System.Data.SQLite.SQLiteParameter param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daIsnp_val.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_insp_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "insp_id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daIsnp_val.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_prof_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "prof_id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daIsnp_val.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_value";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "value";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daIsnp_val.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_part";
            param.DbType = global::System.Data.DbType.Double;
            param.DbType = global::System.Data.DbType.Double;
            param.SourceColumn = "part";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daIsnp_val.DeleteCommand.Parameters.Add(param);
            daIsnp_val.InsertCommand = new global::System.Data.SQLite.SQLiteCommand();
            daIsnp_val.InsertCommand.Connection = conn;
            daIsnp_val.InsertCommand.CommandText = "INSERT INTO [main].[sqlite_default_schema].[insp_values] ([insp_id], [prof_id], [" +
                "value], [part]) VALUES (@insp_id, @prof_id, @value, @part)";
            daIsnp_val.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@insp_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "insp_id";
            daIsnp_val.InsertCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@prof_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "prof_id";
            daIsnp_val.InsertCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@value";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "value";
            daIsnp_val.InsertCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@part";
            param.DbType = global::System.Data.DbType.Double;
            param.DbType = global::System.Data.DbType.Double;
            param.SourceColumn = "part";
            daIsnp_val.InsertCommand.Parameters.Add(param);
            daIsnp_val.UpdateCommand = new global::System.Data.SQLite.SQLiteCommand();
            daIsnp_val.UpdateCommand.Connection = conn;
            daIsnp_val.UpdateCommand.CommandText = @"UPDATE [main].[sqlite_default_schema].[insp_values] SET [insp_id] = @insp_id, [prof_id] = @prof_id, [value] = @value, [part] = @part WHERE (([id] = @Original_id) AND ([insp_id] = @Original_insp_id) AND ([prof_id] = @Original_prof_id) AND ([value] = @Original_value) AND ([part] = @Original_part))";
            daIsnp_val.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@insp_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "insp_id";
            daIsnp_val.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@prof_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "prof_id";
            daIsnp_val.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@value";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "value";
            daIsnp_val.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@part";
            param.DbType = global::System.Data.DbType.Double;
            param.DbType = global::System.Data.DbType.Double;
            param.SourceColumn = "part";
            daIsnp_val.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daIsnp_val.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_insp_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "insp_id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daIsnp_val.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_prof_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "prof_id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daIsnp_val.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_value";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "value";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daIsnp_val.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_part";
            param.DbType = global::System.Data.DbType.Double;
            param.DbType = global::System.Data.DbType.Double;
            param.SourceColumn = "part";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daIsnp_val.UpdateCommand.Parameters.Add(param);
        }

        void InitInspta()
        {
            daInsp = new SQLiteDataAdapter("SELECT [id], [name], [uses], [inspiration], [diff] FROM [inspirational]",conn);
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "inspirational";
            tableMapping.ColumnMappings.Add("id", "id");
            tableMapping.ColumnMappings.Add("name", "name");
            tableMapping.ColumnMappings.Add("uses", "uses");
            tableMapping.ColumnMappings.Add("inspiration", "inspiration");
            tableMapping.ColumnMappings.Add("diff", "diff");
            daInsp.TableMappings.Add(tableMapping);
            daInsp.DeleteCommand = new global::System.Data.SQLite.SQLiteCommand();
            daInsp.DeleteCommand.Connection = conn;
            daInsp.DeleteCommand.CommandText = "DELETE FROM [main].[sqlite_default_schema].[inspirational] WHERE (([id] = @Origin" +
                "al_id) AND ([name] = @Original_name) AND ([uses] = @Original_uses) AND ([inspira" +
                "tion] = @Original_inspiration))";
            daInsp.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            global::System.Data.SQLite.SQLiteParameter param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daInsp.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daInsp.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_uses";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "uses";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daInsp.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_inspiration";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "inspiration";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daInsp.DeleteCommand.Parameters.Add(param);
            daInsp.InsertCommand = new global::System.Data.SQLite.SQLiteCommand();
            daInsp.InsertCommand.Connection = conn;
            daInsp.InsertCommand.CommandText = "INSERT INTO [main].[sqlite_default_schema].[inspirational] ([name], [uses], [insp" +
                "iration],[diff]) VALUES (@name, @uses, @inspiration, @diff)";
            daInsp.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            daInsp.InsertCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@uses";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "uses";
            daInsp.InsertCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@diff";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "diff";
            daInsp.InsertCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@inspiration";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "inspiration";
            daInsp.InsertCommand.Parameters.Add(param);
            daInsp.UpdateCommand = new global::System.Data.SQLite.SQLiteCommand();
            daInsp.UpdateCommand.Connection = conn;
            daInsp.UpdateCommand.CommandText = "UPDATE [main].[sqlite_default_schema].[inspirational] SET [name] = @name, [uses] " +
                "= @uses, [inspiration] = @inspiration, [diff]=@diff WHERE (([id] = @Original_id) AND ([name] =" +
                " @Original_name) AND ([uses] = @Original_uses) AND ([inspiration] = @Original_in" +
                "spiration))";
            daInsp.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            daInsp.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@uses";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "uses";
            daInsp.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@diff";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "diff";
            daInsp.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@inspiration";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "inspiration";
            daInsp.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daInsp.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daInsp.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_uses";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "uses";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daInsp.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_inspiration";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "inspiration";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daInsp.UpdateCommand.Parameters.Add(param);
        }

        void initProf()
        {
            daProf = new SQLiteDataAdapter("SELECT [id], [name], [longname] FROM [prof]",conn);
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "prof";
            tableMapping.ColumnMappings.Add("id", "id");
            tableMapping.ColumnMappings.Add("name", "name");
            tableMapping.ColumnMappings.Add("longname", "longname");
            daProf.TableMappings.Add(tableMapping);
            daProf.DeleteCommand = new global::System.Data.SQLite.SQLiteCommand();
            daProf.DeleteCommand.Connection = conn;
            daProf.DeleteCommand.CommandText = "DELETE FROM [main].[sqlite_default_schema].[prof] WHERE (([id] = @Original_id) AN" +
                "D ([name] = @Original_name) AND ((@IsNull_longname = 1 AND [longname] IS NULL) O" +
                "R ([longname] = @Original_longname)))";
            daProf.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            global::System.Data.SQLite.SQLiteParameter param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@IsNull_longname";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "longname";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            param.SourceColumnNullMapping = true;
            daProf.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_longname";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "longname";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf.DeleteCommand.Parameters.Add(param);
            daProf.InsertCommand = new global::System.Data.SQLite.SQLiteCommand();
            daProf.InsertCommand.Connection = conn;
            daProf.InsertCommand.CommandText = "INSERT INTO [main].[sqlite_default_schema].[prof] ([name], [longname]) VALUES (@n" +
                "ame, @longname)";
            daProf.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            daProf.InsertCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@longname";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "longname";
            daProf.InsertCommand.Parameters.Add(param);
            daProf.UpdateCommand = new global::System.Data.SQLite.SQLiteCommand();
            daProf.UpdateCommand.Connection = conn;
            daProf.UpdateCommand.CommandText = "UPDATE [main].[sqlite_default_schema].[prof] SET [name] = @name, [longname] = @lo" +
                "ngname WHERE (([id] = @Original_id) AND ([name] = @Original_name) AND ((@IsNull_" +
                "longname = 1 AND [longname] IS NULL) OR ([longname] = @Original_longname)))";
            daProf.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            daProf.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@longname";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "longname";
            daProf.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@IsNull_longname";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "longname";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            param.SourceColumnNullMapping = true;
            daProf.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_longname";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "longname";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf.UpdateCommand.Parameters.Add(param);
        }

        void initProf_req()
        {
            daProf_req = new SQLiteDataAdapter("SELECT [id], [skill_id], [prof_id], [number] FROM [prof_req]",conn);
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "prof_req";
            tableMapping.ColumnMappings.Add("id", "id");
            tableMapping.ColumnMappings.Add("skill_id", "skill_id");
            tableMapping.ColumnMappings.Add("prof_id", "prof_id");
            tableMapping.ColumnMappings.Add("number", "number");
            daProf_req.TableMappings.Add(tableMapping);
            daProf_req.DeleteCommand = new global::System.Data.SQLite.SQLiteCommand();
            daProf_req.DeleteCommand.Connection = conn;
            daProf_req.DeleteCommand.CommandText = "DELETE FROM [main].[sqlite_default_schema].[prof_req] WHERE (([id] = @Original_id" +
                ") AND ([skill_id] = @Original_skill_id) AND ([prof_id] = @Original_prof_id) AND " +
                "([number] = @Original_number))";
            daProf_req.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            global::System.Data.SQLite.SQLiteParameter param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf_req.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_skill_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "skill_id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf_req.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_prof_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "prof_id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf_req.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_number";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "number";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf_req.DeleteCommand.Parameters.Add(param);
            daProf_req.InsertCommand = new global::System.Data.SQLite.SQLiteCommand();
            daProf_req.InsertCommand.Connection = conn;
            daProf_req.InsertCommand.CommandText = "INSERT INTO [main].[sqlite_default_schema].[prof_req] ([skill_id], [prof_id], [nu" +
                "mber]) VALUES (@skill_id, @prof_id, @number)";
            daProf_req.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@skill_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "skill_id";
            daProf_req.InsertCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@prof_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "prof_id";
            daProf_req.InsertCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@number";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "number";
            daProf_req.InsertCommand.Parameters.Add(param);
            daProf_req.UpdateCommand = new global::System.Data.SQLite.SQLiteCommand();
            daProf_req.UpdateCommand.Connection = conn;
            daProf_req.UpdateCommand.CommandText = "UPDATE [main].[sqlite_default_schema].[prof_req] SET [skill_id] = @skill_id, [pro" +
                "f_id] = @prof_id, [number] = @number WHERE (([id] = @Original_id) AND ([skill_id" +
                "] = @Original_skill_id) AND ([prof_id] = @Original_prof_id) AND ([number] = @Ori" +
                "ginal_number))";
            daProf_req.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@skill_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "skill_id";
            daProf_req.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@prof_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "prof_id";
            daProf_req.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@number";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "number";
            daProf_req.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf_req.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_skill_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "skill_id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf_req.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_prof_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "prof_id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf_req.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_number";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "number";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daProf_req.UpdateCommand.Parameters.Add(param);
        }

        void initSkill()
        {
            daSkill = new SQLiteDataAdapter("SELECT [id], [name] FROM [skill]",conn);
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "skill";
            tableMapping.ColumnMappings.Add("id", "id");
            tableMapping.ColumnMappings.Add("name", "name");
            daSkill.TableMappings.Add(tableMapping);
            daSkill.DeleteCommand = new global::System.Data.SQLite.SQLiteCommand();
            daSkill.DeleteCommand.Connection = conn;
            daSkill.DeleteCommand.CommandText = "DELETE FROM [main].[sqlite_default_schema].[skill] WHERE (([id] = @Original_id) A" +
                "ND ([name] = @Original_name))";
            daSkill.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            global::System.Data.SQLite.SQLiteParameter param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daSkill.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daSkill.DeleteCommand.Parameters.Add(param);
            daSkill.InsertCommand = new global::System.Data.SQLite.SQLiteCommand();
            daSkill.InsertCommand.Connection = conn;
            daSkill.InsertCommand.CommandText = "INSERT INTO [main].[sqlite_default_schema].[skill] ([name]) VALUES (@name)";
            daSkill.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            daSkill.InsertCommand.Parameters.Add(param);
            daSkill.UpdateCommand = new global::System.Data.SQLite.SQLiteCommand();
            daSkill.UpdateCommand.Connection = conn;
            daSkill.UpdateCommand.CommandText = "UPDATE [main].[sqlite_default_schema].[skill] SET [name] = @name WHERE (([id] = @" +
                "Original_id) AND ([name] = @Original_name))";
            daSkill.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            daSkill.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daSkill.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daSkill.UpdateCommand.Parameters.Add(param);
        }

        void initSkill_req()
        {
            daSkill_req = new global::System.Data.SQLite.SQLiteDataAdapter("SELECT [id], [skill_id], [req_id] FROM [skill_req]",conn);
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "skill_req";
            tableMapping.ColumnMappings.Add("id", "id");
            tableMapping.ColumnMappings.Add("skill_id", "skill_id");
            tableMapping.ColumnMappings.Add("req_id", "req_id");
            daSkill_req.TableMappings.Add(tableMapping);
            daSkill_req.DeleteCommand = new global::System.Data.SQLite.SQLiteCommand();
            daSkill_req.DeleteCommand.Connection = conn;
            daSkill_req.DeleteCommand.CommandText = "DELETE FROM [main].[sqlite_default_schema].[skill_req] WHERE (([id] = @Original_i" +
                "d) AND ([skill_id] = @Original_skill_id) AND ([req_id] = @Original_req_id))";
            daSkill_req.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            global::System.Data.SQLite.SQLiteParameter param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daSkill_req.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_skill_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "skill_id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daSkill_req.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_req_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "req_id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daSkill_req.DeleteCommand.Parameters.Add(param);
            daSkill_req.InsertCommand = new global::System.Data.SQLite.SQLiteCommand();
            daSkill_req.InsertCommand.Connection = conn;
            daSkill_req.InsertCommand.CommandText = "INSERT INTO [main].[sqlite_default_schema].[skill_req] ([skill_id], [req_id]) VAL" +
                "UES (@skill_id, @req_id)";
            daSkill_req.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@skill_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "skill_id";
            daSkill_req.InsertCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@req_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "req_id";
            daSkill_req.InsertCommand.Parameters.Add(param);
            daSkill_req.UpdateCommand = new global::System.Data.SQLite.SQLiteCommand();
            daSkill_req.UpdateCommand.Connection = conn;
            daSkill_req.UpdateCommand.CommandText = "UPDATE [main].[sqlite_default_schema].[skill_req] SET [skill_id] = @skill_id, [re" +
                "q_id] = @req_id WHERE (([id] = @Original_id) AND ([skill_id] = @Original_skill_i" +
                "d) AND ([req_id] = @Original_req_id))";
            daSkill_req.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@skill_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "skill_id";
            daSkill_req.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@req_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "req_id";
            daSkill_req.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daSkill_req.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_skill_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "skill_id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daSkill_req.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_req_id";
            param.DbType = global::System.Data.DbType.Int32;
            param.DbType = global::System.Data.DbType.Int32;
            param.SourceColumn = "req_id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daSkill_req.UpdateCommand.Parameters.Add(param);
        }

        void initDifftypes()
        {
            daDiff = new global::System.Data.SQLite.SQLiteDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "difftypes";
            tableMapping.ColumnMappings.Add("id", "id");
            tableMapping.ColumnMappings.Add("name", "name");
            daDiff.TableMappings.Add(tableMapping);
            daDiff.DeleteCommand = new global::System.Data.SQLite.SQLiteCommand();
            daDiff.DeleteCommand.Connection = conn;
            daDiff.DeleteCommand.CommandText = "DELETE FROM [main].[sqlite_default_schema].[difftypes] WHERE (([id] = @Original_i" +
                "d) AND ([name] = @Original_name))";
            daDiff.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            global::System.Data.SQLite.SQLiteParameter param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int64;
            param.DbType = global::System.Data.DbType.Int64;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daDiff.DeleteCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daDiff.DeleteCommand.Parameters.Add(param);
            daDiff.InsertCommand = new global::System.Data.SQLite.SQLiteCommand();
            daDiff.InsertCommand.Connection = conn;
            daDiff.InsertCommand.CommandText = "INSERT INTO [main].[sqlite_default_schema].[difftypes] ([name]) VALUES (@name)";
            daDiff.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            daDiff.InsertCommand.Parameters.Add(param);
            daDiff.UpdateCommand = new global::System.Data.SQLite.SQLiteCommand();
            daDiff.UpdateCommand.Connection = conn;
            daDiff.UpdateCommand.CommandText = "UPDATE [main].[sqlite_default_schema].[difftypes] SET [name] = @name WHERE (([id]" +
                " = @Original_id) AND ([name] = @Original_name))";
            daDiff.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            daDiff.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_id";
            param.DbType = global::System.Data.DbType.Int64;
            param.DbType = global::System.Data.DbType.Int64;
            param.SourceColumn = "id";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daDiff.UpdateCommand.Parameters.Add(param);
            param = new global::System.Data.SQLite.SQLiteParameter();
            param.ParameterName = "@Original_name";
            param.DbType = global::System.Data.DbType.String;
            param.SourceColumn = "name";
            param.SourceVersion = global::System.Data.DataRowVersion.Original;
            daDiff.UpdateCommand.Parameters.Add(param);
        }

    }
}
