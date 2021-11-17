namespace linked_list_3.Contracts
{
    interface ILinkedList<T>
    {
        void AddFirst(T element);
        void AddLast(T element);
        T RemoveFirst();
        T RemoveLast();
        void RemoveAt(int position);
        void ForEach(); //goes through the collection and executes a given action
        T[] ToArray();
        void InsertAt(T data, int position);
        string Print();
    }
}
