using System;
using System.Windows.Media.Imaging;

namespace Flyweight
{
    class Whitespace : Character
    {
        private readonly BitmapImage _img;

        public Whitespace()
        {
            _img = new BitmapImage(new Uri($"{Environment.CurrentDirectory}//letters//_.jpg"));
        }
        
        public override BitmapImage Display()
        {
            return _img;
        }

    }
}
