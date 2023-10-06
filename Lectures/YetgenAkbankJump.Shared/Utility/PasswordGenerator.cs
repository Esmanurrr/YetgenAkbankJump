using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetgenAkbankJump.OOPConsole.Utility
{
    public class PasswordGenerator
    {
        private readonly Random _random;

        private const string Numbers = "0123456789";
        private const string SpecialChars = "!@#$%^&*()";
        private const string lowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public PasswordGenerator()
        {
            _random = new Random();
        }

        public string Generate(int passwordLength, bool includeNumbers, bool includeLowerCase, bool includeUpperCase, bool specialChars)
        {
            var charsBuilder = new StringBuilder();

            if (includeNumbers)
                charsBuilder.Append(Numbers);

            if(includeLowerCase)
                charsBuilder.Append(lowerCaseChars);


            if (includeUpperCase)
                charsBuilder.Append(upperCaseChars);


            if (specialChars)
                charsBuilder.Append(SpecialChars);

            var acceptedChars = charsBuilder.ToString();

            var passwordBuilder = new StringBuilder();

            for (int i = 0; i < passwordLength; i++)
            {
                var randomIndex = _random.Next(0, acceptedChars.Length);

                passwordBuilder.Append(acceptedChars[randomIndex]);
                
            }

            return passwordBuilder.ToString();
        }

    }
}
