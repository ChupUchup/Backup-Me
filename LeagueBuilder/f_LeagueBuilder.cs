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

namespace LeagueBuilder
{
    public partial class f_LeagueBuilder : Form
    {
        public f_LeagueBuilder()
        {
            InitializeComponent();
            InitializeEvent();
        }

        void InitializeEvent()
        {
            this.Shown += delegate
            {
                load_peserta();
            };
        }

        void load_peserta()
        {

        }
    }
}
