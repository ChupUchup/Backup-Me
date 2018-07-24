using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        myCalendar mc = new myCalendar();
        private void Form1_Load(object sender, EventArgs e)
        {
            mc.pnel = panelCalendar;
            mc.showCalendar();
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                var tF = Application.OpenForms[0];
                tF.Location = new Point((this.Location.X + this.Width), this.Location.Y);
            }
        }
    }
}
