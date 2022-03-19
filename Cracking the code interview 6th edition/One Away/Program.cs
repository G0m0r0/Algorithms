using System;
using System.Linq;

namespace One_Away
{
    class Program
    {
        // There are three types of edits that can be performed on strings: insert a character, 
        // remove a character, or replace a character.Given two strings, write a function to check if they are
        // one edit  away.
        // EXAMPLE
        // pale, ple -> true 
        // pales, pale -> true 
        // pale, bale -> true 
        // pale, bake -> false 
        // 
        static void Main()
        {
            //insert, remove  length-1
            //replace only one char is different
            var str1 = "pales";
            var str2 = "pale";

            var isTrue = true;

            if (str1 == str2) //equal
            {
                isTrue = true;
            }
            else if (str1.Length == str2.Length || str1.Length == str2.Length - 1 || str1.Length - 1 == str2.Length) //remove and insert
            {
                var length = 0;
                if (str1.Length != str2.Length)
                {
                    length = str1.Length > str2.Length ? str2.Length : str1.Length;
                }

                if (str1.Length == str2.Length)
                {
                    length -= 1;
                }

                for (int i = 0; i < length; i++)
                {
                    if (str1[i] != str2[i]) //case last is different
                    {
                        if (str1.Length < str2.Length)
                        {
                            if (str1[i] != str2[i + 1])
                            {
                                isTrue = false;
                            }
                        }
                        else
                        {
                            if (str1[i + 1] != str2[i])
                            {
                                isTrue = false;
                            }
                        }

                    }

                }
            }
            else
            {
                isTrue = false;
            }

            //one edit away answer
            Console.WriteLine(isTrue);
        }
    }
}
