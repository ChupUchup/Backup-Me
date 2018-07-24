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
    public partial class form_main : Form
    {
        #region variables

        string[] elemen_name = { "Earth element", "Sea element", "Flame element", "Storm element", "Earth essence" };
        int[] elemen_value = { 25000, 100000, 200000, 500000, 1000000 };
        string[] item_name = { "Book of craftmanship", "Book of expertise", "Book of mastery", "Alchemist stone", "Mandragora", "Enriched adamantium", "Blue saphire", "Depraved seed", "Phoenix feather" };
        int[] item_value = { 200000, 2000000, 12000000, 50000000, 500000, 50000000, 300000, 10000000, 12000000 };
        int elemen_index = -1, item_index = -1;

        #endregion variables

        #region method

        public form_main()
        {
            InitializeComponent();
        }

        private void form_main_Shown(object sender, EventArgs e)
        {
            combo_item.Items.AddRange(item_name);
            combo_elemen.Items.AddRange(elemen_name);
        }

        private void combo_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_index = combo_item.SelectedIndex;
            txt_item.Text = item_value[item_index].ToString("0,0");
            hitung_pajak();
            kalkulasi();
        }

        private void combo_elemen_SelectedIndexChanged(object sender, EventArgs e)
        {
            elemen_index = combo_elemen.SelectedIndex;
            txt_elemen.Text = elemen_value[elemen_index].ToString("0,0");
            load_price();
        }

        private void txt_harga_TextChanged(object sender, EventArgs e)
        {
            kalkulasi();
        }

        void kalkulasi()
        {
            if (item_index > -1 && elemen_index > -1 && txt_need.TextLength > 0)
            {
                double item = item_value[item_index];
                double elemen = elemen_value[elemen_index];
                double need = Convert.ToDouble(txt_need.Text);
                txt_total.Text = (item * need / elemen).ToString();
                if (txt_harga_elemen.TextLength > 0)
                {
                    double harga_elemen = Convert.ToDouble(txt_harga_elemen.Text);
                    txt_harga_item.Text = ((item * need / elemen * harga_elemen) + (item * need / 100)).ToString("0,0");
                }
                else
                    txt_harga_item.Text = "";
            }
        }

        void hitung_pajak()
        {
            if (txt_need.TextLength > 0 && Convert.ToInt32(txt_need.Text) != 0 && item_index > -1)
            {
                double item = item_value[item_index];
                double need = Convert.ToDouble(txt_need.Text);
                txt_pajak.Text = (item * need / 100).ToString("0,0");
            }
            else
                txt_pajak.Text = "";
        }

        private void btn_edit_elemen_Click(object sender, EventArgs e)
        {
            form_elemen f = new form_elemen();
            f.Owner = this;
            f.ShowDialog();
        }

        public void load_price()
        {
            string[] elemen_price;
            using (var sr = new StreamReader("bartershop.chupy"))
            {
                elemen_price = sr.ReadLine().Split(',');
            }
            if (elemen_index > -1)
            {
                txt_harga_elemen.Text = elemen_price[elemen_index];
            }
        }

        private void txt_need_TextChanged(object sender, EventArgs e)
        {
            hitung_pajak();
            kalkulasi();
        }

        private void txt_need_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion method
    }
}
