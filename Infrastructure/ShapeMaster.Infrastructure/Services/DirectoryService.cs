using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Infrastructure.Services
{
    public static class DirectoryService
    {

        public static string ProjectFile => Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        public static bool IsFileExist(string path)
        {
            if (File.Exists(path))
                return true;

            return false;
        }
    }
}
