using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceApp.Constants
{
    internal class FileLocations
    {
        public static string ProjectFile => Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName;
    }
}
