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

namespace bartershop
{
    public partial class form_elemen : Form
    {
        public form_elemen()
        {
            InitializeComponent();
        }

        private void form_elemen_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((form_main)Owner).load_price();
        }

        private void form_elemen_Shown(object sender, EventArgs e)
        {
            load_price();
        }

        private void txt_0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter("bartershop.chupy"))
            {
                sw.Write(new StringBuilder(
                    txt_0.Text + "," +
                    txt_1.Text + "," +
                    txt_2.Text + "," +
                    txt_3.Text + "," +
                    txt_4.Text
                    ));
            }
            MessageBox.Show("Data telah tersimpan", "Informasi", MessageBoxButtons.OK);
            load_price();
        }

        void load_price()
        {
            string[] elemen_price;
            using (var sr = new StreamReader("bartershop.chupy"))
            {
                elemen_price = sr.ReadLine().Split(',');
            }
            txt_0.Text = elemen_price[0];
            txt_1.Text = elemen_price[1];
            txt_2.Text = elemen_price[2];
            txt_3.Text = elemen_price[3];
            txt_4.Text = elemen_price[4];
        }
    }
}
