using System;
using System.Diagnostics;
using System.Linq;

namespace strPermutations
{
    class Program
    {
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
        }
    }
}
