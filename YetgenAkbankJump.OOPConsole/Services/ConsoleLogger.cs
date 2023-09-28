using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetgenAkbankJump.OOPConsole.Services
{
    public class ConsoleLogger : LoggerBase
    {
        protected internal override void Log(string message) => Console.WriteLine($"{message} - {DateTime.Now:g}");
        
    }
}
