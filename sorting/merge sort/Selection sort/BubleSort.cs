namespace Sorting
{
    public static class BubleSort
    {
        public static void SortAscending(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        Swap(ref arr[j],ref arr[j+1]);
                    }
                }
            }                       
        }

        private static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
