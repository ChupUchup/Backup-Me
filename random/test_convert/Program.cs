using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "test Convert";
            do
            {
                Console.WriteLine(toInt('A'));
                Console.WriteLine(toInt("101", 8));
                Console.WriteLine(toInt("41", 16));
                Console.WriteLine(toInt("1000001", 2));

                Console.WriteLine(toChar(65));
                Console.WriteLine(toChar("101", 8));
                Console.WriteLine(toChar("41", 16));
                Console.WriteLine(toChar("1000001", 2));

                Console.WriteLine(toOct(65));
                Console.WriteLine(toOct('A'));
                Console.WriteLine(toOct("41", 16));
                Console.WriteLine(toOct("1000001", 2));

                Console.WriteLine(toHex(65));
                Console.WriteLine(toHex('A'));
                Console.WriteLine(toHex("101", 8));
                Console.WriteLine(toHex("1000001", 2));

                Console.WriteLine(toBin(65));
                Console.WriteLine(toBin('A'));
                Console.WriteLine(toBin("101", 8));
                Console.WriteLine(toBin("41", 16));

                Console.Write("lagi ? y/t : ");
            } while (Char.ToUpper(Console.ReadKey().KeyChar) != 'T');
        }
        
        /// <summary>
        /// Convert to Integer
        /// </summary>
        /// <param name="character">Char</param>
        /// <returns>Int</returns>
        static int toInt(char character) { return (int)character; }
        /// <summary>
        /// Convert to Integer
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="fromBase">2 = Binary, 8 = Octal, 16 = Hexadecimal</param>
        /// <returns>Int</returns>
        static int toInt(string value, int fromBase) { return Convert.ToInt32(value, fromBase); }

        /// <summary>
        /// Convert to Character
        /// </summary>
        /// <param name="number">Int</param>
        /// <returns>Char</returns>
        static char toChar(int number) { return (char)number; }
        /// <summary>
        /// Convert to Character
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="fromBase">2 = Binary, 8 = Octal, 16 = Hexadecimal</param>
        /// <returns>Char</returns>
        static char toChar(string value, int fromBase) { return Convert.ToChar(Convert.ToInt32(value, fromBase)); }

        /// <summary>
        /// Convert to Binary
        /// </summary>
        /// <param name="number">Int</param>
        /// <returns>String</returns>
        static string toBin(int number) { return Convert.ToString(number, 2); }
        /// <summary>
        /// Convert to Binary
        /// </summary>
        /// <param name="character">Char</param>
        /// <returns>String</returns>
        static string toBin(char character) { return Convert.ToString((int)character, 2); }
        /// <summary>
        /// Convert to Binary
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="fromBase">8 = Octal, 16 = Hexadecimal</param>
        /// <returns>String</returns>
        static string toBin(string value, int fromBase) { return Convert.ToString(Convert.ToInt32(value, fromBase), 2); }

        /// <summary>
        /// Convert to Octal
        /// </summary>
        /// <param name="number">Int</param>
        /// <returns>String</returns>
        static string toOct(int number) { return Convert.ToString(number, 8); }
        /// <summary>
        /// Convert to Octal
        /// </summary>
        /// <param name="character">Char</param>
        /// <returns>String</returns>
        static string toOct(char character) { return Convert.ToString((int)character, 8); }
        /// <summary>
        /// Convert to Octal
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="fromBase">2 = Binary, 16 = Hexadecimal</param>
        /// <returns>String</returns>
        static string toOct(string value, int fromBase) { return Convert.ToString(Convert.ToInt32(value, fromBase), 8); }

        /// <summary>
        /// Convert to Hexadecimal
        /// </summary>
        /// <param name="number">Int</param>
        /// <returns>String</returns>
        static string toHex(int number) { return Convert.ToString(number, 16); }
        /// <summary>
        /// Convert to Hexadecimal
        /// </summary>
        /// <param name="character">Char</param>
        /// <returns>String</returns>
        static string toHex(char character) { return Convert.ToString((int)character, 16); }
        /// <summary>
        /// Convert to Hexadecimal
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="fromBase">2 = Binary, 8 = Octal</param>
        /// <returns>String</returns>
        static string toHex(string value,int fromBase) { return Convert.ToString(Convert.ToInt32(value, fromBase), 16); }
    }
}
