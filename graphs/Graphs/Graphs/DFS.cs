namespace Graphs
{
    using System;
    using System.Collections.Generic;

    public class DFS
    {
        //Uses recursion
        //Depth first search
        private readonly List<int>[] graph;
        private readonly bool[] visited;

        public DFS(List<int>[] graph)
        {
            this.graph = graph;
            this.visited = new bool[this.graph.Length];
        }

        public void Dfs(int n)
        {
            if (!visited[n])
            {
                visited[n] = true;

                foreach (var child in graph[n])
                {
                    Dfs(child);
                }

                Console.Write($"{n} ");
            }
        }
    }
}
