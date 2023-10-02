using Week3_1.Entities;
using Week3_1.Services;

Console.WriteLine("Product Shipping");

Product product1 = new("Product 1", 2.5M, 19.99M);
Product product2 = new("Product 2", 1.8M, 14.49M);
Product product3 = new("Product 3", 3.0M, 24.99M);
Product product4 = new("Product 4", 0.5M, 7.99M);
Product product5 = new("Product 5", 1.2M, 9.99M);

string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Database\\CountryInfos.txt";

NotepadService notepadService = new();
string[] lines = notepadService.ReadFromNotepad(path).Split("\r\n");
List<CountryInformation> countryInformations = new();

foreach (var line in lines)
{
    CountryInformation countryInformation = new(line);
    countryInformations.Add(countryInformation);    
}

ShippingService shippingService = new();

foreach (var countryInfo in countryInformations)
{
    Console.WriteLine(shippingService.CalculateTax(product5,countryInfo));
}

Console.WriteLine();