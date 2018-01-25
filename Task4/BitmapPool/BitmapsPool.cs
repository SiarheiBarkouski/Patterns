using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapPool
{
    class BitmapsPool
    {
        private readonly int _maxSize;
        private BitmapAdapter _adapter;
        private IList<Bitmap> _bitmaps;
        private string _filePath;

        public BitmapsPool(int maxSize)
        {
            _maxSize = maxSize;
        }

        public void Initialize(string filePath)
        {
            if (filePath.Equals(_filePath)) return;
            _filePath = filePath;
            _adapter = new BitmapAdapter(new Bitmap(_filePath));
            _bitmaps = new List<Bitmap>
            {
                _adapter.Bitmap,
                _adapter.GetNegative(),
                _adapter.GetRotatedLeft90(),
                _adapter.GetRotatedRight90()
            };
        }

        public IList<Bitmap> BitmapList => _bitmaps;
    }
}
