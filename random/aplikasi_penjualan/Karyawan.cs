using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Data;

namespace aplikasi_penjualan
{
    class Karyawan
    {
        #region properties

        private string _nik;
        private string _nama;
        private string _password;
        private string _jabatan;
        private string _alamat;
        private string _memo;
        private string _fotopath;
        private Bitmap _foto;
        private int _level;
        
        private string _defimg;
        private string _cString;
        private string[] _config;
        private string[] _struktur;
        private bool _isKaryawan;
        private List<object> _record_karyawan;
        private DataSet _tbl_karyawan;
        
        public string nik
        {
            get { return _nik; }
            set { _nik = value; }
        }

        public string nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string jabatan
        {
            get { return _jabatan; }
            set { _jabatan = value; }
        }

        public string alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }

        public string memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        public string fotoPath
        {
            get { return _fotopath; }
            set { _fotopath = value; }
        }

        public Bitmap foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        public int level
        {
            get { return _level; }
        }

        public string[] struktur
        {
            get { return _struktur; }
        }

        public bool isKaryawan
        {
            get { return _isKaryawan; }
        }

        public DataSet tbl_karyawan
        {
            get { return _tbl_karyawan; }
        }

        #endregion properties

        #region method

        public Karyawan()
        {
            get_config();
            testConn();
        }

        public Karyawan(string Nik)
        {
            try
            {
                get_config();
                testConn();
                _nik = Nik;
                if (isKaryawan_())
                {
                    _isKaryawan = true;
                    _record_karyawan = Select(_nik);
                    _nama = (string)_record_karyawan[1];
                    _password = (string)_record_karyawan[2];
                    _jabatan = (string)_record_karyawan[3];
                    _alamat = (string)_record_karyawan[4];
                    _memo = (string)_record_karyawan[5];
                    byte[] hsl = (byte[])_record_karyawan[6];
                    if (hsl == null) _foto = new Bitmap(_defimg);
                    else
                    {
                        using (var ms = new MemoryStream(hsl))
                        {
                            _foto = new Bitmap(ms);
                        }
                    }
                    _level = Array.IndexOf(_struktur, _jabatan);
                }
                else
                {
                    _isKaryawan = false;
                    throw new Exception("Invalid NIK");
                }
            }
            catch
            {
                throw;
            }
        }

        public Karyawan(string Nik, string Nama, string Password, string Jabatan, string Alamat = null, string Memo = null, string Foto = null)
        {
            try
            {
                get_config();
                testConn();
                _nik = Nik;
                _nama = Nama;
                _password = Password;
                _jabatan = Jabatan;
                if (Alamat == null) _alamat = "-";
                else _alamat = Alamat;
                if (Memo == null) _memo = "-";
                else _memo = Memo;
                if (Foto == null) _fotopath = _defimg;
                else _fotopath = Foto;
            }
            catch
            {
                throw;
            }
        }

        public int Insert()
        {
            int hsl = 0;
            try
            {
                if (_nik != null && _nama != null && _password != null && _jabatan != null)
                {
                    using (var conn = new MySqlConnection(_cString))
                    {
                        conn.Open();
                        string q1 = "INSERT INTO tbl_karyawan (nik_karyawan,nama_karyawan,pass,jabatan,alamat,memo,foto) VALUES (@nik,@nama,@pass,@jabatan,@alamat,@memo,@image);";
                        using (var cmd = new MySqlCommand(q1, conn))
                        {
                            cmd.Parameters.AddWithValue("@nik", _nik);
                            cmd.Parameters.AddWithValue("@nama", _nama);
                            cmd.Parameters.AddWithValue("@pass", _password);
                            cmd.Parameters.AddWithValue("@jabatan", _jabatan);
                            cmd.Parameters.AddWithValue("@alamat", _alamat);
                            cmd.Parameters.AddWithValue("@memo", _memo);
                            cmd.Parameters.AddWithValue("@image", File.ReadAllBytes(_fotopath));
                            hsl = cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
                else throw new Exception("Gunakan konstruktor yang sesuai untuk menggunakan method ini");
            }
            catch
            {
                throw;
            }
            return hsl;
        }

        public int Update(string oldNik)
        {
            int hsl = 0;
            try
            {
                if (_nik != null && _nama != null && _password != null && _jabatan != null)
                {
                    using (var conn = new MySqlConnection(_cString))
                    {
                        conn.Open();
                        string q1 = "UPDATE tbl_karyawan SET nik_karyawan=@nik,nama_karyawan=@nama,pass=@pass,jabatan=@jabatan,alamat=@alamat,memo=@memo,foto=@image where nik_karyawan=@oldNik;";
                        using (var cmd = new MySqlCommand(q1, conn))
                        {
                            cmd.Parameters.AddWithValue("@nik", _nik);
                            cmd.Parameters.AddWithValue("@nama", _nama);
                            cmd.Parameters.AddWithValue("@pass", _password);
                            cmd.Parameters.AddWithValue("@jabatan", _jabatan);
                            cmd.Parameters.AddWithValue("@alamat", _alamat);
                            cmd.Parameters.AddWithValue("@memo", _memo);
                            cmd.Parameters.AddWithValue("@image", File.ReadAllBytes(_fotopath));
                            cmd.Parameters.AddWithValue("@oldNik", oldNik);
                            hsl = cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
                else throw new Exception("Gunakan konstruktor yang sesuai untuk menggunakan method ini");
            }
            catch
            {
                throw;
            }
            return hsl;
        }

        public int Delete()
        {
            int hsl = 0;
            try
            {
                if (_nik != null)
                {
                    using (var conn = new MySqlConnection(_cString))
                    {
                        conn.Open();
                        string q1 = "DELETE FROM tbl_karyawan WHERE nik_karyawan=@nik";
                        using (var cmd = new MySqlCommand(q1, conn))
                        {
                            cmd.Parameters.AddWithValue("@nik", _nik);
                            hsl = cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
                else throw new Exception("Gunakan konstruktor yang sesuai untuk menggunakan method ini");
            }
            catch
            {
                throw;
            }
            return hsl;
        }

        public List<object> Select(string Nik)
        {
            var hsl = new List<object>();
            _record_karyawan = new List<object>();
            _record_karyawan.Clear();
            using (var conn = new MySqlConnection(_cString))
            {
                conn.Open();
                string q = "SELECT * FROM tbl_karyawan WHERE nik_karyawan=@nik;";
                using (var cmd = new MySqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@nik", _nik);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                hsl.Add(reader.GetValue(i));
                            }
                        }
                    }
                }
                conn.Close();
            }
            return hsl;
        }

        public DataSet Select()
        {
            var hsl = new DataSet();
            _tbl_karyawan = new DataSet();
            using (var conn = new MySqlConnection(_cString))
            {
                string q = "SELECT * FROM tbl_karyawan;";
                using (var da = new MySqlDataAdapter(q, conn))
                {
                    da.Fill(hsl, "tbl_karyawan");
                    for (int i = 0; i < hsl.Tables["tbl_karyawan"].Rows.Count; i++)
                    {
                        if (hsl.Tables["tbl_karyawan"].Rows[i].ItemArray[6] == null)
                            hsl.Tables["tbl_karyawan"].Rows[i].ItemArray[6] = File.ReadAllBytes(_defimg);
                    }
                    _tbl_karyawan = hsl;
                }
            }
            return hsl;
        }

        private bool isKaryawan_()
        {
            bool hsl = false;
            using (var conn = new MySqlConnection(_cString))
            {
                conn.Open();
                string q = "SELECT nik_karyawan FROM tbl_karyawan;";
                using (var cmd = new MySqlCommand(q, conn))
                {
                    List<string> temp = new List<string>();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) temp.Add(reader.GetString("nik_karyawan"));
                    reader.Close();
                    hsl = temp.Contains(_nik);
                }
                conn.Close();
            }
            return hsl;
        }

        //private void getKaryawan(Mode _mode)
        //{
        //    try
        //    {
        //        using (var conn = new MySqlConnection(_cString))
        //        {
        //            conn.Open();
        //            string q1 = "SELECT nama_karyawan, pass, jabatan, alamat, memo FROM tbl_karyawan WHERE nik_karyawan=@nik;";
        //            //string q2 = "SELECT image FROM tbl_karyawan WHERE nik_karyawan=@nik;";
        //            string q3 = "SELECT * FROM tbl_karyawan;";
        //            if (_mode == Mode.Login)
        //            {
        //                using (var cmd = new MySqlCommand(q1, conn))
        //                {
        //                    cmd.Parameters.AddWithValue("@nik", _nik);
        //                    MySqlDataReader reader = cmd.ExecuteReader();
        //                    while (reader.Read())
        //                    {
        //                        _nama = reader.GetString("nama_karyawan");
        //                        _password = reader.GetString("pass");
        //                        _jabatan = reader.GetString("jabatan");
        //                        _alamat = reader.GetString("alamat");
        //                        _memo = reader.GetString("memo");
        //                    }
        //                    reader.Close();
        //                }
        //            }
        //            else if (_mode == Mode.Load)
        //            {
        //                using (var da = new MySqlDataAdapter(q3, conn))
        //                {
        //                    _tbl_karyawan = new DataSet();
        //                    da.Fill(_tbl_karyawan, "tbl_karyawan");
        //                }
        //            }
        //            conn.Close();
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw new Exception(string.Concat("Error Number ", ex.Number, " : ", ex.Message), ex.InnerException);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message, ex.InnerException);
        //    }
        //}

        private void get_config()
        {
            try
            {
                string file1 = @"Config.cfg";
                string file2 = @"default_image.png";
                string message = null;
                var f1 = new FileInfo(file1);
                if (!f1.Exists) message += "File 'Config.cfg' tidak ditemukan \n";
                else
                {
                    using (FileStream fs = new FileStream(file1, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            _config = new string[2];
                            _config[0] = sr.ReadLine().Split('|')[1];
                            _config[1] = sr.ReadLine().Split('|')[1];
                            _cString = _config[0];
                            _struktur = _config[1].Split(',').ToArray();
                        }
                    }
                }
                var f2 = new FileInfo(file2);
                if (!f2.Exists) message += "File 'default_image.png' tidak ditemukan";
                else _defimg = file2;
                if (message != null) throw new Exception(message);
            }
            catch
            {
                throw;
            }
        }
        
        private void testConn()
        {
            try
            {
                using (var conn = new MySqlConnection(_cString))
                {
                    conn.Open();
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(string.Concat("Error Number ", ex.Number, " : ", ex.Message), ex.InnerException);
            }
        }

        #endregion method
    }
}
