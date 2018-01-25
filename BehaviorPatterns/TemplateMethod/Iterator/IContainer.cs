namespace TemplateMethod.Iterator
{
    interface IContainer<T>
    {
        IIterator<T> CreateIterator();
    }
}
