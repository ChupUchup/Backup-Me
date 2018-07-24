using System;
using System.Drawing;
using System.Collections.Generic;

namespace Citra
{
    public static class Steganography
    {
        #region variables
        //
        public enum Algorithm { LSB, PC };
        //
        #endregion variables

        #region method
        //
        public static Bitmap Embed(Bitmap image, string message, Algorithm alg)
        {
            if (alg == Algorithm.LSB) return emLSB(image, message);
            else if (alg == Algorithm.PC) return emPC(image, message);
            else return image;
        }
        public static string Extract(Bitmap image, Algorithm alg)
        {
            if (alg == Algorithm.LSB) return exLSB(image);
            else if (alg == Algorithm.PC) return exPC(image);
            else return "No Message in Image";
        }
        private static Bitmap emLSB(Bitmap image, string message)
        {
            Bitmap hsl = null;
            if (string.IsNullOrEmpty(message)) hsl = image;
            else if (image == null) throw new Exception("Citra tidak boleh null");
            else if ((message.Length * 8) + 32 > image.Width * image.Height * 3) throw new Exception("Message melebihi kapasitas citra");
            else
            {
                string bitMessage = "";
                foreach (char i in message) bitMessage += (Change.toBin(i).PadLeft(8, '0'));
                bitMessage = bitMessage.Insert(0, Change.toBin(message.Length).PadLeft(32, '0'));
                var Pixel = getPixel(image);
                char flag = 'R';
                for (int i = 0; i < bitMessage.Length; i++)
                {
                    int x = i / 3;
                    if (flag == 'R')
                    {
                        flag = 'G';
                        Pixel[x] = Color.FromArgb(Pixel[x].A, newColor(Pixel[x].R, bitMessage.Substring(i, 1), 7), Pixel[x].G, Pixel[x].B);
                    }
                    else if (flag == 'G')
                    {
                        flag = 'B';
                        Pixel[x] = Color.FromArgb(Pixel[x].A, Pixel[x].R, newColor(Pixel[x].G, bitMessage.Substring(i, 1), 7), Pixel[x].B);
                    }
                    else if (flag == 'B')
                    {
                        flag = 'R';
                        Pixel[x] = Color.FromArgb(Pixel[x].A, Pixel[x].R, Pixel[x].G, newColor(Pixel[x].B, bitMessage.Substring(i, 1), 7));
                    }
                }
                hsl = getImage(Pixel, image.Size);
            }
            return hsl;
        }
        private static Bitmap emPC(Bitmap image, string message)
        {
            return new Bitmap(0, 0);
        }
        private static string exLSB(Bitmap image)
        {
            string hsl = "";
            if (image != null)
            {
                string bitMessage = "";
                int mLength = 0;
                var Pixel = getPixel(image);
                char flag = 'R';
                for (int i = 0; i < 32; i++)
                {
                    int x = i / 3;
                    if (flag == 'R')
                    {
                        flag = 'G';
                        bitMessage += (getBit(Pixel[x].R, 7));
                    }
                    else if (flag == 'G')
                    {
                        flag = 'B';
                        bitMessage += (getBit(Pixel[x].G, 7));
                    }
                    else if (flag == 'B')
                    {
                        flag = 'R';
                        bitMessage += (getBit(Pixel[x].B, 7));
                    }
                }
                mLength = Change.toInt(bitMessage, 2);
                bitMessage = "";
                for (int i = 32; i < 32 + (mLength * 8); i++)
                {
                    int x = i / 3;
                    if (flag == 'R')
                    {
                        flag = 'G';
                        bitMessage += (getBit(Pixel[x].R, 7));
                    }
                    else if (flag == 'G')
                    {
                        flag = 'B';
                        bitMessage += (getBit(Pixel[x].G, 7));
                    }
                    else if (flag == 'B')
                    {
                        flag = 'R';
                        bitMessage += (getBit(Pixel[x].B, 7));
                    }
                }
                for (int i = 0; i < bitMessage.Length; i += 8)
                {
                    hsl += (Change.toChar(bitMessage.Substring(i, 8), 2));
                }
            }
            return hsl;
        }
        private static string exPC(Bitmap image)
        {
            return "";
        }

        private static List<Color> getPixel(Bitmap image)
        {
            List<Color> hsl = new List<Color>();
            if (image != null)
            {
                for (int h = 0; h < image.Height; h++)
                {
                    for (int w = 0; w < image.Width; w++) { hsl.Add(image.GetPixel(w, h)); }
                }
            }
            return hsl;
        }
        private static Bitmap getImage(List<Color> pixel, Size imgSize)
        {
            Bitmap hsl = null;
            if (pixel != null)
            {
                hsl = new Bitmap(imgSize.Width, imgSize.Height);
                for (int h = 0; h < imgSize.Height; h++)
                {
                    for (int w = 0; w < imgSize.Width; w++) { hsl.SetPixel(w, h, pixel[(h * imgSize.Width) + w]); }
                }
            }
            return hsl;
        }
        private static int newColor(int baseColor, string bitMessage, int pos)
        {
            string bitColor = Change.toBin(baseColor).PadLeft(8, '0');
            //bitColor = string.Concat(bitColor.Substring(0, 7), bitMessage);
            bitColor = bitColor.Insert(pos, bitMessage);
            bitColor = bitColor.Remove(pos + 1, 1);
            return Change.toInt(bitColor, 2);
        }
        private static string getBit(int baseColor, int pos)
        {
            string hsl = Change.toBin(baseColor).PadLeft(8, '0');
            return hsl.Substring(pos, 1);
        }
        //
        #endregion method
    }
}
