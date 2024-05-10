using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    internal class Customer
    {
        private string name;
        private int age;
        private string address;
        private float amountOwed;

        public Customer(string name, int age, string address, float amountOwed)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.amountOwed = amountOwed;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public float AmountOwed
        {
            get { return this.amountOwed; }
            set { this.amountOwed = value; }
        }

        public void GetInformation()
        {
            Console.WriteLine("Name: " + this.name + " - " + "Age: " + this.age + " - " + "Address: " + this.address + " - " + "Amount Owed: " + this.amountOwed);
        }
    }
}
