using System;

namespace Linked_List_2
{
    public partial class Program
    {
        static void Main()
        {
            var llist = new SinglyLinkedList();

            for (int i = 1; i <= 10; i++)
            {
                llist.InsertNode(i);
            }

            llist.PrintLinkedList();
        }
    }
}