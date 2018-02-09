using System;

namespace ServicesFactory.Interfaces
{
    public interface IMessageBoxService
    {
        void CatchException(Action action);
        T CatchException<T>(Func<T> function);
    }
}