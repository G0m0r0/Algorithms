namespace depth_first_search_DFS
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static List<int>[] graph;
        static bool[] visited;

        static void Bfs(int n)
        {
            var queue = new Queue<int>();
            queue.Enqueue(n);
            visited[n] = true;

            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();
                Console.Write(currentNode + " ");

                foreach (var child in graph[currentNode])
                {
                    if (!visited[child])
                    {
                        queue.Enqueue(child);
                        visited[child] = true;
                    }
                }
            }
        }
        static void Main()
        {
            graph = new List<int>[]
            {
                new List<int>{3,6},        //0
                new List<int>{2,3,4,5,6},  //1
                new List<int>{1,4,5},      //2
                new List<int>{0,1,5},      //3
                new List<int>{1,2,6},      //4
                new List<int>{1,2,3},      //5
                new List<int>{0,1,4},      //6
                new List<int>{8},          //7
                new List<int>{7}           //8
            };

            visited = new bool[graph.Length];

            var components = 0;
            for (int i = 0; i < graph.Length; i++)
            {
                if (!visited[i])
                {
                    components++;
                    Console.Write($"Connected component {components}: ");
                    Bfs(i);
                    Console.WriteLine();
                }
            }
        }
    }
}

