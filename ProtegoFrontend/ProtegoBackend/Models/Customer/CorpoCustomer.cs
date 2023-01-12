using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegoBackend.Models.Customer
{
    public class CorpoCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string NIP { get; set; }
        public Address Address { get; set; }

        public CorpoCustomer(int CustomerId, string CompanyName, string NIP, Address Address, string ContactNumber, string Email = "") : base(CustomerId, ContactNumber, Email)
        {
            this.CompanyName = CompanyName;
            this.NIP = NIP;
            this.Address = Address;
        }

        public override string ToString()
        {
            return $"Company Name: {CompanyName} NIP: {NIP} Address {Address} Contact Number: {ContactNumber} Email: {Email}";
        }

        public string PrepareCustomerToSave()
        {
            return $"{CustomerId}; ; ; ;{CompanyName};{NIP};{Address.PrepareAddress()};{ContactNumber};{Email}";
        }
    }
}
