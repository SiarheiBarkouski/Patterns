using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Decorator
{
    class SwitzerlandProduct : Product
    {
        public override void ShowProduct()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CH");
            base.ShowProduct();
        }

    }
}
