using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_captureScreen
{
    public partial class Form2 : Form
    {
        bool isDragable = false;
        bool isModePen = false;
        bool isDrawing = false;
        Point pointMouseDown;
        Point pointMouseDrawing;
        List<objectD> DDD = new List<objectD>();

        public Form2()
        {
            InitializeComponent();
            setHandle();
            //this.BackgroundImage = new Bitmap(this.Width, this.Height);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            DDD.Add(new objectD(2, new Rectangle(0, 0, this.Size.Width - 1, this.Size.Height - 1)));
        }

        void setHandle()
        {
            this.MouseDown += (s, e) =>
            {
                if (isModePen) { isDrawing = true; pointMouseDrawing = e.Location; }
                else
                {
                    Opacity = 0;
                    isDragable = true;
                    pointMouseDown = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                }
            };
            this.MouseUp += (s, e) =>
            {
                if (isModePen) { isDrawing = false; }
                else
                {
                    if (isDragable)
                    {
                        isDragable = false;
                        changeImg();
                        //foreach (objectD d in DDD) { d.draw(Graphics.FromHwnd(this.Handle)); }
                    }
                }
            };
            this.MouseMove += (s, e) =>
            {
                if (isModePen)
                {
                    if (isDrawing) { drawLine(e); }
                }
                else
                {
                    if (isDragable)
                    {
                        this.Location = new Point(MousePosition.X - pointMouseDown.X, MousePosition.Y - pointMouseDown.Y);
                    }
                }
            };
        }

        void changeImg()
        {
            using (Graphics g = Graphics.FromHwnd(this.Handle))
            {
                g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                //g.DrawRectangle(new Pen(Color.Black), new Rectangle(0, 0, this.Size.Width - 1, this.Size.Height - 1));
                //DDD[0].draw(g);
            }
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.CopyFromScreen(this.Location.X, this.Location.Y + pictureBox1.Location.Y, 0, 0, pictureBox1.Size);
                //g.DrawRectangle(new Pen(Color.Black), new Rectangle(0, 0, this.Size.Width - 1, this.Size.Height - 1));
                //DDD[0].draw(g);
            }
            //using (Graphics g = Graphics.FromImage(this.BackgroundImage))
            //{
            //    g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //}
            this.Opacity = 100;
        }

        void drawLine(MouseEventArgs e)
        {
            using (Graphics g = Graphics.FromHwnd(this.Handle))
            {
                //g.FillRectangle(Brushes.Red, new Rectangle(mouseMove, new Size(1, 1)));
                g.DrawLine(Pens.Red, pointMouseDrawing, e.Location);
                //DDD.Add(new objectD(1, new Line(pointMouseDrawing, e.Location)));
            }
            //using (Graphics g = Graphics.FromImage(this.BackgroundImage))
            //{
            //    //g.FillRectangle(Brushes.Red, new Rectangle(mouseMove, new Size(1, 1)));
            //    g.DrawLine(Pens.Red, pointMouseDrawing, e.Location);
            //    //DDD.Add(new objectD(1, new Line(pointMouseDrawing, e.Location)));
            //}
            pointMouseDrawing = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isModePen)
            {
                isModePen = false;
                button1.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
            else
            {
                isModePen = true;
                button1.BackColor = Color.Lime;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


    struct Line
    {
        public Line(Point p1, Point p2)
        {
            P1 = p1; P2 = p2;
        }
        public Point P1;
        public Point P2;
    }

    struct objectD
    {
        public objectD(byte T, Line L)
        {
            type = T; Line = L; Rect = new Rectangle();
        }
        public objectD(byte T, Rectangle R)
        {
            type = T; Rect = R; Line = new Line();
        }
        public byte type;
        public Line Line;
        public Rectangle Rect;
        public void draw(Graphics g)
        {
            if (type == 1) { g.DrawLine(Pens.Red, Line.P1, Line.P2); }
            if (type == 2) { g.DrawRectangle(Pens.Red, Rect); }
            if (type == 3) { g.DrawEllipse(Pens.Red, Rect); }
        }
    }


}
