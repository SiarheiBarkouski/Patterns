using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapPool
{
    class BitmapAdapter
    {
        private Bitmap _bitmap;

        public BitmapAdapter(Bitmap image)
        {
            _bitmap = image;
        }

        public Bitmap Bitmap { get => _bitmap; set => _bitmap = value; }

        public Bitmap GetNegative()
        {
            Bitmap clone = (Bitmap)_bitmap.Clone();
            using (Graphics g = Graphics.FromImage(clone))
            {
                ColorMatrix colorMatrix = new ColorMatrix(
                    new float[][]
                    {
                        new float[] {-1, 0, 0, 0, 0},
                        new float[] {0, -1, 0, 0, 0},
                        new float[] {0, 0, -1, 0, 0},
                        new float[] {0, 0, 0, 1, 0},
                        new float[] {1, 1, 1, 0, 1}
                    });

                ImageAttributes attributes = new ImageAttributes();

                attributes.SetColorMatrix(colorMatrix);

                g.DrawImage(clone, new Rectangle(0, 0, clone.Width, clone.Height),
                    0, 0, clone.Width, clone.Height, GraphicsUnit.Pixel, attributes);
            }
            return clone;
        }

        public Bitmap GetRotatedLeft90()
        {
            Bitmap clone = (Bitmap)_bitmap.Clone();
            clone.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return clone;
        }

        public Bitmap GetRotatedRight90()
        {
            Bitmap clone = (Bitmap)_bitmap.Clone();
            clone.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return clone;
        }

    }
    
}

