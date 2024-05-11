using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2
{
    internal class BinaryTree
    {
        private Node root;
        private int count = 0;

        public BinaryTree()
        {
            this.root = null;
        }

        public Node InsertRecursion(Node node, Customer customer)
        {

            if (node == null)
            {
                return new Node(customer);
            }

            Console.WriteLine("Compare point: " + customer.CompareTo(node.CustomerNode));

            if (customer.CompareTo(node.CustomerNode) < 0)
            {
                node.Left = InsertRecursion(node.Left, customer);
            }
            else if (customer.CompareTo(node.CustomerNode) > 0)
            {
                node.Right = InsertRecursion(node.Right, customer);
            }
            return node;
        }

        public void Insert(Customer customer)
        {
            this.count += 1;
            if (root == null)
            {
                root = new Node(customer);
                return;
            }
            InsertRecursion(root, customer);
        }

        public void PrintTree(Node node, string indent = "")
        {
            if (node == null)
            {
                return;
            }

            PrintTree(node.Right, indent + "   ");
            Console.WriteLine(indent + node.CustomerNode.Name);
            PrintTree(node.Left, indent + "   ");
        }

        public string PreOrder()
        {
            List<string> listResult = new List<string>();
            PreOrderRecursion(root, listResult);
            return string.Join(" -> ", listResult);
        }

        public void PreOrderRecursion(Node node, List<string> listResult)
        {
            if (node == null)
            {
                return;
            }

            listResult.Add(node.CustomerNode.Name);
            PreOrderRecursion(node.Left, listResult);
            PreOrderRecursion(node.Right, listResult);
        }

        public string InOrder()
        {
            List<string> listResult = new List<string>();
            InOrderRecursion(root, listResult);
            return string.Join(" -> ", listResult);
        }

        public void InOrderRecursion(Node node, List<string> listResult)
        {
            if (node == null)
            {
                return;
            }

            InOrderRecursion(node.Left, listResult);
            listResult.Add(node.CustomerNode.Name);
            InOrderRecursion(node.Right, listResult);
        }

        public string PostOrder()
        {
            List<string> listResult = new List<string>();
            PostOrderRecursion(root, listResult);
            return string.Join(" -> ", listResult);
        }

        public void PostOrderRecursion(Node node, List<string> listResult)
        {
            if (node == null)
            {
                return;
            }

            PostOrderRecursion(node.Left, listResult);
            PostOrderRecursion(node.Right, listResult);
            listResult.Add(node.CustomerNode.Name);
        }

        public Customer FindingCustomer(string name)
        {
            Node currentNode = Root;
            while (currentNode != null)
            {
                if (currentNode.CustomerNode.Name == name)
                {
                    return currentNode.CustomerNode;
                }
                else if (currentNode.CustomerNode.Name.CompareTo(name) < 0)
                {
                    currentNode = currentNode.Right;
                }
                else
                {
                    currentNode = currentNode.Left;
                }
            }
            return null;
        }

        public Node Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }
    }
}
