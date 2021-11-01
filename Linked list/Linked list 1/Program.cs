using System.IO;
using System;

namespace Liked_list_1
{
    partial class Solution
    {
        static void Main()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            for (int i = 0; i < 100; i++)
            {
                llist.insertNodeAtTail(i);

            }

            llist.PrintSinglyLinkedList();
        }
    }
}