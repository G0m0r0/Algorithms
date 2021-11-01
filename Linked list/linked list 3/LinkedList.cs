using System;
using System.Text;

namespace linked_list_3
{
    public class LinkedList<T>
    {
        private Node<T> head;
        public LinkedList()
        {
            head = null;
        }

        public string PrintAllNodes()
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

        private static Node<T> CreateNode(T data) => new(data);

        public void InsertAtPossition(T data, int position)
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
                node.next = this.head;
                this.head = node;
                return;
            }

            var current = this.head;
            Node<T> previous = null;

            int i = 0;

            while (i < position)
            {
                previous = current;
                current = current.next;

                if (current == null)
                {
                    break;
                }

                i++;
            }

            node.next = current;
            previous.next = node;
        }
    }
}