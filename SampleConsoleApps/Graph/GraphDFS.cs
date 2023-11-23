namespace SampleConsoleApps.Graph
{
    public class GraphDFS
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
        /// <summary>
        /// Attraversa il grafo prima verificando il nodo corrente, poi spostandosi verso uno dei suoi successori e ripetendo il processo. 
        /// Se il nodo corrente non ha successori da verificare,
        /// torna indietro al suo predecessore e il processo continua (spostandosi verso un altro successore).
        /// Se viene trovata la soluzione la ricerca si arresta.
        /// 
        /// Si basa sul riconoscimento delle relazioni degli archi (relazioni che definiscono una gerachia dei nodi.)
        /// 
        /// </summary>
        /// <param name="startVertex"></param>
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

    public static class DFSExample
    {
        public static void Main()
        {
            GraphDFS graph = new GraphDFS(5);

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
