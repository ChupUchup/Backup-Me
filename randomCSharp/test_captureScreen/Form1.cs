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
    public partial class Form1 : Form
    {
        //Form2 form2;
        bool isDragable = false;
        Point pointMouseDown;

        public Form1()
        {
            InitializeComponent();
            setHandle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form2 = new Form2();
            //form2.Load += (ss, ee) =>
            //{
            //    Bitmap img = new Bitmap(300, 300);
                
            //    using (Graphics g = Graphics.FromImage(img))
            //    {
            //        this.Visible = false;
            //        g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, new Size(300, 300));
            //        //PictureBox x = (PictureBox)form2.Controls["pictureBox1"];
            //        //x.Image = img;
            //        this.Visible = true;
            //        form2.BackgroundImage = img;
                    
            //    }
                
            //};
            //form2.Show();
            //this.Select();
        }
        
        void Transparent()
        {
            this.BackColor = TransparencyKey = Color.Lime; this.AllowTransparency = true;
        }

        void nTransparent()
        {
            this.BackColor = Color.FromKnownColor(KnownColor.Control); AllowTransparency = false;
        }
        
        void setHandle()
        {
            this.MouseDown += (s, e) =>
            {
                Opacity = 0;
                //if (e.Y < 30) { isDragable = true; pointMouseDown = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y); }
                isDragable = true; pointMouseDown = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
            };
            this.MouseUp += (s, e) =>
            {
                changeImg3();
                if (isDragable) { isDragable = false; }//setBackground(); }
            };
            this.MouseMove += (s, e) =>
            {
                //Transparent();
                //changeImg();
                
                if (isDragable)
                {
                    //changeImg(); 
                    
                    this.Location = new Point(MousePosition.X - pointMouseDown.X, MousePosition.Y - pointMouseDown.Y); // setBackground(); }
                    //Opacity = 0;
                    //changeImg3();
                }
            };
        }

        void changeImg()
        {
            Transparent();
            using (Graphics g = Graphics.FromHwnd(this.Handle))
            {
                //using (Graphics g2 = Graphics.FromImage(this.BackgroundImage))
                //{
                //    g2.Clear(Color.Transparent);
                //}
                //g.Clear(Color.FromArgb(0,255,0,0));
                this.Opacity = 0;
                g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            }
            nTransparent();
        }

        void changeImg2()
        {
            Bitmap x = new Bitmap(this.Width, this.Height);
            //Transparent();
            //this.BackgroundImage = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(x))
            {
                //g.Clear(Color.Transparent);
                g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                this.BackgroundImage = x;
            }
            nTransparent();
        }

        void changeImg3()
        {
            //Bitmap x = new Bitmap(this.Width, this.Height);
            //using (Graphics g = Graphics.FromImage(x))
            //{
            //    g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //    this.BackgroundImage = x;
            //}
            //Transparent();
            //Opacity = 0;
            using (Graphics g = Graphics.FromHwnd(this.Handle))
            {
                g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                g.DrawRectangle(new Pen(Color.Black), new Rectangle(0, 0, this.Size.Width - 1, this.Size.Height - 1));
            }
            this.Opacity = 100;
        }

        void changeImg4()
        {
            //Bitmap x = new Bitmap(this.Width, this.Height);
            //using (Graphics g = Graphics.FromImage(x))
            //{
            //    g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //    this.BackgroundImage = x;
            //}
            //Transparent();
            Opacity = 0;
            using (Graphics g = Graphics.FromHwnd(this.Handle))
            {
                g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                g.DrawRectangle(new Pen(Color.Black), new Rectangle(0, 0, this.Size.Width - 1, this.Size.Height - 1));
            }
            Opacity = 100;
        }
        
    }
}
