﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8.Persistence
{
    public static class Configurations
    {
        public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName}\\Infrastructure\\Lecture_8.Persistence";

            configurationManager.SetBasePath(path);
            configurationManager.AddJsonFile("PrivateInformations.json");
            return configurationManager.GetSection(key).Value;
        }
    }
}
