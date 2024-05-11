using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Assessment_2
{
    public partial class Form1 : Form
    {
        private BinaryTree BinaryTree = new BinaryTree();

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void DisplayTree(Node node, TreeNodeCollection treeNodeCollection, int checkPos)
        {
            if (node == null)
            {
                return;
            }
            TreeNode treeNode = new TreeNode(node.CustomerNode.getValues());  // This TreeNode Class is class of .Net Framework
            treeNodeCollection.Add(treeNode);

            if (checkPos == -1)
            {
                treeNode.ForeColor = Color.DarkGreen;
            }
            else if (checkPos == 1)
            {
                treeNode.ForeColor = Color.LightCoral;
            }

            DisplayTree(node.Left, treeNode.Nodes, -1);
            DisplayTree(node.Right, treeNode.Nodes, 1);
        }

        private void UpdateTreeView()
        {
            treeView1.Nodes.Clear();
            if (BinaryTree.Root != null)
            {
                DisplayTree(BinaryTree.Root, treeView1.Nodes, 0);
            }
        }

        private void UpdateStatistics()
        {
            lblTotalNumber.Text = "TOTAL NUMBER OF CUSTOMER: " + BinaryTree.Count;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer(txtName.Text, Convert.ToInt32(txtAge.Text), txtAddress.Text, float.Parse(txtAmountOwed.Text));
                BinaryTree.Insert(customer);
                Console.WriteLine("Customer added to the tree: ");
                customer.GetInformation();

                BinaryTree.PrintTree(BinaryTree.Root);
                UpdateTreeView();
                UpdateStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblTotalNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            string result = BinaryTree.PreOrder();

            if (result.Length == 0)
            {
                MessageBox.Show("No customers in the tree", "PreOrder Traversal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show(result, "PreOrder Traversal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            string result = BinaryTree.InOrder();

            if (result.Length == 0)
            {
                MessageBox.Show("No customers in the tree", "InOrder Traversal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show(result, "InOrder Traversal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            string result = BinaryTree.PostOrder();
            if (result.Length == 0)
            {
                MessageBox.Show("No customers in the tree", "PostOrder Traversal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show(result, "PostOrder Traversal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFindingName_Click(object sender, EventArgs e)
        {
            string findingName = txtFindingName.Text;
            if (string.IsNullOrWhiteSpace(findingName))
            {
                MessageBox.Show("Please enter the name to find", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer customer = BinaryTree.FindingCustomer(findingName);
            if (customer == null)
            {
                MessageBox.Show("Can not find customer with that name!", "Find Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(customer.getValues(), "Find Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
