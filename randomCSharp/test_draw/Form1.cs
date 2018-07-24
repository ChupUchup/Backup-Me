using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_draw
{
    public partial class Form1 : Form
    {
        //Point newLocation = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = new Bitmap(this.Width, this.Height);
            //this.BackColor = Color.White;
            //this.TransparencyKey = this.BackColor;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            //this.TopMost = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.Red), new Rectangle(newLocation, new Size(10, 10)));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //rHWND(new Rectangle(e.Location, new Size(10, 10)));
            //rIMG(new Rectangle(e.Location, new Size(10, 10)));
            
        }

        void rHWND(Rectangle r)
        {
            using (Graphics g = Graphics.FromHwnd(button1.Handle))
            {
                g.Clear(this.BackColor);
                g.DrawEllipse(new Pen(Color.Red), r);
            }
        }

        void rIMG(Rectangle r)
        {
            using (Graphics g = Graphics.FromImage(this.BackgroundImage))
            {
                g.Clear(Color.Transparent);
                g.DrawEllipse(new Pen(Color.Red), r);
                this.Invalidate();
                this.Update();
            }
        }


        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            rHWND(new Rectangle(e.Location, new Size(10, 10)));
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //}
    }
}
