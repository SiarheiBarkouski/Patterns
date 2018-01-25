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

        public BitmapsPool(int maxSize)
        {
            _maxSize = maxSize;
        }

        public void Initialize(Bitmap original)
        {
            _adapter = new BitmapAdapter(original);
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
