using FreelanceApp.Abstract;
using FreelanceApp.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceApp.Services
{
    internal class NotepadService
    {
        public void SaveToNotepad(ICsvConvertible data)
        {
            string path = $"{FileLocations.ProjectFile}\\Database";
            string type = data.GetType().ToString().Split(".").LastOrDefault(); //{Freelancer.Entities.Customer} - to get type

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            string filePath = $"{path}\\{type}s.txt";

            File.AppendAllText(filePath, $"{data.GetValuesCSV()}\n");
        }

        public string GetOnNotepad(string path)
        {
            if (File.Exists(path))
                return File.ReadAllText(path);

            throw new Exception("File doesn't exist");
        }
    }
}
