using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using test_lite;

namespace test_file
{
    public partial class Form1 : Form
    {
        SQLite Lite = new SQLite();
        string _cuString = null, _cuDb = null, _cuTbl = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dir = new DirectoryInfo(Application.StartupPath);
            var db = dir.GetFiles("*.db");
            foreach (FileInfo f in db) list_db.Items.Add(f.Name);
        }

        private void list_db_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cuDb = list_db.SelectedItem.ToString();
            _cuString = "Data Source=" + _cuDb;
            Lite.cString = _cuString;
            foreach (string i in Lite.tblList(_cuDb).ToArray()) list_tbl.Items.Add(i);
        }

        private void list_tbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cuTbl = list_tbl.SelectedItem.ToString();
            dgv_tbl.DataSource = Lite.selectAll("SELECT * FROM " + _cuTbl).Tables[0];
        }  
    }
}
