using System;

namespace Liked_list_1
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
            Node node = this.head;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }

        public void insertNodeAtTail(int data)
        {
            Node node = new Node(data);
            if (head != null)
            {
                this.head.next = node;
            }
            else
            {
                this.head = node;
            }
        }
    }

}