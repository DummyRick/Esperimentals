using System.Runtime.ConstrainedExecution;
using System;

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

        /// <summary>
//        Si usa per trovare il percorso più breve da una singola sorgente a tutti gli altri noti.
//        Spiegazione breve:
//	            - Ci si appoggia ad un'altra struttura che è l'aberto di uscita
//	            - Si scorre tutto usando una coda e un vettore i bool per sapere dove fermarsi.
//	            - Si può fare perché non tocchiamo valori del albero di partenza.
//        Si crea un nuovo albero basato sul grafo.
//        Passi:
//	            - Si decide un nodo sorgente
//	            - Da li si ricavano i collegamenti scorrendo il grafo fino alle foglie.
//	            - Ci si stoppa quando si incontra la fine o un nodo in precedenza visitato.
        /// </summary>
        /// <param name="startVertex"></param>
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
