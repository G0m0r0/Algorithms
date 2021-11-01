using System;

namespace Linked_List_2
{
    public partial class Program
    {
        public class SinglyLinkedList
        {
            public Node head;
            public Node tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                var node = new Node(nodeData);

                if (this.head != null)
                {                    
                    this.tail.next = node;
                }
                else
                {
                    this.head = node;
                }

                this.tail = node;
            }

            public void PrintLinkedList()
            {
                Node n = this.head;
                while (n != null)
                {
                    Console.WriteLine(n.data);
                    n = n.next;
                }
            }
        }
    }
}