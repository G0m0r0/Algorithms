namespace Sorting
{
    public static class SelectionSort
    {
        public static void SortAscending(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                Swap(ref arr[i],ref arr[minIndex]);
            }
        }

        private static void Swap(ref int v1,ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
