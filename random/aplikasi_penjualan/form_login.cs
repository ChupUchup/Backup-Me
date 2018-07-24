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

namespace aplikasi_penjualan
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
            Program.isLogin = false;
            Program.cNIK = null;
            Program.cName = null;
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            try
            {
                Karyawan test = new Karyawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informasi");
                this.Close();
            }
        }

        private void form_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Program.isLogin) Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_nik.Text) && !string.IsNullOrEmpty(txt_pass.Text))
                {
                    Karyawan _karyawan = new Karyawan(txt_nik.Text);
                    if (!string.IsNullOrEmpty(_karyawan.password) && _karyawan.password == txt_pass.Text.ToString())
                    {
                        Program.isLogin = true;
                        Program.cNIK = txt_nik.Text;
                        Program.cName = _karyawan.nama;
                        Program.cLevel = _karyawan.level;
                        this.Close();
                    }
                    else MessageBox.Show("Password Salah", "Informasi");
                }
                else MessageBox.Show("NIK dan Password harus di isi", "Informasi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informasi");
            }
        }

        private void txt_nik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(null, null);
            }
        }
    }
}
