using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetgenAkbankJump.OOPConsole.Common;
using YetgenAkbankJump.OOPConsole.Enums;

namespace YetgenAkbankJump.OOPConsole.Entities
{
    public class Student : PersonBase
    {
        public int No { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
    }
}
