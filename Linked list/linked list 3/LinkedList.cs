namespace linked_list_3
{
    using linked_list_3.Contracts;
    using System.Text;
    using System;

    public class LinkedList<T> : ILinkedList<T>
    {
        private Node<T> head;
        public LinkedList()
        {
            head = null;
        }

        private static Node<T> CreateNode(T data) => new(data);

        public void AddFirst(T data)
        {
            var toAdd = CreateNode(data);
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(T data)
        {
            var toAdd = CreateNode(data);

            if (head != null)
            {
                var current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
            else
            {
                head = toAdd;
            }
        }

        public void ForEach()
        {
            throw new System.NotImplementedException();
        }

        public void InsertAt(T data, int position)
        {
            var node = CreateNode(data);

            if (this.head == null)
            {
                //if head is null and position is zero then exit.
                if (position != 0)
                {
                    return;
                }
                else
                { //node set to the head.
                    this.head = node;
                }
            }

            if (head != null && position == 0)
            {
                this.AddFirst(data);
                return;
            }

            var current = this.head;
            Node<T> previous = null;

            for (int i = 0; i < position - 1; i++)
            {
                previous = current;
                current = current.next;

                if (current == null)
                {
                    break;
                }
            }

            node.next = current;
            previous.next = node;
        }

        public string Print()
        {
            var sb = new StringBuilder();
            var current = head;
            while (current != null)
            {
                sb.AppendLine(current.data.ToString());
                current = current.next;
            }

            return sb.ToString().TrimEnd();
        }

        public void RemoveAt(int position)
        {
            throw new System.NotImplementedException();
        }

        public T RemoveFirst()
        {
            if (head == null)
            {
                throw new NullReferenceException();
            }

            var dataToRemove = head.data;
            head = head.next;

            return dataToRemove;
        }

        public T RemoveLast()
        {
            var current = head;
            T data = default(T);

            while (current.next != null)
            {
                if (current.next.next == null)
                {
                    data = current.next.data;
                    head = current.next;
                }

                current = current.next;
            }

            //TODO: remove it from colletion

            return data;
        }

        public T[] ToArray()
        {
            throw new System.NotImplementedException();
        }
    }
}