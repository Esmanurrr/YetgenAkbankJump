
using Week3__.Entities;
using Week3__.Services;

Console.WriteLine("Product Shipping");

Product product1 = new("Product 1", 2.5M, 19.99M);
Product product2 = new("Product 2", 1.8M, 14.49M);
Product product3 = new("Product 3", 3.0M, 24.99M);
Product product4 = new("Product 4", 0.5M, 7.99M);
Product product5 = new("Product 5", 1.2M, 9.99M);

ShippingService shippingService = new();
Console.WriteLine(shippingService.CalculateTax(product1, "Türkiye"));