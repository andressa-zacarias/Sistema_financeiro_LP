using System;
using System.Text.RegularExpressions;

namespace Trabalho_final.User
{
    public class Password
    {
        public Password(string value)
        {
            Regex cpfPattern = new Regex(@"[0-9]{6}");
            if (!cpfPattern.IsMatch(value))
            {
                throw new Exception($"Invalid Password: {value}.");
            }
            
            Value = value;
        }

        public string Value { get; }
    }
}