using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    internal class CustomerQueue
    {
        private Customer[] customers;

        
        private int front;
        private int rear;
        private int maxSize;
        private int count;
        private float totalAmountOwed;

        public CustomerQueue(int maxSize)
        {
            this.maxSize = maxSize;
            this.customers = new Customer[maxSize];
            this.front = 0;
            this.rear = -1;
            this.count = 0;
        }

        public void Enqueue(Customer customer)
        {
            if (this.count == this.maxSize)
            {
                throw new InvalidOperationException("Queue is full");
            }
            else
            {
                this.rear = (this.rear + 1) % maxSize;
                this.customers[this.rear] = customer;
                this.count++;
                this.totalAmountOwed += customer.AmountOwed;
                
            }
        } 

        public void Dequeue()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            else
            {
                Console.WriteLine("Customer Dequeued: ");
                this.customers[this.front].GetInformation();

                this.totalAmountOwed -= this.customers[this.front].AmountOwed;
                Customer customer = this.customers[this.front];
                this.front = (this.front + 1) % maxSize;
                this.count--;
                
            }
        }

        public Customer Peek()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return this.customers[this.front];
        }

        public Customer GetMaxAmountCustomer()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            else
            {
                int maxAmount = 0;
                Customer maxAmountCustomer = this.customers[0];
                for (int i = 0; i < this.count; i++)
                {
                    int index = (this.front + i) % maxSize;
                    if (this.customers[index].AmountOwed > maxAmount)
                    {
                        maxAmount = (int)this.customers[index].AmountOwed;
                        maxAmountCustomer = this.customers[index];
                    }
                }
                maxAmountCustomer.GetInformation();
                return maxAmountCustomer;
            }
        }

        public void Display()
        {
            if (this.front == this.rear)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Customers in Queue: ");
                for (int i = 0; i < this.count; i++)
                {
                    int index = (this.front + i) % maxSize;
                    this.customers[index].GetInformation();
                }
            }
        }

        public int Rear
        {
            get { return this.rear; }
            set { this.rear = value; }
        }

        public Customer[] customersList
        {
            get { return this.customers; }
        }

        public int Front
        {
            get { return this.front; }
            set { this.front = value; }
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        public float TotalAmountOwed
        {
            get { return this.totalAmountOwed; }
            set { this.totalAmountOwed = value; }
        }
    }
}
