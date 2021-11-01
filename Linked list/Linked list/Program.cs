using System;

namespace Linked_list
{
    class Program
    {
        static void Main()
        {
            SingleLinkedList sList = new SingleLinkedList();

            for (int i = 0; i < 100; i++)
            {
                sList.InsertFront(sList,i);
            }

            for (int i = 0; i < 100; i++)
            {
                
            }
        }
    }
}
