using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace strPermutations
{
    class Program
    {
        private static HashSet<string> permutationsOfS = new HashSet<string>();
        static void Main()
        {
            var s = "abbc";
            var b = "cbabadcbbabbcbabaabccbabc";

            var sCharArr = s.ToCharArray();

            var st = new Stopwatch();
            st.Start();
            for (int i = 0; i < b.Length-s.Length+1; i++)
            {
                var flag = true;
                string part = b.Substring(i, s.Length);
                for (int j = 0; j < sCharArr.Length; j++)
                {
                    var index = part.IndexOf(sCharArr[j]);
                    if (index==-1)
                    {                      
                        flag = false;
                        break;
                    }
                    
                   part= part.Remove(index,1);
                }
                if (flag)
                {
                    part = b.Substring(i, s.Length);
                    Console.WriteLine(string.Join("",part));
                }
            }
            st.Stop();

            Console.WriteLine(st.Elapsed.TotalSeconds);

            //or
            st.Reset();
            st.Start();
            for (int i = 0; i < b.Length - s.Length + 1; i++)
            {
                var subStr = b.Substring(i, s.Length);
                string bSubString = String.Concat(subStr.ToCharArray().OrderBy(x=>x));
                //sCharArr

                if (bSubString == s)
                {
                    Console.WriteLine(subStr);
                }
            }
            st.Stop();

            Console.WriteLine(st.Elapsed.TotalSeconds);

            //or all unique permutations
            st.Reset();
            st.Start();
            char[] arr = s.ToCharArray();
            CreateAllPermutationsOfS(arr);

            foreach (var item in permutationsOfS)
            {
                if(b.Contains(item))
                {
                    Console.WriteLine(item);
                }
            }
            st.Stop();

            Console.WriteLine(st.Elapsed.TotalSeconds);
        }
        public static void CreateAllPermutationsOfS(char[] list)
        {
            int listLength = list.Length - 1;
            CreateAllPermutationsOfS(list, 0, listLength);
        }

        private static void CreateAllPermutationsOfS(char[] list, int k, int m)
        {
            if (k == m)
            {
                permutationsOfS.Add(String.Concat(list));
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    CreateAllPermutationsOfS(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }
    }
}
