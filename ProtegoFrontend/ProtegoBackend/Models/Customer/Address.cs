using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegoBackend.Models.Customer
{
    public class Address
    {
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }

        public Address(string City, string PostalCode, string Street, string HouseNumber, string FlatNumber)
        {
            this.City = City;
            this.PostalCode = PostalCode;
            this.Street = Street;
            this.HouseNumber = HouseNumber;
            this.FlatNumber = FlatNumber;
        }

        public override string ToString()
        {
            return $"City {City}, Postal Code: {PostalCode}, Street: {Street}, House Number: {HouseNumber}, Flat Number: {FlatNumber}";
        }

        public string PrepareAddress()
        {
            return $"{City};{PostalCode};{Street};{HouseNumber};{FlatNumber}";
        }
    }
}
