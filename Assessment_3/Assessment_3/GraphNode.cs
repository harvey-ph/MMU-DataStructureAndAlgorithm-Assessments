using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    internal class GraphNode
    {
        private string name; // data stored in the node

        private LinkedList<string> adjList; // list of the IDs of the nodes that are adjacent to this node

        public GraphNode(string name)
        {
            this.name = name;
            adjList = new LinkedList<string>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public void AddEdge(GraphNode to)
        {
            adjList.AddLast(to.Name);
        }

        public  LinkedList<string> GetAdjList()
        {
            return adjList;
        }

        
    }
}
