using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Timers;

namespace Yping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "yPing";
            Console.WindowWidth = 20;
            Console.BufferWidth = 20;
            Timer t = new Timer();
            Ping p = new Ping();
            t.Enabled = true;
            t.Interval = 1000;
            t.Elapsed += (s, a) =>
            {
                Console.WriteLine("time = " + p.Send("google.com", 1000, new byte[1]).RoundtripTime + "ms");
            };
            
            t.Start();
            Console.ReadLine();
        }
    }
}
