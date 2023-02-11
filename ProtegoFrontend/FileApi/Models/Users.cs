using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace FileApi.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
