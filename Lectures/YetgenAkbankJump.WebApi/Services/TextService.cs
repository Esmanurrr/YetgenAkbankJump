using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetgenAkbankJump.Shared;
using YetgenAkbankJump.Shared.Services;

namespace YetgenAkbankJump.WebApi.Services
{
    public class TextService : ITextService
    {
        private readonly string _path;

        public TextService()
        {
            _path = "C:\\Users\\esman\\Desktop\\password.txt";
        }

        public void Save(string text)
        {
            int number = 2;

            var even = number.IsEven();


            if (text.IsEmpty())
            {
                throw new ArgumentNullException("text cannot be null");
            }

            File.WriteAllText(_path, text); 
        }
    }
}
