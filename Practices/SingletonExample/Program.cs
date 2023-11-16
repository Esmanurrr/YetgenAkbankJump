using Microsoft.Extensions.Configuration;
using SingletonExample;

Console.WriteLine("Singleton");

ConfigurationService configurationService = ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance();

var exampleConnectionString = configurationService.GetValue("ConnectionStrings:ExampleDb");