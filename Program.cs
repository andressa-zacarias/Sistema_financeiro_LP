using System;
using Trabalho_final.User;

namespace Trabalho_final
{
    class Program
    {
        static void Main(string[] args)
        {
        //User_data p = new User_data("Andressa", new Email("teste@teste.com"), new Password("123456") , new Cpf("001.002.003-04"));

            Console.WriteLine("Para realizar o cadastro, digite o seu nome:");
            string name = Console.ReadLine();

            Console.WriteLine("Agora, digite o seu e-mail:");            
            string email = Console.ReadLine();

            Console.WriteLine("Agora, digite uma senha numérica de até 6 números (por exempo 123456):");   
            string password = Console.ReadLine();

            Console.WriteLine("Agora, digite o seu CPF");   
            string cpf = Console.ReadLine();

            User_data p = new User_data(name, new Email(email), new Password(password) , new Cpf(cpf));
        }
    }
}
