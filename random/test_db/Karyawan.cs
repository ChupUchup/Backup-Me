using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.IO;

namespace test_db
{
    class Karyawan
    {
        #region variables
        private string _nik;
        private string _nama;
        private string _password;
        private string _jabatan;
        private string _alamat;
        private string _memo;
        private string _fotopath;
        private Bitmap _foto;
        private DataSet _table;
        private string _cString;
        private string _defaultFoto;

        public string nik { get { return _nik; } set { _nik = value; } }
        public string nama { get { return _nama; } set { _nama = value; } }
        public string password { get { return _password; } set { _password = value; } }
        public string jabatan { get { return _jabatan; } set { _jabatan = value; } }
        public string alamat { get { return _alamat; } set { _alamat = value; } }
        public string memo { get { return _memo; } set { _memo = value; } }
        public Bitmap foto { get { return _foto; } set { _foto = value; } }
        public DataSet table { get { return _table; } }
        #endregion variables

        #region method
        public Karyawan() { Initialize(); }
        public Karyawan(string Nik) { Initialize(); _nik = Nik; }
        public Karyawan(string Nik, string Nama, string Password, string Jabatan, string Alamat = null, string Memo = null, string Foto = null)
        {
            Initialize();
            _nik = Nik;
            _nama = Nama;
            _password = Password;
            _jabatan = Jabatan;
            if (Alamat == null) _alamat = "-";
            else _alamat = Alamat;
            if (Memo == null) _memo = "-";
            else _memo = Memo;
            if (Foto == null) { _foto = new Bitmap(_defaultFoto); _fotopath = _defaultFoto; }
            else { _foto = new Bitmap(Foto); _fotopath = Foto; }
        }
        public int Insert()
        {
            int hsl = 0;
            if (_nik != null && _nama != null && _password != null && _jabatan != null)
            {
                string q = "INSERT INTO tbl_karyawan VALUES (@nik,@nama,@pass,@jabatan,@alamat,@memo,@foto);";
                using (var conn = new MySqlConnection(_cString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@nik", _nik);
                        cmd.Parameters.AddWithValue("@nama", _nama);
                        cmd.Parameters.AddWithValue("@pass", _password);
                        cmd.Parameters.AddWithValue("@jabatan", _jabatan);
                        cmd.Parameters.AddWithValue("@alamat", _alamat);
                        cmd.Parameters.AddWithValue("@memo", _memo);
                        cmd.Parameters.AddWithValue("@foto", File.ReadAllBytes(_fotopath));
                        hsl = cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            return hsl;
        }
        public int Update()
        {
            int hsl = 0;
            if (_nik != null && _nama != null && _password != null && _jabatan != null)
            {
                string q = "UPDATE tbl_karyawan SET nik_karyawan=@nik,nama_karyawan=@nama,pass=@pass,jabatan=@jabatan,alamat=@alamat,memo=@memo,foto=@foto WHERE nik_karyawan=@nik;";
                using (var conn = new MySqlConnection(_cString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@nik", _nik);
                        cmd.Parameters.AddWithValue("@nama", _nama);
                        cmd.Parameters.AddWithValue("@pass", _password);
                        cmd.Parameters.AddWithValue("@jabatan", _jabatan);
                        cmd.Parameters.AddWithValue("@alamat", _alamat);
                        cmd.Parameters.AddWithValue("@memo", _memo);
                        cmd.Parameters.AddWithValue("@foto", File.ReadAllBytes(_fotopath));
                        hsl = cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            return hsl;
        }
        public int Delete()
        {
            int hsl = 0;
            if (_nik != null)
            {
                string q = "DELETE FROM tbl_karyawan WHERE nik_karyawan=@nik;";
                using (var conn = new MySqlConnection(_cString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@nik", _nik);
                        hsl = cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            return hsl;
        }
        public void Select()
        {
            if (_nik != null)
            {
                string q = "SELECT * FROM tbl_karyawan WHERE nik_karyawan=@nik;";
                using (var conn = new MySqlConnection(_cString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@nik", _nik);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                _nama = reader.GetString("nama_karyawan");
                                _password = reader.GetString("pass");
                                _jabatan = reader.GetString("jabatan");
                                _alamat = reader.GetString("alamat");
                                _memo = reader.GetString("memo");
                                byte[] f = (byte[])reader.GetValue(6);
                                if (f != null) using (var ms = new MemoryStream(f)) { _foto = new Bitmap(ms); }
                                else _foto = new Bitmap(_defaultFoto);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            else
            {
                string q = "SELECT * FROM tbl_karyawan;";
                using (var conn = new MySqlConnection(_cString))
                {
                    conn.Open();
                    using (var da = new MySqlDataAdapter(q, conn))
                    {
                        _table = new DataSet();
                        da.Fill(_table, "tbl_karyawan");
                        for (int i = 0; i < _table.Tables["tbl_karyawan"].Rows.Count; i++)
                        {
                            if (_table.Tables["tbl_karyawan"].Rows[i].ItemArray[6] == null)
                                _table.Tables["tbl_karyawan"].Rows[i].ItemArray[6] = File.ReadAllBytes(_defaultFoto);
                        }
                    }
                    conn.Close();
                }
            }
        }
        private void Initialize()
        {
            string file_1 = "config.cfg", file_2 = "default_foto.png";
            using (var fs = new FileStream(file_1, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    _cString = sr.ReadLine();
                }
            }
            var f = new FileInfo(file_2);
            if (f.Exists) _defaultFoto = file_2;
            else throw new Exception(file_2 + " tidak ditemukan pada direktori \n");
            var conn = new MySqlConnection(_cString);
            try { conn.Open(); }
            catch { throw; }
            finally { conn.Close(); }
        }
        #endregion method
    }
}
