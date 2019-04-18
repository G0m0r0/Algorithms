using System;
using System.Collections.Generic;

namespace topological_sorting
{
    class Program
    {
        //not finished !
        static List<int>[] graph;
        static bool[] visited;
        static void Main(string[] args)
        {
            //liner order of sorting
            //doest work for undirected graphs
            //it cant be cycle graph
            graph = new List<int>[]
            {
                new List<int>{1,2},
                new List<int>{3,4},
                new List<int>{5},
                new List<int>{2,5},
                new List<int>{3},
                new List<int>{}
            };

            var result = new List<int>();
            var nodes = new HashSet<int>();
        }
    }
}
