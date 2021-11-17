using System;

namespace Sorting
{
    class Program
    {
        static void Main()
        {
            //simple algorithms, good for small collections
            var array = new int[] { 23, 4233, 324, 3423, 231, 52, 2, 3, 4 };
            Console.WriteLine("Initial colletion:");
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine();

            //unstable algorithm O(n^2)
            //iterate throughout arr until it find min value then swaps it
            //SelectionSort.SortAscending(array);

            //stable algorithm  O(n^2)
            //compare values by pairs and swaps
            //BubleSort.SortAscending(array);            

            //stable algorithm O(n^2)
            //compare current value backwards and insert it on the right position
            //InsertionSort.SortAscending(array);

            //stable algorithm merge sort O(n*logn) recursive
            //divide into two parts then again with recursion sort parts them merge them
            //could be used in parallel programing
            //var sortedArr=MergeSort.SortAscending(array);
            //Console.WriteLine(string.Join(" ", sortedArr));

            //stable O(logn), recursive, in some cases merge is better
            //choose a pivot(middle in most cases) we are moving small elements on the left
            //and bigger on the rightt
            //then we sort left then sort right
            QuickSort.SortAscending(array, 0, array.Length - 1);

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
