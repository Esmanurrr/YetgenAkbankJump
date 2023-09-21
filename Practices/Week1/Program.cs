using Week1.Entities;
using Week1.Entities.ComputerComponents;
using Week1.Enums;
using Week1.ValueObjects;

Storage storage1 = new Storage("WD Blue", new Capacity(1, CapacitySizeType.TB));

RAM memory1 = new RAM("Corsair", new Capacity(16, CapacitySizeType.GB)); 
RAM memory2 = new RAM("Corsair", new Capacity(8, CapacitySizeType.GB));

Computer computer = new Computer("Apple", "MacBook Pro", "Intel i7",memory1, storage1);
Computer computer5 = new Computer();

Console.WriteLine($"Brand : {computer.Brand} Model : {computer.Model} CPU : {computer.CPU}");
Console.WriteLine($"Storage Size : {computer.Storage.Capacity}");