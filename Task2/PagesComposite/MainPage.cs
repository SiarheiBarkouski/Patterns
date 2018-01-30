using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagesComposite
{
    internal class MainPage : Page
    {
        private readonly IList<Page> _directoryPages;

        public MainPage(string title)
        {
            _directoryPages = new List<Page>();
            Title = title;
            Head = @"<meta content='text / html'; charset = 'windows - 1251' />";
        }

        public DirectoryPage AddPage(string title)
        {
            var x = new DirectoryPage { Title = title};
            _directoryPages.Add(x);
            return x;
        }
        public DirectoryPage AddPage(string title, string body)
        {
            var x = new DirectoryPage {Title = title, Body = body};
            _directoryPages.Add(x);
            return x;
        }

        public override string ShowPage()
        {
            var result = $"MAIN PAGE{Environment.NewLine}" +
                         $"{Title}{Environment.NewLine}" +
                         $"<head>{Environment.NewLine}" +
                         $"{Head}{Environment.NewLine}" +
                         $"</head>{Environment.NewLine}" +
                         $"<body>{Environment.NewLine}" +
                         $"{Body}{Environment.NewLine}" +
                         $"</body>{Environment.NewLine}" +
                         $"---------------------------{Environment.NewLine}";
            return result;
        }

        public string ShowWebSite()
        {
            var result = ShowPage();
            foreach (var item in _directoryPages)
            {
                result += item.ShowPage();
                result += ((DirectoryPage)item).ShowPages();
            }
            return result;
        }
    }
}
