using System;
using System.Linq;

namespace merge_sort
{
    class Program
    {
        static void Sort(int[] array, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex) //array with one element
            {
                return;
            }
            var middleIndex = (startIndex + endIndex) / 2;

            //split the array
            Sort(array, startIndex, middleIndex); //left portion of the array
            Sort(array, middleIndex + 1, endIndex); //right portion of the array

            //merge
            Merge(array, startIndex, middleIndex, endIndex);
        }

        private static void Merge(int[] array, int startIndex, int middleIndex, int endIndex)
        {
            //already sorted
            if (middleIndex < 0 
                || middleIndex + 1 >= array.Length 
                || array[middleIndex] <= array[middleIndex + 1])
            {
                return;
            }

            int[] helper = new int[array.Length];

            for (int i = startIndex; i <= endIndex; i++)
            {
                helper[i] = array[i];
            }

            int leftIndex = startIndex;
            int rightIndex = middleIndex + 1;

            for (int i = startIndex; i <=endIndex ; i++)
            {
                if(leftIndex>middleIndex)
                {
                    array[i] = helper[rightIndex++];
                }
                else if(rightIndex>endIndex)
                {
                    array[i] = helper[leftIndex++];
                }
                else if(helper[leftIndex]<=helper[rightIndex])
                {
                    array[i] = helper[leftIndex++];
                }
                else
                {
                    array[i] = helper[rightIndex++];
                }
            }
        }

        static void Main(string[] args)
        {
            //O(n*logn)
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Sort(numbers, 0, numbers.Length - 1);
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
