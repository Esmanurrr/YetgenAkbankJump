using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetgenAkbankJump.Shared.Services;

namespace YetgenAkbankJump.OOPConsole.Utility
{
    public class PasswordGenerator
    {
        private readonly ITextService _textService;
        private readonly IIPService _ipService;


        private string _lastIp = string.Empty;

        public int GeneratedPasswordsCount { get; set; } = 0;


        private readonly Random _random;

        private const string Numbers = "0123456789";
        private const string SpecialChars = "!@#$%^&*()";
        private const string lowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public PasswordGenerator(ITextService textService, IIPService ipService)
        {
            _random = new Random();
            _textService = textService;
            _ipService = ipService;
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

            GeneratedPasswordsCount++;

            var password = passwordBuilder.ToString();

            _lastIp = _ipService.Ip;

            _textService.Save(password);

            return password;
        }

    }
}
