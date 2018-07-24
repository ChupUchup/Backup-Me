using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace test_bitmap
{
    public partial class Form1 : Form
    {
        Bitmap _img = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (!Equals(ofd.FileName, ""))
                    {
                        _img = new Bitmap(ofd.FileName);
                        pictBox.BackgroundImage = imgResize(new Bitmap(ofd.FileName), pictBox.Size);
                    }
                }
            }
        }

        private Bitmap imgResize(Bitmap img, Size newSize)
        {
            Bitmap hsl = null;
            if (img != null)
            {
                var rWidth = (double)newSize.Width / img.Width;
                var rHeight = (double)newSize.Height / img.Height;
                var ratio = Math.Min(rWidth, rHeight);
                var nWidth = (int)(img.Width * ratio);
                var nHeight = (int)(img.Height * ratio);
                hsl = new Bitmap(nWidth, nHeight);
                using (var g = Graphics.FromImage(hsl)) { g.DrawImage(img, 0, 0, nWidth, nHeight); }
            }
            return hsl;
        }

        private List<Color> getPixel(Bitmap img)
        {
            List<Color> hsl = new List<Color>();
            if (img != null)
            {
                for (int h = 0; h < img.Height; h++)
                {
                    for (int w = 0; w < img.Width; w++)
                    {
                        hsl.Add(img.GetPixel(w, h));
                    }
                }
            }
            return hsl;
        }
    }
}
