namespace HeapStructure
{
    using System;

    class Program
    {
        static void Main()
        {
            //binary heap tree
            var maxHeap = new MaxHeap(new int[] { 1, 2, 3, 4 }, 4);
            var mminHeap = new MinHeap(new int[] { 1, 2, 3, 4 }, 4);
        }
    }
}
