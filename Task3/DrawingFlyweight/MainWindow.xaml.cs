using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrawingFlyweight
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _x1;
        private double _y1;

        private readonly LineFactory _lines;

        public MainWindow()
        {
            InitializeComponent();
            _lines = new LineFactory();

            myCanv.Height = 600;
            myCanv.Width = 600;

            Draw(50,50,400,400);

            this.MouseLeftButtonDown += (os, ea) =>
            {
                _x1 = ea.GetPosition(myCanv).X;
                _y1 = ea.GetPosition(myCanv).Y;
            };

            this.MouseLeftButtonUp += (os, ea) =>
            {
                var x2 = ea.GetPosition(myCanv).X;
                var y2 = ea.GetPosition(myCanv).Y;
                Draw(_x1, _y1, x2, y2);
            };

        }

        private void Draw(double x1, double y1, double x2, double y2)
        {
            var line = _lines.GetLine(x1, y1, x2, y2);
            myCanv.Children.Add(line);
            myCanv.UpdateLayout();
        }
    }
}
