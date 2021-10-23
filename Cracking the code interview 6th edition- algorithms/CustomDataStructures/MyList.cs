namespace CustomDataStructures
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MyList<T> :IEnumerable<T>
    {
        private T[] arr;
        private int head;
        private readonly int rateOfResizing = 2;
        private readonly int initialSize = 4;
        public MyList()
        {
            arr = new T[initialSize];
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

        public int Count()
        {
            return head + 1;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > head)
                {
                    throw new ArgumentOutOfRangeException("Index error");
                }

                return arr[index];
            }
            set
            {
                if (index < 0 || index > head)
                {
                    throw new ArgumentOutOfRangeException("Index error");
                }

                arr[index] = value;
            }
        }

        private void ResizeArrUp()
        {
            Array.Resize(ref arr, arr.Length * rateOfResizing);
        }
        private void ResizeArrDown()
        {
            if (head <= initialSize)
            {
                Array.Resize(ref arr, initialSize);
            }
            else
            {
                Array.Resize(ref arr, head);
            }
        }
        private void RemoveAt(int index)
        {
            for (int a = index; a < head; a++)
            {
                arr[a] = arr[a + 1];
            }

            head--;
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
