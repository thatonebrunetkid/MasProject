using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FileApi.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string ContactNumber { get; set; }
        public string? Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Pesel { get; set; }
        public string? CompanyName { get; set; }
        public string? Nip { get; set; }
        public string? Adress { get; set; }
        [InverseProperty("Client")]
        public virtual ICollection<Policies> Policies { get; set; }
    }
}
