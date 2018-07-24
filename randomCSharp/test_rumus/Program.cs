using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace test_rumus
{
    class Program
    {
        //[STAThread]
        static Form formChart;
        static Chart c1;
        static ChartArea ca1;
        static Series cs1, cs2, cs3;
        static void Main(string[] args)
        {
            Console.Title = "E = MC^2";
            do
            {
                Console.Clear();
                //double E1, E2, E3, M = 0, C = 0;
                //Console.Write("Input M = "); M = Convert.ToDouble(Console.ReadLine());
                //Console.Write("Input C = "); C = Convert.ToDouble(Console.ReadLine());
                //E1 = Math.Pow((M * C), 2);
                //E2 = M * (Math.Pow(C, 2));
                //E3 = (Math.Pow(M, 2)) + (2 * M * C) + (Math.Pow(C, 2));
                //Console.WriteLine("E = (MC)^2          = " + E1);
                //Console.WriteLine("E = M*(C^2)         = " + E2);
                //Console.WriteLine("E = M^2 + 2MC + C^2 = " + E3);
                int max = 0;
                Console.Write("input max : "); max = Convert.ToInt32(Console.ReadLine());
                double[] a1 = new double[max];
                double[] a2 = new double[max];
                double[] a3 = new double[max];
                for (double i = 0; i < max; i++)
                {
                    a1[(int)i] = Math.Pow((i * i), 2);
                    a2[(int)i] = i * (Math.Pow(i, 2));
                    a3[(int)i] = (Math.Pow(i, 2)) + (2 * i * i) + (Math.Pow(i, 2));
                }
                sform(a1, a2, a3);

                Console.Write("\nPress any key to retry, t = Exit : ");
            } while (char.ToLower(Console.ReadKey().KeyChar) != 't');
        }

        static void sform(double[] A1, double[] A2, double[] A3)
        {
            formChart= new Form();
            formChart.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            formChart.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //formChart.ClientSize = new Size(284, 261);
            formChart.Size = Screen.PrimaryScreen.Bounds.Size;
            formChart.Name = "Form1";
            formChart.Text = "Tampil Chart";
            formChart.MinimizeBox = false;
            formChart.MaximizeBox = false;
            formChart.ResumeLayout(false);
            formChart.TopMost = true;
            formChart.KeyPreview = true;
            //formChart.Text = formChart.ClientSize.ToString();
            formChart.Load += (ss, ee) => { formChart.Location = new Point(0, 0); };
            formChart.KeyDown += (ss, ee) => { if (ee.KeyData == Keys.Escape) formChart.Close(); formChart.Dispose(); };
            
            c1 = new Chart();
            c1.Location =new Point(0, 0);
            c1.Size = formChart.ClientSize;
            ca1 = new ChartArea("chartArea1");
            c1.ChartAreas.Add(ca1);

            //cs1 = new Series("series1");
            //cs1.ChartType = SeriesChartType.Spline;
            //cs1.Points.DataBindY(A1);
            //c1.Series.Add(cs1);

            cs2 = new Series("series2");
            cs2.ChartType = SeriesChartType.Spline;
            cs2.Points.DataBindY(A2);
            c1.Series.Add(cs2);

            cs3 = new Series("series3");
            cs3.ChartType = SeriesChartType.Spline;
            cs3.Points.DataBindY(A3);
            c1.Series.Add(cs3);

            formChart.Controls.Add(c1);
            formChart.ShowDialog();
        }
    }
}
