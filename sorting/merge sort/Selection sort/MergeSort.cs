namespace Sorting
{
    public static class MergeSort
    {
        public static int[] SortAscending(int[] arr)
        {
            int[] right;
            int[] left;
            int[] result = new int[arr.Length];

            if (arr.Length <= 1)
                return arr;

            int midPoint = arr.Length / 2;

            left = new int[midPoint];

            if (arr.Length % 2 == 0)
            {
                right = new int[midPoint];
            }
            else
            {
                right = new int[midPoint + 1];
            }

            for (int i = 0; i < midPoint; i++)
                left[i] = arr[i];

            int x = 0;
            for (int i = midPoint; i < arr.Length; i++)
            {
                right[x] = arr[i];
                x++;
            }

            //Recursively sort the left arr
            left = SortAscending(left);

            //Recursively sort the right arr
            right = SortAscending(right);

            //Merge our two sorted arrays
            result = merge(left, right);

            return result;
        }

        public static int[] merge(int[] left, int[] right)
        {
            int[] result = new int[right.Length + left.Length];
            
            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left arr is less than item on right arr, add that item to the result arr 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right arr wll be added to the results arr
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left arr still has elements, add all its items to the results arr
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right arr still has elements, add all its items to the results arr
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}
