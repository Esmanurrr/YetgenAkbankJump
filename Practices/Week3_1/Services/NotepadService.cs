using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_1.Services
{
    internal class NotepadService
    {
        public string ReadFromNotepad(string filePath)
        {
            if(File.Exists(filePath))
                return File.ReadAllText(filePath);

            throw new Exception("File Not Found");
        }
    }
}
