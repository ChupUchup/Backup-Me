using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Value = 0;
            hScrollBar2.Value = 0;
            hScrollBar3.Value = 0;
            hScrollBar4.Value = 0;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(hScrollBar2.Value, hScrollBar3.Value, hScrollBar4.Value);
        }
    }
}
