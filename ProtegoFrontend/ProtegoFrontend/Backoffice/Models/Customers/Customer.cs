using MasProjekt.Backoffice.Models.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Customers
{
    public abstract class Customer
    {
        public int CustomerId { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public static List<Customer> Customers = new List<Customer>();
        public List<Vehicle.Vehicle> Vehicles = new List<Vehicle.Vehicle>();
        public List<Insurance.Insurance> Insurances = new List<Insurance.Insurance>();

        public Customer(int CustomerId, string ContactNumber, string Email = "")
        {
            this.CustomerId = CustomerId;
            this.ContactNumber = ContactNumber;
            this.Email = Email;
        }

        public string GetCustomerData()
        {
            return this.ToString();
        }

        public static void AddNewCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void DeleteParticularCustomer()
        {
            Customers.Remove(this);
        }
    }
}
