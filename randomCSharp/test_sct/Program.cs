using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_sct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BufferHeight = 1000;
            //for (double x = 0; x <= 360; x++)
            //{
            //    double i = x * Math.PI / 180;
            //    Console.WriteLine(x.ToString().PadLeft(3) + " " + Math.Sin(i).ToString("0.00").PadLeft(6) + " " + Math.Cos(i).ToString("0.00").PadLeft(6) + " " + Math.Tan(i).ToString("0.00").PadLeft(6));
            //}

            //double x = 1366;
            //double y = 360;
            //double a = x / y;
            //Console.WriteLine(a);

            Console.WriteLine(DateTime.Now.ToString("dd/MMMM/yyyy"));

            Console.ReadKey();
        }
    }
}
