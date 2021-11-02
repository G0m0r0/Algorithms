namespace Graphs
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            //initialize graph
            var graph = new List<int>[]
            {
                new List<int>{3,6}, //zero is connected with 3 and 6
                new List<int>{2,3,4,5,6}, //first is connected with 2,3,4..
                new List<int>{1,4,5},
                new List<int>{0,1,5},
                new List<int>{1,2,6},
                new List<int>{1,2,3},
                new List<int>{0,1,4} //sixth is connected with the rest
            };

            DFS dfs = new DFS(graph);
            BFS bfs = new BFS(graph);

            for (int i = 0; i < graph.Length; i++)
            {
                dfs.Dfs(i);
            }

            Console.WriteLine();

            for (int i = 0; i < graph.Length; i++)
            {
                bfs.Bfs(i);
            }

        }
    }
}
