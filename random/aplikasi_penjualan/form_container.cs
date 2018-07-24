using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace aplikasi_penjualan
{
    public partial class form_container : Form
    {
        private form_login f_login;
        private form_karyawan f_karyawan;
        private form_product f_product;
        private form_penjualan f_penjualan;

        public form_container()
        {
            InitializeComponent();
        }

        private void form_container_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            loginToolStripMenuItem_Click(null, null);
            this.WindowState = FormWindowState.Maximized;
        }

        private void karyawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(ref f_karyawan);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(ref f_product);
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(ref f_penjualan);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Aplikasi Jual Beli (Login as : )";
            f_login = new form_login();
            f_login.ShowDialog(this);
            this.Text = "Aplikasi Jual Beli (Login as : " + Program.cName + ")";
        }

        private void showForm<T>(ref T tForm)
        {
            if (tForm == null || !(tForm as Form).IsHandleCreated)
            {
                tForm = (T)Activator.CreateInstance(typeof(T));
            }
            Form hsl = tForm as Form;
            hsl.MdiParent = this;
            hsl.Show();
            hsl.Focus();
        }

        
    }
}
