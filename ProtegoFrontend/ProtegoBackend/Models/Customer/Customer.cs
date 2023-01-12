using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegoBackend.Models.Customer
{
    public abstract class Customer
    {
        public int CustomerId { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public static List<Customer> Customers = new List<Customer>();


        public Customer(int CustomerId, string ContactNumber, string Email)
        {
            this.CustomerId = CustomerId;
            this.ContactNumber = ContactNumber;
            this.Email = Email;
        }

        public string GetCustomerData()
        {
            return this.ToString();
        }

        public static void AddNewCustomer(Customer Customer)
        {
            Customers.Add(Customer);
        }

        public void DeleteCustomer()
        {
            Customers.Remove(this);
        }
    }
}
