using System.IO;

namespace Liked_list_1
{
    partial class Solution
    {
        class SinglyLinkedList
        {
            public Node head;

            public SinglyLinkedList()
            {
                this.head = null;
            }

            public void PrintSinglyLinkedList()
            {
                var node = this.head;
                while (node != null)
                {
                    System.Console.WriteLine(node.data);
                }
            }

            public void insertNodeAtTail(int data)
            {
                var node = new Node(data);

                if (head != null)
                {
                    head.next = node;
                }
                else
                {
                    head = node;
                }

                this.head = node;
            }
        }
    }
}