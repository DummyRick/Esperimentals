using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApps.Graph
{

    public class GraphBFS
    {
        private int vertices;
        private List<int>[] adjacencyList;

        public GraphBFS(int vertices)
        {
            this.vertices = vertices;
            adjacencyList = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                adjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adjacencyList[v].Add(w);
        }

        public void BFS(int startVertex)
        {
            bool[] visited = new bool[vertices];
            Queue<int> queue = new Queue<int>();

            visited[startVertex] = true;
            queue.Enqueue(startVertex);

            while (queue.Count != 0)
            {
                startVertex = queue.Dequeue();
                Console.Write(startVertex + " ");

                foreach (int neighbor in adjacencyList[startVertex])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }
    }

    public static class BFSExample
    {
        public static void Main()
        {
            GraphBFS graph = new GraphBFS(6);

            // Adding edges to the graph
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 5);
            graph.AddEdge(4, 5);

            Console.WriteLine("Breadth-First Traversal (starting from vertex 0):");
            graph.BFS(0);
        }
    }
}
