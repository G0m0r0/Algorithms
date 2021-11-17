using CustomDataStructures.Contracts;
using System;

namespace CustomDataStructures
{
    public class MyStack<T> : IMyStack<T>
    {
        private T[] arr;
        private int head;
        private const int PowOfResizing = 2;
        private const int InitialSize = 4;
        public MyStack()
        {
            this.arr = new T[InitialSize];
        }
        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                action(this.arr[i]);
            }
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T element)
        {
            throw new NotImplementedException();
        }
    }
}
