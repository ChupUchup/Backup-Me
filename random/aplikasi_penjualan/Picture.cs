using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace aplikasi_penjualan
{
    class Picture
    {
        public Picture()
        {
        }

        public Bitmap getPicture()
        {
            Bitmap hsl = null;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image File (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK && !ofd.FileName.Equals(""))
                {
                    hsl = new Bitmap(ofd.FileName);
                }
            }
            return hsl;
        }

        public string getPath()
        {
            string hsl = null;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image File (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK && !ofd.FileName.Equals(""))
                {
                    hsl = ofd.FileName;
                }
            }
            return hsl;
        }

        public void Show(Bitmap img, PictureBox target)
        {
            img = new Bitmap(getScaled(img, target.Width, target.Height));
            if (target.Image == null)
            {
                target.Image = new Bitmap(target.Width, target.Height);
            }
            using (Graphics g = Graphics.FromImage(target.Image))
            {
                g.Clear(Color.Transparent);
                g.DrawImage(img,
                    new Rectangle(0, 0, img.Width, img.Height),
                    new Rectangle(0, 0, img.Width, img.Height),
                    GraphicsUnit.Pixel);
                target.Invalidate();
            }
        }

        public void Show(string path, PictureBox target)
        {
            Show(new Bitmap(path), target);
        }

        private Bitmap getScaled(Bitmap img, int w, int h)
        {
            Bitmap hsl = null;
            if (img != null)
            {
                var ratioX = (double)w / img.Width;
                var ratioY = (double)h / img.Height;
                var ratio = Math.Min(ratioX, ratioY);
                var newWidth = (int)(img.Width * ratio);
                var newHeight = (int)(img.Height * ratio);
                hsl = new Bitmap(newWidth, newHeight);
                using (Graphics g = Graphics.FromImage(hsl))
                {
                    g.Clear(Color.Transparent);
                    g.DrawImage(img, 0, 0, newWidth, newHeight);
                }
            }
            return hsl;
        }
    }
}
