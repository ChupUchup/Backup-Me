using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gdi_test
{
    public partial class form_drawing : Form
    {
        bool mousedown = false;
        Point start, end;
        string current;

        public form_drawing()
        {
            InitializeComponent();
            Canvas.Image = new Bitmap(Canvas.Width, Canvas.Height);
            Canvas.BackgroundImage = new Bitmap(Canvas.Width, Canvas.Height);
        }

        private void form_drawing_Load(object sender, EventArgs e)
        {
            Canvas.Select();  
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            start = uPosition(e);
            mousedown = true;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                end = uPosition(e);
                using (Graphics g = Graphics.FromImage(Canvas.Image))
                {
                    g.Clear(Color.Transparent);
                    draw(g);
                }
                Canvas.Invalidate();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            end = uPosition(e);
            using (Graphics g = Graphics.FromImage(Canvas.BackgroundImage))
            {
                draw(g);
            }
            Canvas.Invalidate();
            mousedown = false;
        }

        private Point uPosition(MouseEventArgs e)
        {
            return new Point(e.Location.X, e.Location.Y);
        }

        private void draw(Graphics g)
        {
            int X = 0;
            int Y = 0;
            int W = end.X - start.X; if (W < 0) W *= -1;
            int H = end.Y - start.Y; if (H < 0) H *= -1;
            if (start.X < end.X && start.Y < end.Y) { X = start.X; Y = start.Y; }
            else if (start.X < end.X && start.Y > end.Y) { X = start.X; Y = end.Y; }
            else if (start.X > end.X && start.Y > end.Y) { X = end.X; Y = end.Y; }
            else if (start.X > end.X && start.Y < end.Y) { X = end.X; Y = start.Y; }

            switch (current)
            {
                case "Pen":
                    using (Graphics h = Graphics.FromImage(Canvas.BackgroundImage))
                    {
                        h.DrawRectangle(Pens.Black, end.X, end.Y, 1, 1);
                    }
                    break;
                case "Line":
                    g.DrawLine(Pens.Black, start, end);
                    break;
                case "Rect":
                    g.DrawRectangle(Pens.Black, X, Y, W, H);

                    break;
                case "Circle":
                    g.DrawEllipse(Pens.Black, X, Y, W, H);
                    break;
            }
        }

        private void Canvas_SizeChanged(object sender, EventArgs e)
        {
            Size _new = Canvas.Size;
            Point _base = new Point(0, 0);
            Bitmap tmp = new Bitmap(_new.Width, _new.Height);
            using (var g = Graphics.FromImage(tmp))
            {
                g.DrawImage(Canvas.BackgroundImage, new Rectangle(_base, _new), new Rectangle(_base, _new), GraphicsUnit.Pixel);
            }
            Canvas.Image = new Bitmap(tmp);
            Canvas.BackgroundImage = new Bitmap(tmp);
            Canvas.Invalidate();
        }

        private void btn_pen_Click_1(object sender, EventArgs e)
        {
            foreach (Button b in panel_tools.Controls)
            {
                b.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
            var x = sender as Button;
            x.BackColor = Color.LightGreen;
            current = x.Text;
        }

    }
}
