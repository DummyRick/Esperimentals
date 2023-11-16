using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApps.Graph
{
    class GraphDFS
    {
        private int vertices;
        private List<int>[] adjacencyList;

        public GraphDFS(int vertices)
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

        public void DFS(int startVertex)
        {
            bool[] visited = new bool[vertices];
            DFSUtil(startVertex, visited);
        }

        private void DFSUtil(int vertex, bool[] visited)
        {
            visited[vertex] = true;
            Console.Write(vertex + " ");

            foreach (int neighbor in adjacencyList[vertex])
            {
                if (!visited[neighbor])
                {
                    DFSUtil(neighbor, visited);
                }
            }
        }
    }

    class DFSExample
    {
        static void Main()
        {
            Graph graph = new Graph(5);

            // Adding edges to the graph
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);

            Console.WriteLine("Depth-First Traversal (starting from vertex 0):");
            graph.DFS(0);
        }
    }
}
