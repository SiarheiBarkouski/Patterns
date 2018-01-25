using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class CollectionIntObserver : IObserver<CollectionInt>
    {   
        public CollectionIntObserver()
        {            
        }
        
        public void OnNext(CollectionInt collectionInt)
        {
            collectionInt.Sort();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
