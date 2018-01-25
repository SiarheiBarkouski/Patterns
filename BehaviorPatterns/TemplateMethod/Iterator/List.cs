using System;
using TemplateMethod.Iterator;

namespace TemplateMethod.Iterator
{
    public class List<T> : IContainer<T>
    {
        private readonly T[] _list;

        public List(params T[] data)
        {
            _list = new T[data.Length];
            data.CopyTo(_list, 0);
        }

        public IIterator<T> CreateIterator()
        {
            return new ForwardIterator(_list);
        }

        private class ForwardIterator : IIterator<T>
        {
            private readonly T[] _sourceList;
            private int _position;

            public ForwardIterator(T[] list)
            {
                _sourceList = new T[list.Length];
                list.CopyTo(_sourceList, 0);
            }

            public void Reset()
            {
                _position = 0;
            }

            public bool MoveNext()
            {
                var result = _position++ < _sourceList.Length - 1;
                if (result == false)
                    Reset();
                return result;
            }

            public T Current => _sourceList[_position];
        }
    }
}
