using System;
using System.Text.RegularExpressions;

namespace Trabalho_final.User
{
    public class Email
    {
        public Email(string value)
        {
            Regex emailPattern = new Regex(@"^[a-zA-Z0-9.!#$%&'*+=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$");
            if (!emailPattern.IsMatch(value))
            {
                throw new Exception($"Invalid E-mail: {value}.");
            }
            
            Value = value;
        }

        public string Value { get; }
    }
}
