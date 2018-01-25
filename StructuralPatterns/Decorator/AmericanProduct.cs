using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Decorator
{
    class AmericanProduct : Product
    {
        public override void ShowProduct()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            base.ShowProduct();
        }
    }
}
