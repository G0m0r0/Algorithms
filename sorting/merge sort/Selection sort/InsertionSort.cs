﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class InsertionSort
    {
        public static int SortAscending(int[] arr)
        {
            int interations = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    interations++;
                    if (arr[j - 1] > arr[j])
                    {
                        Swap(ref arr[j-1], ref arr[j]);
                    }
                }
            }

            return interations;
        }

        private static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
