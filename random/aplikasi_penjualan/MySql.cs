using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace aplikasi_penjualan
{
    class MySql
    {
        private MySqlConnection Conn;
        private string _cString;
        
        public string cString
        {
            get { return _cString; }
            set { _cString = value; }
        }

        public MySql(string c_String)
        {
            this._cString = c_String;
            this.Conn = new MySqlConnection(_cString);
        }

        public void Open()
        {
            Conn.Open();
        }

        public void Close()
        {
            Conn.Close();
        }

        private int doQuery(string query)
        {
            int hsl = 0;
            this.Open();
            using (var cmd = new MySqlCommand(query, this.Conn))
            {
                hsl = cmd.ExecuteNonQuery();
            }
            this.Close();
            return hsl;
        }

        public int Insert(string query)
        {
            return doQuery(query);
        }

        public int InserImg(string query, string imgPath)
        {
            int hsl = 0;
            this.Open();
            using (var cmd = new MySqlCommand(query, this.Conn))
            {
                cmd.Parameters.AddWithValue("@img", File.ReadAllBytes(imgPath));
                hsl = cmd.ExecuteNonQuery();
            }
            this.Close();
            return hsl;
        }

        public int Update(string query)
        {
            return doQuery(query);
        }

        public int Delete(string query)
        {
            return doQuery(query);
        }

        public string SelectCell(string query)
        {
            this.Open();
            string hsl = null;
            using (var cmd = new MySqlCommand(query, this.Conn))
            {
                hsl = (string)cmd.ExecuteScalar();
            }
            this.Close();
            return hsl;
        }

        public List<string>[] Select(string query)
        {
            List<string>[] hsl = new List<string>[0];
            MySqlDataReader reader;
            this.Open();
            using (var cmd = new MySqlCommand(query, this.Conn))
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    List<string> temp = new List<string>();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            temp.Add(reader.GetString(i));
                        }
                        Array.Resize(ref hsl, hsl.Length + 1);
                        hsl[hsl.GetUpperBound(0)] = temp;
                    }
                }
            }
            this.Close();
            return hsl;
        }

        public byte[] SelectImg(string query)
        {
            byte[] hsl = null;
            this.Conn.Open();
            using (var cmd = new MySqlCommand(query, this.Conn))
            {
                hsl = (byte[])cmd.ExecuteScalar();   
            }
            this.Conn.Close();
            return hsl;
        }
    }
}
