using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DrawingFlyweight
{
    public class LineFactory
    {
        private readonly Dictionary<double[], Line> _lines = new Dictionary<double[], Line>();

        public Line GetLine(params double[] key)
        {
            if (!_lines.ContainsKey(key))
                _lines.Add(key, new Line
                {
                    X1 = key[0],
                    Y1 = key[1],
                    X2 = key[2],
                    Y2 = key[3],
                    Stroke = new SolidColorBrush(Color.FromRgb(30, 100, 190))
                });
            return _lines[key];
        }
    }
}
