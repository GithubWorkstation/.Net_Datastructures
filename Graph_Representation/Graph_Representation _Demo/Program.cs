using System;

namespace GraphDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApplication();
        }

        public static void RunApplication()
        {
            Graph graph = new Graph();

            // Adding vertices
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);

            // Adding edges
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 4);

            // Printing the graph
            graph.PrintGraph();
        }
    }

    class Graph
    {
        private List<int> vertices;
        private Dictionary<int, List<int>> adjacencyList;

        public Graph()
        {
            vertices = new List<int>();
            adjacencyList = new Dictionary<int, List<int>>();
        }

        // Function to add a vertex to the graph
        public void AddVertex(int vertex)
        {
            vertices.Add(vertex);
            adjacencyList[vertex] = new List<int>();
        }

        // Function to add an edge between two vertices
        public void AddEdge(int vertex1, int vertex2)
        {
            adjacencyList[vertex1].Add(vertex2);
            adjacencyList[vertex2].Add(vertex1);
        }

        // Function to display the graph
        public void PrintGraph()
        {
            foreach (var vertex in vertices)
            {
                var neighbors = string.Join(", ", adjacencyList[vertex]);
                Console.WriteLine($"{vertex} -> {neighbors}");
            }
        }
    }
}
