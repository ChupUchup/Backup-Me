using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_lite
{
    public partial class Form1 : Form
    {
        SQLite Lite = new SQLite();
        public Form1()
        {
            InitializeComponent();
            //Lite.createDb("db_lite.db");
            Lite.cString = "Data Source=db_lite.db";
            //Lite.createTable(@"CREATE TABLE tbl_karyawan(id_karyawan varchar(10) not null primary key, nama_karyawan varchar(30) not null, _password varchar(20) not null, gender varchar(10), jabatan varchar(20),alamat varchar(50), memo varchar(255));");
            //Lite.createTable(@"CREATE TABLE tbl_test(id varchar(10),nama varchar(30),_password varchar(20));");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reloadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txt_id.Text != null && txt_nama.Text != null && txt_password.Text != null && list_gender.SelectedIndex > -1 && list_jabatan.SelectedIndex > -1)
                {
                    string q1 = @"INSERT INTO tbl_karyawan(id_karyawan,nama_karyawan,_password,gender,jabatan,alamat,memo)VALUES('" +
                        txt_id.Text + "','" +
                        txt_nama.Text + "','" +
                        txt_password.Text + "','" +
                        list_gender.SelectedItem.ToString() + "','" +
                        list_jabatan.SelectedItem.ToString() + "','" +
                        txt_alamat.Text + "','" +
                        txt_memo.Text + "');";
                    string q2 = "SELECT id_karyawan FROM tbl_karyawan WHERE id_karyawan='" + txt_id.Text + "'";
                    if (!Lite.isExist(q2, txt_id.Text))
                    {
                        if (Lite.insert(q1) > 0) MessageBox.Show("data karyawan telah berhasil disimpan", "Informasi");
                    }
                    else MessageBox.Show("data karyawan telah ada", "Informasi");
                }
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message, "Informasi"); }
            reloadData();
        }

        private void reloadData()
        {
            dgv_karyawan.DataSource = Lite.selectAll("SELECT * FROM tbl_karyawan;").Tables[0];
        }
        

    }
}
