using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagesComposite
{
    class SimplePage : Page
    {
        public SimplePage()
        {
            Head = @"<meta content='text / html'; charset = 'windows - 1251' />";
        }

        public override string ShowPage()
        {
            var result = $"\t\t{Title}{Environment.NewLine}" +
                         $"\t\t<head>{Environment.NewLine}" +
                         $"\t\t{Head}{Environment.NewLine}" +
                         $"\t\t</head>{Environment.NewLine}" +
                         $"\t\t<body>{Environment.NewLine}" +
                         $"\t\t{Body}{Environment.NewLine}" +
                         $"\t\t</body>{Environment.NewLine}" +
                         $"\t\t---------------------------{Environment.NewLine}";
            return result;
        }
    }
}
