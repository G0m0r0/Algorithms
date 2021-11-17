namespace CustomDataStructures.Contracts
{
    using System.Collections.Generic;
    public interface IMyList<T>
    {
        void Add(T value);
        bool Remove(T value);
        T RemoveAt(int index);
        void Clear();
        void AddRange(ICollection<T> collection);
        bool Contains(T item);
        int Count { get; }
    }
}
