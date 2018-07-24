using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_top
{
    public partial class Form1 : Form
    {
        bool isDragable = false;
        Point pointMouseDown;
        public Form1()
        {
            InitializeComponent();
            setHandle();
            this.TopMost = true;
            //this.TransparencyKey = this.BackColor = Color.Fuchsia;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setBackground();
        }
        void setBackground()
        {
            Bitmap b = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(b))
            {
                //g.CopyFromScreen(MousePosition.X - pointMouseDown.X, MousePosition.Y - pointMouseDown.Y, 0, 0, this.Size);
                //g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                //pictureBox1.BackgroundImage = null;
                //pictureBox1.BackgroundImage = b;
                //pictureBox1.Image = b;
                //using (Graphics h = Graphics.FromImage(pictureBox1.Image))
                //{
                //    h.DrawImage(b, new Rectangle(pictureBox1.Location, pictureBox1.Size));
                //}
                //pictureBox1.Invalidate();
            }
        }
        void setHandle()
        {
            pictureBox1.MouseDown += (s, e) =>
            {
                if (e.Y < 30) { isDragable = true; pointMouseDown = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y); }
            };
            pictureBox1.MouseUp += (s, e) =>
            {
                if (isDragable) { isDragable = false; setBackground(); }
            };
            pictureBox1.MouseMove += (s, e) =>
            {
                if (isDragable) { this.Location = new Point(MousePosition.X - pointMouseDown.X, MousePosition.Y - pointMouseDown.Y); setBackground(); }
            };
        }
    }
}
