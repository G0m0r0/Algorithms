namespace CustomDataStructures
{
    using CustomDataStructures.Contracts;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyList<T> :IEnumerable<T>, IMyList<T>
    {
        private T[] arr;
        private int head;
        private const int PowOfResizing = 2;
        private const int InitialSize = 4;
        public MyList()
        {
            arr = new T[InitialSize];
            head = -1;
        }

        public void Add(T value)
        {
            head++;

            if (head >= arr.Length)
            {
                ResizeArrUp();
            }

            arr[head] = value;
        }

        public bool Remove(T value)
        {
            bool isFound = false;
            for (int i = 0; i < head; i++)
            {
                if (arr[i].Equals(value))
                {
                    RemoveAt(i);
                    ResizeArrDown();
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                return false;
            }

            head--;

            return true;
        }

        public void Clear()
        {
            Array.Clear(arr, 0, head + 1);
            head = -1;
            ResizeArrDown();
        }

        public void AddRange(ICollection<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public bool Contains(T item)
        {
            foreach (var element in arr)
            {
                if (element.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public int Count => head + 1;

        public T this[int index]
        {
            get
            {
                CheckIndexWithinRange(index);

                return arr[index];
            }
            set
            {
                CheckIndexWithinRange(index);

                arr[index] = value;
            }
        }

        private void CheckIndexWithinRange(int index)
        {
            if (index < 0 || index > head)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void ResizeArrUp()
        {
            Array.Resize(ref arr, arr.Length * PowOfResizing);
            //or create new arr and copy the elements
        }
        private void ResizeArrDown()
        {
            if (head <= InitialSize)
            {
                Array.Resize(ref arr, InitialSize);
            }
            else
            {
                Array.Resize(ref arr, head);
            }
        }
        public T RemoveAt(int index)
        {
            CheckIndexWithinRange(index);

            var elementToRemove = arr[index];

            for (int a = index; a < head; a++)
            {
                arr[a] = arr[a + 1];
            }

            head--;

            return elementToRemove;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < head+1; i++)
            {
                yield return arr[i];
            }            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
