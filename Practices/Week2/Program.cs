// See https://aka.ms/new-console-template for more information
using Week2.Entities;

Console.WriteLine("Encapsulation");

Account account1 = new("Oğuz", "Sağlam");
account1.Withdraw(2000);
account1.Withdraw(200);

Console.WriteLine($"Balance: {account1.Balance}");