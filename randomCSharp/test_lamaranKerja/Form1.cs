using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_lamaranKerja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            //this.Resize += (s, e) => { this.Text = this.Size.ToString(); };
            tabControl1.SelectedIndex = 1;
        }

    }
}
