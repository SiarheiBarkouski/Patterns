using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagesComposite
{
    class DirectoryPage: Page
    {
        private readonly IList<Page> _simplePages;

        public DirectoryPage()
        {
            _simplePages = new List<Page>();
            Head = @"<meta content='text / html'; charset = 'windows - 1251' />";
        }

        public SimplePage AddPage(string title)
        {
            var x = new SimplePage { Title = title };
            _simplePages.Add(x);
            return x;
        }

        public SimplePage AddPage(string title, string body)
        {
            var x = new SimplePage { Title = title, Body = body };
            _simplePages.Add(x);
            return x;
        }

        public override string ShowPage()
        {
            var result = $"\tDirectory Page {Title}{Environment.NewLine}" +
                         $"\t<head>{Environment.NewLine}" +
                         $"\t{Head}{Environment.NewLine}" +
                         $"\t</head>{Environment.NewLine}" +
                         $"\t<body>{Environment.NewLine}" +
                         $"\t{Body}{Environment.NewLine}" +
                         $"\t</body>{Environment.NewLine}" +
                         $"\t---------------------------{Environment.NewLine}";
            return result;
        }

        public string ShowPages()
        {
            var result = String.Empty;
            foreach (var item in _simplePages)
            {
                result += item.ShowPage();
            }
            return result;
        }
    }
}
