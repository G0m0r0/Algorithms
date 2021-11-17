using System;
using System.Collections.Generic;

namespace CommonNumbersInSortedArrays
{
    class Program
    {
        static void Main()
        {
            var A = new int[] { 13, 27, 35, 40, 49, 55, 59 };
            var B = new int[] { 17, 35, 39, 40, 55, 58, 60 };

            //O(n) space algorithm
            //O(n) complexity
            var hashB = new HashSet<int>(B);

            for (int i = 0; i < A.Length; i++)
            {
                if (hashB.Contains(A[i]))
                {
                    Console.Write(A[i]+" ");
                }
            }

            //without using extra space for hashset
            Console.WriteLine();
            var start = 0;
            for (int i = start; i < A.Length; i++)
            {
                if(A[i]==B[start])
                {
                    Console.Write(A[i]+" ");
                    start = i;
                }else if (A[i] > B[start])
                {
                    start = i;
                    i--;
                }
            }
        }
    }
}
