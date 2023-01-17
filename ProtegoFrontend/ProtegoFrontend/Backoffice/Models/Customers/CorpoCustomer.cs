using MasProjekt.Backoffice.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Customers
{
    public class CorpoCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string NIP { get; set; }
        public Adress Adress { get; set; }

        public CorpoCustomer(int CustomerId, string CompanyName, string NIP, Adress Adress, string ContactNumber, string Email = "") : base(CustomerId, ContactNumber, Email)
        {
            this.CompanyName = CompanyName;
            this.NIP = NIP;
            this.Adress = Adress;
        }

        public override string ToString()
        {
            return $"Company Name: {CompanyName} NIP: {NIP} Adress {Adress} Contact Number: {ContactNumber} Email: {Email}";
        }

        public string PrepareCustomerToSave()
        {
            return $"{CustomerId}; ; ; ;{CompanyName};{NIP};{Adress.PrepareAdress()};{ContactNumber};{Email}";
        }
    }
}
