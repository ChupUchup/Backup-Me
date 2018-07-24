using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;

namespace SQLibrary
{
    public class SQLite
    {
        #region variables
        //
        private enum Qtype { nonQuery, Scalar, Reader, Adapter };
        private SQLiteConnection _conn;
        private string _connString;
        public string ConnString { get { return _connString; } set { _connString = value; } }
        public string[] Table { get { return tblList(); } }
        
        //
        #endregion variables

        #region constructor
        //
        public SQLite() { }
        public SQLite(string connString) { _connString = connString; }
        //
        #endregion constructor

        #region method
        //
        private bool isConnect()
        {
            bool hsl = false;
            if (_connString != null)
            {
                _conn = new SQLiteConnection(_connString);
                try { _conn.Open(); hsl = true; }
                catch (SQLiteException ex) { hsl = false; throw new Exception(string.Concat("Error Code ", ex.ErrorCode, " : ", ex.Message)); }
                finally { _conn.Close(); }
            }
            return hsl;
        }
        private object doQuery(Qtype q, string query, string tblName = null)
        {
            object hsl = null;
            if (isConnect())
            {
                _conn.Open();
                if (q == Qtype.Adapter)
                {
                    using (var da = new SQLiteDataAdapter(query, _conn))
                    {
                        var ds = new DataSet();
                        if (tblName != null) da.Fill(ds, tblName);
                        else da.Fill(ds);
                        hsl = ds;
                    }
                }
                else
                {
                    using (var cmd = new SQLiteCommand(query, _conn))
                    {
                        if (q == Qtype.nonQuery) hsl = cmd.ExecuteNonQuery();
                        else if (q == Qtype.Scalar) hsl = cmd.ExecuteScalar();
                        //else if (q == Qtype.Reader)
                        //{
                        //    var reader = new SQLiteDataReader();
                        //    reader = cmd.ExecuteReader();
                        //    if (reader.HasRows)
                        //    {
                        //        List<object>[] tbl = new List<object>[reader.Depth];
                        //        while (reader.Read())
                        //        {
                        //            for (int i = 0; i < reader.Depth; i++)
                        //            {
                        //                List<object> row = new List<object>();
                        //                for (int j = 0; j < reader.FieldCount; j++)
                        //                {
                        //                    row.Add(reader.GetValue(j));
                        //                }
                        //                tbl[i] = row;
                        //            }
                        //        }
                        //        hsl = tbl;
                        //    }
                        //    reader.Close();
                        //}
                    }
                }
                _conn.Close();
            }
            return hsl;
        }
        public string[] tblList()
        {
            string[] hsl = new string[0];
            string query = "SELECT name FROM sqlite_master WHERE type = 'table' ORDER BY 1;";
            DataSet ds = (DataSet)doQuery(Qtype.Adapter, query);
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                for (int j = 0; j < ds.Tables[i].Rows.Count; j++)
                {
                    for (int k = 0; k < ds.Tables[i].Columns.Count; k++)
                    {
                        Array.Resize(ref hsl, hsl.Length + 1);
                        hsl[hsl.GetUpperBound(0)] = ds.Tables[i].Rows[j].ItemArray[k].ToString();
                    }
                }
            }
            return hsl;
        }
        public int Insert(string query) { return (int)doQuery(Qtype.nonQuery, query); }
        public int Update(string query) { return (int)doQuery(Qtype.nonQuery, query); }
        public int Delete(string query) { return (int)doQuery(Qtype.nonQuery, query); }
        public object SelectCell(string query) { return (object)doQuery(Qtype.Scalar, query); }
        public DataSet Select(string query) { return (DataSet)doQuery(Qtype.Adapter, query); }
        public DataSet Select(string query, string tblName) { return (DataSet)doQuery(Qtype.Adapter, query, tblName); }
        public void CreateDatabase(string dbName) { SQLiteConnection.CreateFile(dbName); }
        public void CreateTable(string tblName) { doQuery(Qtype.nonQuery, tblName); }
        //
        #endregion method
    }
}
