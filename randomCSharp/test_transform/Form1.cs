using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_transform
{
    public partial class Form1 : Form
    {
        myDiagram d;

        public Form1()
        {
            InitializeComponent();
            d = new myDiagram(myDiagram.dtype.Center, Graphics.FromHwnd(this.Handle), this.ClientSize);
            this.BackColor = Color.Black;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //d = new myDiagram(Graphics.FromHwnd(this.Handle), this.ClientSize);
            
            
            //d.DrawLine(new Point(0, 0), new Point(50, 50));
            //d.DrawLine(new Point(10, 0), new Point(60, 50));
            //d.DrawLine(new Point(0, 10), new Point(50, 60));

            //d.DrawRect(new Rectangle(50, 50, 100, 100));
            //d.DrawRect(new Rectangle(0, 0, 100, 50));
            //d.DrawRect(new Rectangle(0, 0, 50, 100));

            //d.DrawEllipse(new Rectangle(50, 50, 100, 100));
            //d.DrawEllipse(new Rectangle(0, 0, 100, 50));
            //d.DrawEllipse(new Rectangle(0, 0, 50, 100));

            //d.DrawBox3D(new Box3D(new Point3D(0, 0, 0), new Size3D(100, 100, 100)));

            //d.DrawLine(new Point(10, 20), new Point(60, 20));
            //d.DrawLineRad(new Point(10, 10), new Point(60, 10), 90, 1);
            numericUpDown1.Value = 90;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Graphics.FromHwnd(this.Handle).Clear(Color.Transparent);
            d.DrawLineRad(new Point(50, 50), new Point(100, 50), (int)numericUpDown1.Value, 1);
            d.DrawLineRad(new Point(50, 50), new Point(50, 100), (int)numericUpDown1.Value, 2);
            d.DrawLineRad(new Point(50, 50), new Point(100, 100), (int)numericUpDown1.Value, 3);
        }

    }

    public class myTransform
    {

    }

    public class myDiagram
    {
        #region variable

        public enum dtype { XY, Center };
        private dtype _type;
        //private Form _form;
        //private PictureBox _pbox;
        private Size _size;
        private Point _p0;
        private Graphics _g;

        public dtype Type { get { return _type; } set { _type = value; } }
        //public PictureBox Pbox { get { return _pbox; } set { _pbox = value; } }
        //public Form Form { get { return _form; } set { _form = value; } }
        public Graphics Graphic { get { return _g; } set { _g = value; } }
        
        #endregion variable

        #region constructor

        //public diagram() { _type = type.XY; }
        //public diagram(type type) { _type = type; }
        //public myDiagram(Form form) { _form = form; defaultDiagram(); }
        //public myDiagram(PictureBox pbox) { _pbox = pbox; defaultDiagram(); }
        //public myDiagram(dtype type, Form form) { _form = form; defaultDiagram(type); }
        //public myDiagram(dtype type, PictureBox pbox) { _pbox = pbox; defaultDiagram(type); }
        public myDiagram(Graphics g, Size size) { _g = g; _size = size; defaultDiagram(); }
        public myDiagram(dtype type, Graphics g, Size size) { _g = g; _size = size; defaultDiagram(type); }
        private void defaultDiagram(dtype type = dtype.XY)
        {
            _type = type;
            if (_type == dtype.XY) { _p0 = new Point(0, _size.Height); }
            else if (_type == dtype.Center) { _p0 = new Point(_size.Width / 2, _size.Height / 2); drawDiagram(); }
            
            //_type = type;
            //Size size = new Size(1, 1);
            //if (_pbox != null) size = _pbox.Size;
            //else if (_form != null) size = _form.ClientSize;
            //if (_type == dtype.XY) { _p0 = new Point(0, size.Height); }
            //else if (_type == dtype.Center) { _p0 = new Point(size.Width / 2, size.Height / 2); }
        }
        private void drawDiagram()
        {
            _g.DrawLine(Pens.LightGray, new Point(0, _size.Height / 2), new Point(_size.Width, _size.Height / 2));
            _g.DrawLine(Pens.LightGray , new Point(_size.Width / 2, 0), new Point(_size.Width / 2, _size.Height));
        }

        #endregion constructor

        #region method

        public void DrawLine(Point p1, Point p2)
        {
            //_g.DrawLine(Pens.Black, new Point(p1.X - _p0.X, _p0.Y - p1.Y), new Point(p2.X - _p0.X, _p0.Y - p2.Y));
            _g.DrawLine(Pens.Red, new Point(_p0.X + p1.X, _p0.Y - p1.Y), new Point(_p0.X + p2.X, _p0.Y - p2.Y));
        }

        public void DrawRect(Rectangle r)
        {
            _g.DrawRectangle(Pens.Black, new Rectangle(_p0.X + r.X, _p0.Y - r.Y - r.Height, r.Width, r.Height));
        }

        public void DrawEllipse(Rectangle r)
        {
            _g.DrawEllipse(Pens.Black, new Rectangle(_p0.X + r.X, _p0.Y - r.Y - r.Height, r.Width, r.Height));
        }

        public void DrawBox3D(Box3D Box)
        {
            Point3D p0, px, pxy, py, pz, pxz, pxyz, pyz;
            p0 = Box.Coordinate;
            px = new Point3D(p0.X + Box.Width, p0.Y, p0.Z);
            pxy = new Point3D(p0.X + Box.Width, p0.Y + Box.Height, p0.Z);
            py = new Point3D(p0.X, p0.Y + Box.Height, p0.Z);
            pz = new Point3D(p0.X, p0.Y, p0.Z + Box.Length);
            pxz = new Point3D(p0.X + Box.Width, p0.Y, p0.Z + Box.Length);
            pxyz = new Point3D(p0.X + Box.Width, p0.Y + Box.Height, p0.Z + Box.Length);
            pyz = new Point3D(p0.X, p0.Y + Box.Height, p0.Z + Box.Length);
            DrawRect(new Rectangle(Box.X, Box.Y, Box.Width, Box.Height));
        }

        public void DrawLineRad(Point p1, Point p2, int rad, byte sct)
        {
            Point np2 = new Point();
            double degree = 0;
            if (rad != 0) degree = rad * Math.PI / 180;
            double line = Math.Sqrt(Math.Pow(Math.Abs(p2.X - p1.X), 2) + Math.Pow(Math.Abs(p2.Y - p1.Y), 2));
            if (sct == 1)
            {
                np2 = new Point(p1.X + (int)(Math.Sin(degree) * line), p2.Y);
            }
            else if (sct == 2)
            {
                np2 = new Point(p2.X, p1.Y + (int)(Math.Cos(degree) * line));
            }
            else if (sct == 3)
            {
                np2 = new Point(p1.X + (int)(Math.Sin(degree) * line), p1.Y + (int)(Math.Cos(degree) * line));
            }
            //_g.Clear(Color.Transparent);
            drawDiagram();
            DrawLine(p1, np2);
        }

        #endregion method
    }

    public struct Point3D
    {
        private int _x, _y, _z;
        public Point3D(int x, int y, int z) { _x = x; _y = y; _z = z; }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }
        public int Z { get { return _z; } set { _z = value; } }
        public static Point3D Empty { get { return new Point3D(); } }
    }

    public struct Size3D
    {
        private int _w, _h, _l;
        public Size3D(int width, int height, int length) { _w = width; _h = height; _l = length; }
        public int Width { get { return _w; } set { _w = value; } }
        public int Height { get { return _h; } set { _h = value; } }
        public int Length { get { return _l; } set { _l = value; } }
        public static Size3D Empty { get { return new Size3D(); } }
    }

    public struct Box3D
    {
        private int _x, _y, _z, _w, _h, _l;
        private Point3D _coordinate;
        private Size3D _volume;
        public Box3D(Point3D coordinate, Size3D volume)
        {
            _coordinate = coordinate;
            _volume = volume;
            _x = _coordinate.X; _y = _coordinate.Y; _z = _coordinate.Z;
            _w = _volume.Width; _h = _volume.Height; _l = _volume.Length;
        }
        public Point3D Coordinate { get { return _coordinate; } set { Coordinate = value; setXYZ(); } }
        public Size3D Volume { get { return _volume; } set { Volume = value; setWHL(); } }
        public int X { get { return _x; } set { _x = value; changeCoordinate(); } }
        public int Y { get { return _y; } set { _y = value; changeCoordinate(); } }
        public int Z { get { return _z; } set { _z = value; changeCoordinate(); } }
        public int Width { get { return _w; } set { _w = value; changeVolume(); } }
        public int Height { get { return _h; } set { _h = value; changeVolume(); } }
        public int Length { get { return _l; } set { _l = value; changeVolume(); } }
        public static Box3D Sample { get { return new Box3D(new Point3D(10, 10, 10), new Size3D(30, 30, 30)); } }
        private void changeCoordinate() { _coordinate = new Point3D(_x, _y, _z); }
        private void changeVolume() { _volume = new Size3D(_w, _h, _l); }
        private void setXYZ() { _x = _coordinate.X; _y = _coordinate.Y; _z = _coordinate.Z; }
        private void setWHL() { _w = _volume.Width; _h = _volume.Height; _l = _volume.Length; }
    }
}
