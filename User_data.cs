using System;

namespace Trabalho_final.User
{
    public class User_data
    {
        public User_data(string name, Email email, Password password, Cpf cpf)
        {
            Name = name;            
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Cpf { get; set; }
    }
}
