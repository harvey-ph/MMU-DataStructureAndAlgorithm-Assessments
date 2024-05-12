using System;
    using System.Collections.Generic;
    using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph testGraph = new Graph();

            testGraph.AddNode("Dave");  
            testGraph.AddNode("Anwar");
            testGraph.AddNode("Peggy");
            testGraph.AddNode("Rob");
            testGraph.AddNode("Haniy");
            testGraph.AddNode("Rabia");

            testGraph.AddEdge("Dave", "Peggy");
            testGraph.AddEdge("Anwar", "Dave");
            testGraph.AddEdge("Anwar", "Rob");
            testGraph.AddEdge("Peggy", "Rob");
            testGraph.AddEdge("Peggy", "Rabia");
            testGraph.AddEdge("Rob", "Haniy");
            testGraph.AddEdge("Rabia", "Anwar");

            Console.WriteLine("Number of nodes: " + testGraph.NodeCount());
            Console.WriteLine("Number of edges: " + testGraph.EdgeCount());

            Console.WriteLine("\nEnter the name to start: ");
            string startNode = Console.ReadLine();
            List<string> visitedNodes = testGraph.BreathFirstSearch(startNode);
            if (visitedNodes == null)
            {
                Console.WriteLine("Can not find with entered name\n");
            }
            else
            {
                Console.WriteLine("BFS starting from " + startNode + ": " + string.Join(", ", visitedNodes));
            }

            Console.WriteLine("\nChecking traversal between 2 friends: ");
            Console.WriteLine("Enter the name of the first friend: ");
            string friend1 = Console.ReadLine();
            Console.WriteLine("Enter the name of the second friend: ");
            string friend2 = Console.ReadLine();

        
            if (testGraph.CanTraverseBetween(friend1, friend2))
            {
                Console.WriteLine("Can traverse from "+friend1 + " to " + friend2 + " (TRUE)");
            }
            else
            {
                Console.WriteLine("Can NOT traverse from " + friend1 + " to " + friend2 + " (FALSE)");
            }

            Console.ReadKey();
        }
    }
}
