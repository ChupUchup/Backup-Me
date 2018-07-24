using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOCraft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hitung()
        {
            int hsl = 0, CL = 0, V = 0;
            hsl = (3 * CL + 13 * V / 10) * (V / 2 + CL + 100) / 100 + 5;
            return hsl;
        }
    }
}
