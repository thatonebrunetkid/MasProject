using System.Collections.Generic;

namespace ProtegoFrontend.Backoffice.Models
{
    public class AuthenticateModel
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public static List<AuthenticateModel> Users = new List<AuthenticateModel>();

        public AuthenticateModel(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }

        public static void AddUser(AuthenticateModel user)
        {
            Users.Add(user);
        }
    }
}
