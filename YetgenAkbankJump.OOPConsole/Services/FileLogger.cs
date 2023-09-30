using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetgenAkbankJump.OOPConsole.Services
{
    public class FileLogger : LoggerBase
    {
        private readonly string _filePath;

        protected internal override string? Name { get; set; } = "Esmanur Mazlum";
        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }
        protected internal override void Log(string message)
        {
            File.AppendAllText(_filePath, message);
        }

        protected internal override void LogError(string message)
        {
            Console.WriteLine(_filePath, $"Error => {message}");
        }

        protected internal override void LogInfo(string message)
        {
            Console.WriteLine(_filePath, $"Info => {message}");
        }

        protected internal override void LogSuccess(string message)
        {
            Console.WriteLine(_filePath, $"Success => {message}");
        }

        protected internal override void LogWarning(string message)
        {
            Console.WriteLine(_filePath, $"Warning => {message}");
        }

        
    }
}
