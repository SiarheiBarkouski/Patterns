using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class CollectionInt : IEnumerable<int>, IObservable<CollectionInt>
    {
        private readonly IList<IObserver<CollectionInt>> _listeners = new List<IObserver<CollectionInt>>();
        private List<int> _items;

        public CollectionInt()
        {
            _items = new List<int>();
        }

        public void AddItem(int number)
        {
            _items.Add(number);
            Notify();
        }

        public void RemoveItem(int number)
        {
            _items.Remove(number);
            Notify();
        }

        public void Sort()
        {
            _items.Sort();
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in _items)
            {                
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IDisposable Subscribe(IObserver<CollectionInt> observer)
        {
            _listeners.Add(observer);
            return new Unsubscriber(this, observer);
        }

        private void Notify()
        {
            foreach (var listener in _listeners)
            {
                listener.OnNext(this);
            }
        }
                   
        private class Unsubscriber : IDisposable
        {
            private readonly CollectionInt _collectionInt;
            private readonly IObserver<CollectionInt> _listener;

            public Unsubscriber(CollectionInt collectionInt, IObserver<CollectionInt> listener)
            {
                _collectionInt = collectionInt;
                _listener = listener;
            }

            public void Dispose()
            {
                _collectionInt._listeners.Remove(_listener);
            }
        }


    }
}
