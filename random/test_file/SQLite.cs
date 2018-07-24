using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace test_lite
{
    class SQLite
    {
        #region variables

        private string _cString;
        private SQLiteConnection _conn;
        public string cString
        {
            get { return _cString; }
            set { _cString = value; }
        }
        
        #endregion variables

        #region method

        public SQLite() { }
        public SQLite(string connString)
        {
            _cString = connString;
            isConnect();
        }
        public void createDb(string dbName)
        {
            if (!File.Exists(dbName)) SQLiteConnection.CreateFile(dbName);
            else throw new Exception(dbName + " sudah ada pada direktori");
        }
        public void createTable(string query) { nonQuery(query); }
        public int insert(string query) { return nonQuery(query); }
        public int update(string query) { return nonQuery(query); }
        public int delete(string query) { return nonQuery(query); }
        public DataSet selectAll(string query)
        {
            DataSet hsl = new DataSet();
            if (isConnect())
            {
                using (var da = new SQLiteDataAdapter(query, _conn))
                {
                    _conn.Open();
                    da.Fill(hsl);
                    _conn.Close();
                }
            }
            return hsl;
        }
        public List<object> select(string query)
        {
            List<object> hsl = new List<object>();
            if (isConnect())
            {
                using (var cmd = new SQLiteCommand(query, _conn))
                {
                    _conn.Open();
                    SQLiteDataReader reader;
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.StepCount; i++)
                            {
                                hsl.Add(reader.GetValue(i));
                            }
                        }
                    }
                    reader.Close();
                    reader.Dispose();
                    _conn.Close();
                }
            }
            return hsl;
        }
        public object selectCell(string query)
        {
            object hsl = null;
            if (isConnect())
            {
                using (var cmd = new SQLiteCommand(query, _conn))
                {
                    _conn.Open();
                    hsl = cmd.ExecuteScalar();
                    _conn.Close();
                }
            }
            return hsl;
        }
        private int nonQuery(string query)
        {
            int hsl = 0;
            if (isConnect())
            {
                using (var cmd = new SQLiteCommand(query, _conn))
                {
                    _conn.Open();
                    hsl = cmd.ExecuteNonQuery();
                    _conn.Close();
                }
            }
            return hsl;
        }
        private bool isConnect()
        {
            bool hsl = false;
            _conn = new SQLiteConnection(_cString);
            try { _conn.Open(); hsl = true; }
            catch { hsl = false; throw; }
            finally { _conn.Close(); }
            return hsl;
        }
        public bool isExist(string query, string key)
        {
            bool hsl = false;
            if (isConnect())
            {
                if (key == (string)selectCell(query)) hsl = true;
            }
            return hsl;
        }
        public List<string> tblList(string dbName)
        {
            List<string> hsl = new List<string>();
            using (var conn = new SQLiteConnection("Data Source=" + dbName))
            {
                try
                {
                    conn.Open();
                    string q = "SELECT name FROM sqlite_master WHERE type = 'table' ORDER BY 1;";
                    using (var da = new SQLiteDataAdapter(q, conn))
                    {
                        var ds = new DataSet();
                        da.Fill(ds);
                        //Console.WriteLine(ds.Tables.Count);
                        for (int i = 0; i < ds.Tables.Count; i++)
                        {
                            for (int j = 0; j < ds.Tables[i].Rows.Count; j++)
                            {
                                for (int k = 0; k < ds.Tables[i].Columns.Count; k++)
                                {
                                    Console.Write(ds.Tables[i].Rows[j].ItemArray[k]);
                                    hsl.Add(ds.Tables[i].Rows[j].ItemArray[k].ToString());
                                }
                                //Console.WriteLine();
                            }
                        }
                    }
                }
                catch { throw; }
                finally { conn.Close(); }
            }
            return hsl;
        }

        #endregion method
    }
}
