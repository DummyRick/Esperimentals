using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApps.Graph
{

    public static class DijkstraAlgorithm
    {
        public static void Main()
        {
            // Example graph represented as an adjacency matrix
            int[,] graph = {
            {0, 2, 4, 0, 0, 0},
            {0, 0, 1, 7, 0, 0},
            {0, 0, 0, 0, 3, 0},
            {0, 0, 0, 0, 0, 1},
            {0, 0, 0, 2, 0, 5},
            {0, 0, 0, 0, 0, 0}
        };

            int startNode = 0;
            int[] distances = Dijkstra(graph, startNode);

            Console.WriteLine("Shortest distances from node " + startNode + ":");
            for (int i = 0; i < distances.Length; i++)
            {
                Console.WriteLine("To node " + i + ": " + distances[i]);
            }
        }

        static int[] Dijkstra(int[,] graph, int startNode)
        {
            int numNodes = graph.GetLength(0);
            int[] distances = new int[numNodes];
            bool[] visited = new bool[numNodes];

            for (int i = 0; i < numNodes; i++)
            {
                distances[i] = int.MaxValue;
                visited[i] = false;
            }

            distances[startNode] = 0;

            for (int count = 0; count < numNodes - 1; count++)
            {
                int minDistance = MinDistance(distances, visited);
                visited[minDistance] = true;

                for (int i = 0; i < numNodes; i++)
                {
                    if (!visited[i] && graph[minDistance, i] != 0 && distances[minDistance] != int.MaxValue &&
                        distances[minDistance] + graph[minDistance, i] < distances[i])
                    {
                        distances[i] = distances[minDistance] + graph[minDistance, i];
                    }
                }
            }

            return distances;
        }

        static int MinDistance(int[] distances, bool[] visited)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int i = 0; i < distances.Length; i++)
            {
                if (!visited[i] && distances[i] <= min)
                {
                    min = distances[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}
