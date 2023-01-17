using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Common
{
    public class Adress
    {
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }

        public Adress(string City, string PostalCode, string Street, string HouseNumber, string FlatNumber)
        {
            this.City = City;
            this.PostalCode = PostalCode;
            this.Street = Street;
            this.HouseNumber = HouseNumber;
            this.FlatNumber = FlatNumber;
        }

        public override string ToString()
        {
            return $"City: {City} PostalCode: {PostalCode} Street: {Street} HouseNumber: {HouseNumber} FlatNumber: {FlatNumber}";
        }

        public string PrepareAdress()
        {
            return $"{City};{PostalCode};{Street};{HouseNumber};{FlatNumber}";
        }
    }
}
