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
    public partial class dayForm : Form
    {
        public dayForm()
        {
            InitializeComponent();
        }

        private void dayForm_Load(object sender, EventArgs e)
        {
            var mF = Application.OpenForms[0];
        }
    }
}
