using System;
using System.Collections.Generic;

namespace ArrayPermutations
{
    class Program
    {
        static int[] nums = new int[] { 1, 2, 3 };
        static List<IList<int>> list = new List<IList<int>>();
        static void Main()
        {

            DoPermute();
            PrintResult();
        }

        static void DoPermute(int start=0)
        {
            var end = nums.Length-1;
            if (start == end)
            {
                // We have one of our possible n! solutions,
                // add it to the list.
                list.Add(new List<int>(nums));
            }
            else
            {
                for (var i = start; i <= end; i++)
                {
                    Swap(ref nums[start], ref nums[i]);
                    DoPermute(start + 1);
                    Swap(ref nums[start], ref nums[i]);
                }
            }
        }

        static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        static void PrintResult()
        {
            foreach (var l in list)
            {
                Console.WriteLine(string.Join(' ', l));
            }
        }
    }
}
