namespace Graphs
{
    using System;
    using System.Collections.Generic;

    public class BFS
    {
        //Breadth first search
        //always go to the closest nodes
        private readonly List<int>[] graph;
        private readonly bool[] visited;

        public BFS(List<int>[] graph)
        {
            this.graph = graph;
            this.visited = new bool[this.graph.Length];
        }

        public void Bfs(int n)
        {
            if (visited[n])
            {
                return;
            }

            var queue = new Queue<int>();
            queue.Enqueue(n);  //if we use stack the result will be DFS bcs it will prints children first
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
    }
}
