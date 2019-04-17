using System;

namespace recursive_drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            RecursiveDrawing(n);
        }
        static void RecursiveDrawing(int index)
        {
            if (index == 0)
                return;
            Console.WriteLine(new string('*',index));
            RecursiveDrawing(index - 1);
            Console.WriteLine(new string('#',index));
        }
    }
}
