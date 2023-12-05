using CleanArchitecture.Application.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private static ConfigurationService instance;

        public static ConfigurationService GetInstance()
        {
            if (instance is null)
                instance = new ConfigurationService();

            return instance;
        }


        public string GetValue(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = Directory.GetCurrentDirectory();

            configurationManager.SetBasePath(path);

            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetSection(key).Value;

        }

        ConfigurationService()
        {
            Console.WriteLine("Instance Created!");
        }
    }
}
