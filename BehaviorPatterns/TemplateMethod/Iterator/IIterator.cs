using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Iterator
{
    public interface IIterator<out T>
    {
        void Reset();
        bool MoveNext();
        T Current { get; }
    }
}
