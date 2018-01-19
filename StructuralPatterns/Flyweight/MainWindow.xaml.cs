using System;
using System.Collections.Generic;
using System.IO;
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

namespace Flyweight
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DisplaySimbols(string str)
        {
            var chars = str.ToCharArray();
            var f = new CharacterFactory();
            
            foreach (var c in chars)
            {
                try
                {
                    var character = f.GetCharacter(c);
                    sp.Children.Add(new Image {Source = character.Display()});
                }
                catch {}
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sp.Children.Clear();
            DisplaySimbols(tbMain.Text);
        }
    }
}
