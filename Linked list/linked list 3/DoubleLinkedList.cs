namespace linked_list_3
{
    using linked_list_3.Contracts;
    using System;

    public class DoubleLinkedList<T>:ILinkedList<T>
    {
        private DNode<T> head;

        public DoubleLinkedList()
        {
            this.head = null;
        }

        public void AddFirst(T element)
        {
            throw new NotImplementedException();
        }

        public void AddLast(T element)
        {
            throw new NotImplementedException();
        }

        public void ForEach()
        {
            throw new NotImplementedException();
        }

        public void InsertAt(T data, int position)
        {
            throw new NotImplementedException();
        }

        public string Print()
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int position)
        {
            throw new NotImplementedException();
        }

        public T RemoveFirst()
        {
            throw new NotImplementedException();
        }

        public T RemoveLast()
        {
            throw new NotImplementedException();
        }

        public T[] ToArray()
        {
            throw new NotImplementedException();
        }
    }
}
