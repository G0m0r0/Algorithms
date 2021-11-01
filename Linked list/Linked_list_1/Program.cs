namespace Liked_list_1
{
    partial class Program
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