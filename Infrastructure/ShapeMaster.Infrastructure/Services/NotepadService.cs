using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Infrastructure.Services
{
    internal class NotepadService
    {
        public void SaveToNotepad(string data)
        {
            string path = $"{DirectoryService.ProjectFile}\\Database";
            string type = data.GetType().ToString().Split(".").LastOrDefault();

            if (!DirectoryService.IsFileExist(path))
                Directory.CreateDirectory(path);

            string filePath = $"{path}\\{type}s.txt";

            File.AppendAllText(filePath, $"{data}\n");
        }

        public string GetOnNotepad(string path)
        {
            if (File.Exists(path))
                return File.ReadAllText(path);

            throw new Exception("File Doesn't Exist");
        }
    }
}