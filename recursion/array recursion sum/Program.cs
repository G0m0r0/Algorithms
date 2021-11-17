using System;
using System.Linq;

namespace array_recursion_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

             int recursionSum = RecursionSumFromZero(array,0);
            //int recursionSum = RecursionFromEnd(array, array.Length - 1);
            Console.WriteLine(recursionSum);
        }
        static int RecursionSumFromZero(int[] array,int i)
        {
            if (i == array.Length)
                return 0;

            Console.WriteLine(array[i]);
            return array[i] + RecursionSumFromZero(array,i+1);
        }
        
        static int RecursionFromEnd(int[] array,int i)
        {
            if (i == 0)
                return array[i];
            return array[i] + RecursionFromEnd(array, i - 1);
        }
    }
}
