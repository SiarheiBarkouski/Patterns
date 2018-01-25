using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ClassA
    {
        private int _value;
        private readonly string _fileName;
        private readonly IList<IObserver> _observers = new List<IObserver>();

        public ClassA(string fileName)
        {
            _fileName = fileName;
        }

        public int Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    Notify();
                }
            }
        }

        public void Observe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void StopObserving(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var o in _observers)
            {
                o.OnChange(this, _fileName);
            }
        }
    }
}