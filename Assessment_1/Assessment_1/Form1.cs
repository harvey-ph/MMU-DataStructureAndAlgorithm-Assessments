using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assessment_1
{
    public partial class Form1 : Form
    {
        public int maxSize = 10;
        private CustomerQueue customerQueue;
        
        private BindingSource source = new BindingSource();

        public Form1()
        {
            customerQueue = new CustomerQueue(maxSize);
            InitializeComponent();
            ConfigureDataGridView();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HighlightNewestAndOldestRow()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White; // Resetting background for all rows
            }

            dataGridView1.Rows[customerQueue.Rear].DefaultCellStyle.BackColor = Color.LightGreen; // Highlight newest row

            if (customerQueue.Front != customerQueue.Rear)
            {
                dataGridView1.Rows[customerQueue.Front].DefaultCellStyle.BackColor = Color.LightCoral; // Highlight oldest row
            }
        }

   
        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newCustomer = new Customer(txtName.Text, Convert.ToInt32(txtAge.Text), txtAddress.Text, float.Parse(txtAmountOwed.Text));
                customerQueue.Enqueue(newCustomer);
                customerQueue.Display();

                dataGridView1.Rows[customerQueue.Rear].SetValues(customerQueue.Rear.ToString(), txtName.Text, txtAge.Text, txtAddress.Text, txtAmountOwed.Text);


                // Highlight the newest row and reset others
                HighlightNewestAndOldestRow();

                UpdateStatistics();
                UpdateMaxAmountOwed();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnPop_Click(object sender, EventArgs e)
        {
  
            if (customerQueue.Count == 0)
            {
                MessageBox.Show("Queue is empty.");
                return;
            }

            Customer removingCustomer = customerQueue.Peek();
            string notification = $"Are you sure you want to remove the following customer?\n\n" +
                                  $"Name: {removingCustomer.Name}\n" +
                                  $"Age: {removingCustomer.Age}\n" +
                                  $"Address: {removingCustomer.Address}\n" +
                                  $"Amount Owed: {removingCustomer.AmountOwed}";
            DialogResult dialogResult = MessageBox.Show(notification, "Confirm removing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView1.Rows[customerQueue.Front].SetValues(customerQueue.Front.ToString(), "", "", "", "");

                customerQueue.Dequeue();
                
                HighlightNewestAndOldestRow();

                UpdateStatistics();
                UpdateMaxAmountOwed();
            }

        }

        private void UpdateStatistics()
        {
            int customerCount = customerQueue.Count;
            float totalAmountOwed = customerQueue.TotalAmountOwed;

            lblTotalAmount.Text = "Total Amount Owed: " + totalAmountOwed.ToString();
            lblCount.Text = "Customer Count: " + customerCount.ToString();
        }

        private void UpdateMaxAmountOwed()
        {
            if (customerQueue.Count == 0)
            {
                dataGridView1.Rows[maxSize].SetValues("Max", "", "", "", "");
            }
            else
            {
                Customer maxCustomer = customerQueue.GetMaxAmountCustomer();
                dataGridView1.Rows[maxSize].SetValues("Max", maxCustomer.Name, maxCustomer.Age, maxCustomer.Address, maxCustomer.AmountOwed);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnCount = 4;
            DataGridViewTextBoxColumn indexColumn = new DataGridViewTextBoxColumn();
            indexColumn.HeaderText = "#";
            indexColumn.Name = "IndexColumn";
            indexColumn.ReadOnly = true;
            indexColumn.Width = 30;
            dataGridView1.Columns.Insert(0, indexColumn);
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Age";
            dataGridView1.Columns[3].Name = "Address";
            dataGridView1.Columns[4].Name = "AmountOwed";

            for (int i = 0; i < maxSize; i++)
            {
                dataGridView1.Rows.Add(i.ToString(), "", "", "", ""); // Adding rows with Index
            }

            // Row of customer with maximum amount
            dataGridView1.Rows.Add("Max", "", "", "", "");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmountOwed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }


        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblAmountOwed_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
