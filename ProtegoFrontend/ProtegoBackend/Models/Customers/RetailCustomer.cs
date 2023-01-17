using MasProjekt.Backoffice.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Customers
{
    public class RetailCustomer : Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }
        public Adress Adress { get; set; }

        public RetailCustomer(int CustomerId,  string Name, string Surname, string Pesel, Adress Adress, string ContactNumber, string Email = "") : base(CustomerId, ContactNumber, Email)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Pesel = Pesel;
            this.Adress = Adress; 
        }
        public override string ToString()
        {
            return $"Name: {Name} Surname: {Surname} Pesel: {Pesel} Adress: {Adress.ToString()} Contact Number: {ContactNumber} Email: {Email}";
        }

        public string PrepareCustomerToSave()
        {
            return $"{CustomerId};{Name};{Surname};{Pesel}; ; ;{Adress.PrepareAdress()};{ContactNumber};{Email}";
        }
    }
}
