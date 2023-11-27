using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetgenAkbankJump.Shared
{
    public static class IntegerExtensions
    {
        public static string IsEven(this int value)
        {
            if(value % 2 == 0)
            {
                return "Çift Sayı";
            }

            return "Tek Sayı";
        }
    }
}
