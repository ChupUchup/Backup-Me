using System;

namespace Citra
{
    public static class Change
    {
        /// <summary>
        /// Convert to Integer
        /// </summary>
        /// <param name="character">Char</param>
        /// <returns>Int</returns>
        public static int toInt(char character) { return (int)character; }
        /// <summary>
        /// Convert to Integer
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="fromBase">2 = Binary, 8 = Octal, 16 = Hexadecimal</param>
        /// <returns>Int</returns>
        public static int toInt(string value, int fromBase) { return Convert.ToInt32(value, fromBase); }

        /// <summary>
        /// Convert to Character
        /// </summary>
        /// <param name="number">Int</param>
        /// <returns>Char</returns>
        public static char toChar(int number) { return (char)number; }
        /// <summary>
        /// Convert to Character
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="fromBase">2 = Binary, 8 = Octal, 16 = Hexadecimal</param>
        /// <returns>Char</returns>
        public static char toChar(string value, int fromBase) { return Convert.ToChar(Convert.ToInt32(value, fromBase)); }

        /// <summary>
        /// Convert to Binary
        /// </summary>
        /// <param name="number">Int</param>
        /// <returns>String</returns>
        public static string toBin(int number) { return Convert.ToString(number, 2); }
        /// <summary>
        /// Convert to Binary
        /// </summary>
        /// <param name="character">Char</param>
        /// <returns>String</returns>
        public static string toBin(char character) { return Convert.ToString((int)character, 2); }
        /// <summary>
        /// Convert to Binary
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="fromBase">8 = Octal, 16 = Hexadecimal</param>
        /// <returns>String</returns>
        public static string toBin(string value, int fromBase) { return Convert.ToString(Convert.ToInt32(value, fromBase), 2); }

        /// <summary>
        /// Convert to Octal
        /// </summary>
        /// <param name="number">Int</param>
        /// <returns>String</returns>
        public static string toOct(int number) { return Convert.ToString(number, 8); }
        /// <summary>
        /// Convert to Octal
        /// </summary>
        /// <param name="character">Char</param>
        /// <returns>String</returns>
        public static string toOct(char character) { return Convert.ToString((int)character, 8); }
        /// <summary>
        /// Convert to Octal
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="fromBase">2 = Binary, 16 = Hexadecimal</param>
        /// <returns>String</returns>
        public static string toOct(string value, int fromBase) { return Convert.ToString(Convert.ToInt32(value, fromBase), 8); }

        /// <summary>
        /// Convert to Hexadecimal
        /// </summary>
        /// <param name="number">Int</param>
        /// <returns>String</returns>
        public static string toHex(int number) { return Convert.ToString(number, 16); }
        /// <summary>
        /// Convert to Hexadecimal
        /// </summary>
        /// <param name="character">Char</param>
        /// <returns>String</returns>
        public static string toHex(char character) { return Convert.ToString((int)character, 16); }
        /// <summary>
        /// Convert to Hexadecimal
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="fromBase">2 = Binary, 8 = Octal</param>
        /// <returns>String</returns>
        public static string toHex(string value, int fromBase) { return Convert.ToString(Convert.ToInt32(value, fromBase), 16); }
    }
}
