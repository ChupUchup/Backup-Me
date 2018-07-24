using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "test cmd";
            do
            {
                Console.Clear();
                int startDay = 0, hari = 1;
                Console.Write("input startday : "); startDay = Convert.ToInt32(Console.ReadLine());
                Console.Write("input hari : "); hari = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 30; i++)
                {
                    if ((i + startDay) % 7 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    int x = 0;
                    if (startDay > hari) x = (7 - startDay) + hari;
                    else if (startDay - hari == 0) x = 0;
                    else x = hari;
                    Console.Write((x + (7 * i) + 1) + " ");
                }


                Console.Write("\nLagi? Y/T : ");
            } while (char.ToUpper(Console.ReadKey().KeyChar) != 'T');
        }
    }
}
