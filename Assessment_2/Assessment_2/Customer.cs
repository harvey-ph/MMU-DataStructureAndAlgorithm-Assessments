using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    internal class Customer : IComparable
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

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Customer otherCustomer = obj as Customer;

            if (otherCustomer != null)
                return this.Name.CompareTo(otherCustomer.Name);
            else
                throw new ArgumentException("Object is not a Customer");
            throw new NotImplementedException();
        }

        public string getValues()
        {
            return $"{Name} - Age: {Age}, Address: {Address}, Amount Owed: £{AmountOwed}";
        }

        public void GetInformation()
        {
            Console.WriteLine("Name: " + this.name + " - " + "Age: " + this.age + " - " + "Address: " + this.address + " - " + "Amount Owed: " + this.amountOwed);
        }
    }
}
