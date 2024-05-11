using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    internal class Node
    {
        public Customer customerNode;
        public Node Left;
        public Node Right;

        public Node(Customer customer)
        {
            this.customerNode = customer;
            this.Left = null;
            this.Right = null;
        }

        public Customer CustomerNode
        {
            get { return this.customerNode; }
            set { this.customerNode = value; }
        }
    }
}
