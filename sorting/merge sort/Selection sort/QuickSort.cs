namespace Sorting
{
    public static class QuickSort
    {
        public static void SortAscending(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = partition(arr, left, right);
                SortAscending(arr, left, pivot - 1);
                SortAscending(arr, pivot + 1, right);
            }
        }

        static int partition(int[] arr, int left, int right)
        {
            int i = left;
            int pivot = arr[right];

            for (int j = left; j <= right; j++)
            {
                if (arr[j] < pivot)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                }
            }

            Swap(ref arr[right], ref arr[i]);
            return i;
        }

        private static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
