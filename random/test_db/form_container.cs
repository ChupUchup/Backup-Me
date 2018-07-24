using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_db
{
    public partial class form_container : Form
    {
        public form_container()
        {
            InitializeComponent();
        }

        private void form_container_Load(object sender, EventArgs e)
        {
            
            var k2 = new Karyawan("K001");
            k2.Select();
            //var k3 = new Karyawan("K006", "maghrib", "9999", "orang",null,null,"D:/Data/Pict/Books.jpg");
            //k3.Insert();

            //var k4 = new Karyawan("K005");
            //k4.Delete();

            var k = new Karyawan();
            k.Select();
            dataGridView1.DataSource = k.table.Tables["tbl_karyawan"];
        }
    }
}
