using System;

namespace UniqueCharacterInString
{
    class Program
    {
        static void Main()
        {
            //look if all characters in are unique
            //impliment without additional structures
            string str = "abcdef5.";

            //O(n^2)
            var isUnique = true;
            // for (int i = 0; i < str.Length; i++)
            // {
            //     for (int j = i+1; j < str.Length; j++)
            //     {
            //         if (str[i] == str[j])
            //         {
            //             isUnique = false;
            //         }
            //     }
            // }

            if (str.Length > 256) //is case of ASCII
            {
                isUnique = false;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str.Substring(i + 1).Contains(str[i]))
                    {
                        isUnique = false;
                    }
                }
            }

            Console.WriteLine(isUnique);
        }
    }
}
