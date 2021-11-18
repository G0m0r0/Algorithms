using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckIfStrIsPermutationOfAnother
{
    class Program
    {
        static List<string> allPermutations = new List<string>();
        static void Main()
        {
            //Check Permutation: Given two strings, write a method to decide if one is a permutation of the other
            var str1 = "abc";
            var str2 = "cba";
            var isPermutation = false;

            if (str1.Length != str2.Length)
            {
                isPermutation = false;
            }
            else
            {
                var str1Ordered = string.Join("", str1.OrderBy(x => x));
                var str2Ordered = string.Join("", str2.OrderBy(x => x));

                if (str1Ordered == str2Ordered)
                {
                    isPermutation = true;
                }
            }

            Console.WriteLine(isPermutation);
        }
    }
}
