using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessment_3
{
    internal class Graph
    {
        private LinkedList<GraphNode> nodes;
        
        public Graph()
        {
            nodes = new LinkedList<GraphNode>();
        }

        public void AddNode(string name)
        {
            nodes.AddLast(new GraphNode(name));
        }

        public GraphNode GetNodeByName(string name)
        {
            foreach (GraphNode node in nodes)
            {
                if (node.Name == name)
                {
                    return node;
                }
            }
            return null;
        }

        public void AddEdge(string fromName, string toName)
        {
            GraphNode node_1 = GetNodeByName(fromName);
            GraphNode node_2 = GetNodeByName(toName);
            if (node_1 != null && node_2 != null)
            {
                node_1.AddEdge(node_2);
            }
            else if (node_1 == null)
            {
                Console.WriteLine("Can not find the node with the name " + fromName);
            }
            else if (node_2 == null)
            {
                Console.WriteLine("Can not find the node with the name " + toName);
            }
        }

        public int NodeCount()
        {
            return nodes.Count;
        }

        public int EdgeCount()
        {
            int count = 0;
            foreach (GraphNode node in nodes)
            {
                count += node.GetAdjList().Count;
            }
            return count;
        }

        public List<string> BreathFirstSearch(string startName)
        {
            GraphNode startNode = GetNodeByName(startName);
            if (startNode == null)
            {
                return null;
            }

            List<string> visitedNodes = new List<string>();
            Queue<GraphNode> toVisitNodes = new Queue<GraphNode>();
            toVisitNodes.Enqueue(startNode);

            while (toVisitNodes.Count > 0)
            {
                GraphNode currentNode = toVisitNodes.Dequeue();

                if (!visitedNodes.Contains(currentNode.Name))
                {
                    visitedNodes.Add(currentNode.Name);
                    foreach (string name in currentNode.GetAdjList())
                    {
                        GraphNode node = GetNodeByName(name);
                        if (!visitedNodes.Contains(name) && !toVisitNodes.Contains(node))
                        {
                            toVisitNodes.Enqueue(node);
                        }
                    }
                }   
            } 
            
            return visitedNodes;
        }

        public bool CanTraverseBetween(string startName, string endName)
        {
            List<string> visitedNodes = BreathFirstSearch(startName);
            if (visitedNodes == null)
            {
                return false;
            }
            return visitedNodes.Contains(endName);
        }
    }
}
