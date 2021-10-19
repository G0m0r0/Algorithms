namespace Cracking_the_code_interview_6th_edition__algorithms
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    class Program
    {
        static void Main()
        {
            Stopwatch st = new Stopwatch();

            int n = 100;

            var list1 = new List<string>();
            st.Start();
            //brute force algorithm
            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    for (int c = 1; c <= n; c++)
                    {
                        for (int d = 1; d <= n; d++)
                        {
                            if (Math.Pow(a, 3) + Math.Pow(b, 3) == Math.Pow(c, 3) + Math.Pow(d, 3))
                            {
                                list1.Add($"{a}+{b}={c}+{d}");
                            }
                        }
                    }
                }
            }
            st.Stop();            

            var st2 = new Stopwatch();
            var list2 = new List<string>();
            st2.Start();
            var map = new Dictionary<double, List<int[]>>();

            for (int c = 1; c <= n; c++)
            {
                for (int d = 1; d <= n; d++)
                {
                    var result = Math.Pow(c, 3) + Math.Pow(d, 3);
                    if (!map.ContainsKey(result))
                    {
                        map[result] = new List<int[]>();
                    }

                    if (map[result].Count == 0)
                        map[result] = new List<int[]>();

                    map[result].Add(new int[2] { c, d });
                }
            }

            foreach (var result in map)
            {
                foreach (var pair1 in result.Value)
                {
                    foreach (var pair2 in result.Value)
                    {
                        list2.Add($"{pair1[0]}+{pair1[1]}={pair2[0]}+{pair2[1]}");
                    }
                }
            }
            st2.Stop();

            Console.WriteLine(st.Elapsed.TotalSeconds);  //14 sec for n=100
            Console.WriteLine(list1.Count);

            Console.WriteLine(st2.Elapsed.TotalSeconds); //0.03 sec for n=100
            Console.WriteLine(list2.Count);
        }
    }
}
