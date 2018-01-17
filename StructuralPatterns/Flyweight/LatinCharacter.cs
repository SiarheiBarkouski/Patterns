using System;
using System.Windows.Media.Imaging;

namespace Flyweight
{
    class LatinCharacter : Character
    {
        public BitmapImage Picture { get; set; }

        public override BitmapImage Display()
        {
            return Picture;
        }
    }
}
