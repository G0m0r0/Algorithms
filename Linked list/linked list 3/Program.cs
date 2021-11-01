using System;

namespace linked_list_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Add First:");
            var myList1 = new LinkedList<string>();

            myList1.AddFirst("Hello");
            myList1.AddFirst("Magical");
            myList1.AddFirst("World");
            Console.WriteLine(myList1.PrintAllNodes());

            Console.WriteLine();

            Console.WriteLine("Add Last:");
            var myList2 = new LinkedList<string>();

            myList2.AddLast("Hello");
            myList2.AddLast("Magical");
            myList2.AddLast("World");
            Console.WriteLine(myList2.PrintAllNodes());

       
            var myList3 = new LinkedList<int>();
            var myList4 = new LinkedList<int>();
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                myList3.AddLast(i);
                myList4.AddFirst(i);
            }

            Console.WriteLine("\nAdd Last numbers:");
            Console.WriteLine(myList3.PrintAllNodes());

            Console.WriteLine("\nAdd First numbers:");
            Console.WriteLine(myList4.PrintAllNodes());

            myList3.InsertAtPossition(100, 2);
            myList3.InsertAtPossition(50, 5);

            Console.WriteLine();
            Console.WriteLine(myList3.PrintAllNodes()); 
        }
    }
}