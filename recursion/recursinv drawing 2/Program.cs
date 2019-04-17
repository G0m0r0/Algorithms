using System;

namespace recursinv_drawing_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            RecursiveDrawing(n);
        }
        static int RecursiveDrawing(int index)
        {
            if (index == 0)
                return 0;
            Console.WriteLine(new string('*',index));
            RecursiveDrawing(index - 1);
            Console.WriteLine(new string('#',index));
            return 0;
        }
    }
}
