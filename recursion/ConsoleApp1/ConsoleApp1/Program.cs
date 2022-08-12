using System.Linq;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Queue<int> a = new Queue<int>();
            a.Enqueue(9);
            a.Enqueue(6);
            a.Enqueue(8);
            a.Enqueue(4);
            a.Enqueue(5);
            a.Enqueue(0);
            a.Enqueue(3);

            a.Dequeue();
            var b = a.ToList();
            b.Sort();

            Console.WriteLine(String.Join(" ", b));
        }
    }
}