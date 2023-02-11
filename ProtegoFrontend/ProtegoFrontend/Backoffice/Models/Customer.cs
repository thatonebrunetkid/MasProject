
using ProtegoFrontend.Backoffice.Models;
using System.Collections.Generic;

namespace MasProjekt.Backoffice.Models.Customers
{
    public class Customer
    {
        public int ClientId { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Pesel { get; set; }
        public string? CompanyName { get; set; }
        public string? Nip { get; set; }
        public string? Adress { get; set; }
        public List<Policies>? Policies { get; set; }
    }
}
