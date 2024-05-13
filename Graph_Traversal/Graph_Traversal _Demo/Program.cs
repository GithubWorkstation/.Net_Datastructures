using System;
using System.Collections.Generic;

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
            // Creating graph instance
            Graph graph = new Graph();

            // Adding vertices
            foreach (var vertex in new List<object> { 'A', 'B', 'C', 'D', 'E', 'F' })
            {
                graph.AddVertex(vertex);
            }

            // Adding edges
            graph.AddEdge('A', 'B');
            graph.AddEdge('A', 'C');
            graph.AddEdge('B', 'D');
            graph.AddEdge('B', 'E');
            graph.AddEdge('C', 'F');

            // Perform depth-first traversal
            Console.WriteLine("\nDepth-First Traversal:");
            graph.DepthFirstTraversal('A');
        }
    }

    public class Graph
    {
        private List<object> vertices;
        private Dictionary<object, List<object>> adjacencyList;

        public Graph()
        {
            vertices = new List<object>();
            adjacencyList = new Dictionary<object, List<object>>();
        }

        // Method to add a vertex
        public void AddVertex(object vertex)
        {
            vertices.Add(vertex);
            adjacencyList[vertex] = new List<object>();
        }

        // Method to add an edge
        public void AddEdge(object vertex1, object vertex2)
        {
            adjacencyList[vertex1].Add(vertex2);
            adjacencyList[vertex2].Add(vertex1); // If the graph is undirected
        }

        // Method for depth-first traversal
        public void DepthFirstTraversal(object startVertex, HashSet<object> visited = null)
        {
            if (visited == null)
                visited = new HashSet<object>();

            if (!vertices.Contains(startVertex) || visited.Contains(startVertex))
                return;

            Console.WriteLine($"Visited: {startVertex}");
            visited.Add(startVertex);

            foreach (var neighbor in adjacencyList[startVertex])
            {
                DepthFirstTraversal(neighbor, visited);
            }
        }
    }
}
