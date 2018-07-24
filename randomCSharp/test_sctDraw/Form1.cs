using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_sctDraw
{
    public partial class Form1 : Form
    {
        Point pStart = new Point();
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            InitializeEvent();
            pStart = new Point(0, this.ClientSize.Height / 2);
        }

        private void InitializeEvent()
        {
            checkBoxSin.CheckedChanged += (s, e) => { button1_Click(null, null); };
            checkBoxCos.CheckedChanged += (s, e) => { button1_Click(null, null); };
            checkBoxTan.CheckedChanged += (s, e) => { button1_Click(null, null); };
            checkBoxHideLine.CheckedChanged += (s, e) => { button1_Click(null, null); };
            initAngle.ValueChanged += (s, e) => { button1_Click(null, null); };
            scalaY.ValueChanged += (s, e) => { button1_Click(null, null); };
            lineAngle.ValueChanged += (s, e) => { button1_Click(null, null); };
            numTheta.ValueChanged += (s, e) => { button1_Click(null, null); };
            numPow.ValueChanged += (s, e) => { button1_Click(null, null); };
            this.SizeChanged += (s, e) => { button1_Click(null, null); };
            //this.ResizeEnd += (s, e) => { button1_Click(null, null); };
            this.Shown += (s, e) => { button1_Click(null, null); };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /** init variable */
                g = Graphics.FromHwnd(this.Handle);
                Point p0_Sin, p0_Cos, p0_Tan, d, p1_Sin, p1_Cos, p1_Tan, s;
                p0_Sin = p0_Cos = p0_Tan = d = p1_Sin = p1_Cos = p1_Tan = s = new Point(0, 0);
                pStart = new Point(0, this.ClientSize.Height / 2);
                int LineAngle = (int)lineAngle.Value;
                double ScalaY = (double)scalaY.Value;
                double InitAngle = (double)initAngle.Value;
                double NumTheta = (double)numTheta.Value;
                double NumPow = (double)numPow.Value;
                double wid = this.ClientSize.Width;
                double eks = 360;
                double ScalaX = wid / eks;
                /** draw line */
                g.Clear(Color.Black);
                if (!checkBoxHideLine.Checked)
                {
                    if (LineAngle > 0)
                    {
                        for (int i = LineAngle; i <= 360; i += LineAngle)
                        {
                            g.DrawLine(Pens.DimGray, new Point((int)(i * ScalaX), 0), new Point((int)(i * ScalaX), ClientSize.Height));
                        }
                    }
                    g.DrawLine(Pens.DimGray, new Point(0, ClientSize.Height / 2), new Point(ClientSize.Width, ClientSize.Height / 2));
                }
                /** draw curve */
                if (checkBoxSin.Checked || checkBoxCos.Checked || checkBoxTan.Checked)
                {
                    for (int i = 0; i <= 360; i++)
                    {
                        double angle = (i + InitAngle) * Math.PI / 180;
                        if (checkBoxSin.Checked)
                        {
                            double nSin = Math.Pow(Math.Sin(angle * NumTheta), NumPow);
                            p1_Sin = new Point((int)(i * ScalaX), pStart.Y - (int)(nSin * ScalaY));
                            if (i == 0) { p0_Sin = p1_Sin; }
                            g.DrawLine(Pens.Salmon, p0_Sin, p1_Sin);
                            p0_Sin = p1_Sin;
                        }
                        if (checkBoxCos.Checked)
                        {
                            double nCos = Math.Pow(Math.Cos(angle * NumTheta), NumPow);
                            p1_Cos = new Point((int)(i * ScalaX), pStart.Y - (int)(nCos * ScalaY));
                            if (i == 0) { p0_Cos = p1_Cos; }
                            g.DrawLine(Pens.Chartreuse, p0_Cos, p1_Cos);
                            p0_Cos = p1_Cos;
                        }
                        if (checkBoxTan.Checked)
                        {
                            double nTan = 0;
                            try
                            {
                                nTan = Math.Pow(Math.Tan(angle * NumTheta), NumPow);
                                if (nTan > 1000 || nTan < -1000) nTan = 0;
                            }
                            catch { nTan = 0; }
                            //if (i == 90 || i == 270) { nTan = 0; }
                            p1_Tan = new Point((int)(i * ScalaX), pStart.Y - (int)(nTan * ScalaY));
                            if (i == 0) { p0_Tan = p1_Tan; }
                            if (nTan != 0)//!(i == 90 || i == 270))
                            {
                                g.DrawLine(Pens.DeepSkyBlue, p0_Tan, p1_Tan);
                                p0_Tan = p1_Tan;
                            }
                        }

                        //double y4 = nSin + nCos;
                        //s = new Point(i * 2, pStart.Y - (int)(y4 * (double)scalaY.Value)); 
                        //if (i == 0) { d = s; }
                        //g.DrawLine(Pens.Orange, d, s);
                        //d = s;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}

