using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Citra
{
    public partial class Demo : Form
    {
        Bitmap _imgA = null, _imgB = null;
        public Demo()
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
                    if (ofd.FileName != "")
                    {
                        _imgA = new Bitmap(ofd.FileName);
                        pBoxA.Image = imgResize(_imgA, pBoxA.Size);
                    }
                }
            }
        }

        private void btnEmbed_Click(object sender, EventArgs e)
        {
            try
            {
                btnExtract.Enabled = false;
                _imgB = new Bitmap(Steganography.Embed(_imgA, txtA.Text, Steganography.Algorithm.LSB));
                pBoxB.Image = imgResize(_imgB, pBoxB.Size);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Informasi"); }
            finally { btnExtract.Enabled = true; }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            txtB.Text = Steganography.Extract(_imgB, Steganography.Algorithm.LSB);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private Bitmap imgResize(Bitmap image, Size newSize)
        {
            Bitmap hsl = null;
            if (image != null)
            {
                var rW = (double)newSize.Width / image.Width;
                var rH = (double)newSize.Height / image.Height;
                var r = Math.Min(rW, rH);
                var nW = (int)(image.Width * r);
                var nH = (int)(image.Height * r);
                hsl = new Bitmap(nW, nH);
                using (var g = Graphics.FromImage(hsl)) { g.DrawImage(image, 0, 0, nW, nH); }
            }
            return hsl;
        }
    }
}
